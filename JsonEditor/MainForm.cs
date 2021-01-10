using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace JsonEditor
{
    public partial class MainForm : Form
    {
        const string linkFileName = "JFileInfo.json";
        private Dictionary<string, JTable> tables;
        private JColumn selectedColumn;
        private JTable selectedTable;
        private Dictionary<string, object> selectedLine;
        private string currentFilesPath;
        private bool dblClick;

        public MainForm()
        {
            InitializeComponent();
            cobColumnType.DataSource = Enum.GetValues(typeof(JType));
            cobColumnType.SelectedIndex = -1;
        }

        private void tmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void tmiLoadJsonDirectory_Click(object sender, EventArgs e)
        {
            List<JFileInfo> jfis = new List<JFileInfo>();
#if DEBUG
            fbdMain.SelectedPath = @"C:\Programs\WinForm\JsonEditor\JsonEditor\TestData";
#endif
            DialogResult dr = fbdMain.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                tmiCloseAllJsonFiles_Click(this, e);
                currentFilesPath = fbdMain.SelectedPath;
                string[] jsonfiles = Directory.GetFiles(currentFilesPath, "*.json");
                tables = new Dictionary<string, JTable>();
                foreach (string file in jsonfiles)
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        StreamReader sr = new StreamReader(fs);
                        if (file == Path.Combine(currentFilesPath, linkFileName))
                        {
                            jfis = JsonConvert.DeserializeObject<List<JFileInfo>>(sr.ReadToEnd());
                        }
                        else
                        {
                            tables.Add(Path.GetFileNameWithoutExtension(file), new JTable(Path.GetFileNameWithoutExtension(file), JsonConvert.DeserializeObject(sr.ReadToEnd())));
                        }
                        sr.Close();
                    }
                }

                //有JFileInfo的話相連
                if (jfis.Count != 0)
                    foreach (JTable jt in tables.Values)
                        jt.LoadFileInfo(jfis.Find(m => m.Name == jt.Name));

                RefreshJsonFilesUI();
                sslMain.Text = $"{tables.Count} 檔案已讀入";
            }
        }

        private string GetColumnNodeString(JColumn jc)
        {
            return jc.IsKey ? $"{jc.Name}[Key]:{jc.Type}" : $"{jc.Name}:{jc.Type}";
        }

        private void RefreshJsonFilesUI()
        {
            trvJsonFiles.Nodes.Clear();
            tmiCloseAllJsonFiles.Enabled = false;
            if (tables == null)
                return;

            TreeNode fileNode, tr;
            Dictionary<string, string> fks = new Dictionary<string, string>();
            foreach (JTable jt in tables.Values)
            {
                fileNode = new TreeNode(jt.Name, 0, 0);
                trvJsonFiles.Nodes.Add(fileNode);
                fileNode.Tag = jt.Name;
                foreach (JColumn jc in jt.Columns)
                {
                    tr = new TreeNode { Text = GetColumnNodeString(jc), Tag = jc.Name, ImageIndex = 1, SelectedImageIndex = 1 };
                    fileNode.Nodes.Add(tr);
                    if (selectedColumn == jc)
                        trvJsonFiles.SelectedNode = tr;
                    if (!string.IsNullOrEmpty(jc.ForeignKey))
                        fks.Add(jc.Name, jc.ForeignKey);
                }

                foreach (KeyValuePair<string, string> kvp in fks)
                    fileNode.Nodes.Add(new TreeNode($"FK:{kvp.Key} -> {kvp.Value}", 1, 1));

            }

            tmiCloseAllJsonFiles.Enabled = true;
        }

        private void RefreshPnlMainValue()
        {
            btnClearMain.Enabled = false;
            btnUpdateMain.Enabled = false;

            foreach (Control ctls in pnlMain.Controls)
                if (ctls is TextBox)
                    ((TextBox)ctls).Text = "";

            if (selectedLine == null)
                return;

            foreach (KeyValuePair<string, object> kvp in selectedLine)
            {
                TextBox tb = pnlMain.Controls.Find($"txt{kvp.Key}", false)[0] as TextBox;
                if (tb != null)
                    tb.Text = kvp.Value.ToString();
            }
            btnClearMain.Enabled = true;
            btnUpdateMain.Enabled = true;
        }

        private void RefreshPnlMainUI()
        {
            btnClearMain.Enabled = false;
            btnUpdateMain.Enabled = false;
            int lines = 0;
            pnlMain.Controls.Clear();
            if (selectedTable == null)
                return;
            for (int i = 0; i < selectedTable.Columns.Count; i++)
            {
                Label lblLabel = new Label();
                lblLabel.Name = string.Concat("lbl", selectedTable.Columns[i].Name);
                lblLabel.Text = selectedTable.Columns[i].Name;
                lblLabel.Left = 10;
                lblLabel.Top = 30 * lines;

                pnlMain.Controls.Add(lblLabel);

                TextBox txtText = new TextBox();
                //    if (pis[i].Name == "LastBestowDate" || pis[i].Name == "ID" ||
                //        pis[i].Name == "PersonID")
                //        txtText.Enabled = false;
                //    if (pis[i].Name == "MoralRank" && CurrentModule == typeof(Person).ToString())
                //        txtText.Enabled = false;
                txtText.Name = string.Concat("txt", selectedTable.Columns[i].Name);
                txtText.Left = 200;
                txtText.Top = 30 * lines;
                txtText.Width = 200;
                txtText.Height = 27 * selectedTable.Columns[i].NumberOfRows;
                txtText.Multiline = true;
                lines += selectedTable.Columns[i].NumberOfRows;
                pnlMain.Controls.Add(txtText);
            }
            btnClearMain.Enabled = true;
            btnUpdateMain.Enabled = true;
        }

        private void RefreshLibLinesUI()
        {
            libLines.Items.Clear();
            if (selectedTable == null)
                return;

            List<string> displayColumns = new List<string>();
            string displayString;

            foreach (JColumn jc in selectedTable.Columns)
                if (jc.Display)
                    displayColumns.Add(jc.Name);

            foreach (Dictionary<string, object> line in selectedTable.Lines)
            {
                displayString = "";
                foreach (KeyValuePair<string, object> kvp in line)
                {
                    if (displayColumns.Contains(kvp.Key))
                        displayString = $"{displayString}{kvp.Value} ";
                }
                libLines.Items.Add(displayString);
            }

            if (selectedLine != null)
                libLines.SelectedIndex = selectedTable.Lines.FindIndex(m => m == selectedLine);
        }

        private void RefreshPnlFileInfoUI()
        {
            if (selectedColumn != null)
            {
                cobColumnType.SelectedIndex = cobColumnType.Items.IndexOf(selectedColumn.Type);
                txtColumnName.Text = selectedColumn.Name;
                chbDisplay.Checked = selectedColumn.Display;
                chbIsKey.Checked = selectedColumn.IsKey;
                txtForeignKey.Text = selectedColumn.ForeignKey;
                txtNumberOfRows.Text = selectedColumn.NumberOfRows.ToString();
                btnUpdateFileInfo.Enabled = true;
            }
            else
            {
                txtColumnName.Text = "";
                cobColumnType.SelectedIndex = -1;
                chbDisplay.Checked = false;
                chbIsKey.Checked = false;
                txtForeignKey.Text = "";
                txtNumberOfRows.Text = "0";
                btnUpdateFileInfo.Enabled = false;
            }
        }

        private void trvJsonFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                selectedColumn = null;
                RefreshPnlFileInfoUI();

                if (e.Button == MouseButtons.Right)
                {
                    trvJsonFiles.SelectedNode = e.Node;
                    if (selectedTable == tables[e.Node.Tag.ToString()])
                    { 
                        tmiOpenJsonFile.Enabled = false;
                        tmiCloseJsonFile.Enabled = true;
                    }
                    else
                    {
                        tmiOpenJsonFile.Enabled = true;
                        tmiCloseJsonFile.Enabled = false;
                    }
                    trvJsonFiles.ContextMenuStrip = cmsJsonFilesSelected;
                }
            }
            else
            {
                selectedColumn = tables[e.Node.Parent.Tag.ToString()].Columns.Find(t => t.Name == e.Node.Tag.ToString());
                RefreshPnlFileInfoUI();
                if (e.Button == MouseButtons.Right)
                    trvJsonFiles.ContextMenuStrip = null;
            }
        }

        private void libLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (libLines.SelectedIndex == -1)
                return;
            selectedLine = selectedTable[libLines.SelectedIndex];
            RefreshPnlMainValue();
        }

        private void btnUpdateFileInfo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumberOfRows.Text, out int i))
            {
                MessageBox.Show("欄位行數數值不正確");
                return;
            }

            selectedColumn.Type = (JType)cobColumnType.SelectedValue;
            selectedColumn.Name = txtColumnName.Text;
            selectedColumn.Display = chbDisplay.Checked;
            selectedColumn.IsKey = chbIsKey.Checked;
            selectedColumn.NumberOfRows = Convert.ToInt32(txtNumberOfRows.Text);
            selectedColumn.ForeignKey = string.IsNullOrEmpty(txtForeignKey.Text) ? txtForeignKey.Text : null;
            sslMain.Text = $"欄位「{selectedColumn.Name}」已更新";
            RefreshJsonFilesUI();
            RefreshLibLinesUI();
            RefreshPnlMainUI();
            RefreshPnlMainValue();
        }

        private void trvJsonFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("JSON 資料檔案編輯器 0.1\n\n Created by KentKaze", "關於", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmiNewJsonFile_Click(object sender, EventArgs e)
        {

        }

        private void tmiSaveJsonFile_Click(object sender, EventArgs e)
        {

        }

        private void tmiSaveJsonFiles_Click(object sender, EventArgs e)
        {
            List<JFileInfo> jfis = new List<JFileInfo>();
            foreach (JTable jt in tables.Values)
                jfis.Add(jt.GetJFileInfo());

            //存JSONFileInfo檔
            using (FileStream fs = new FileStream(Path.Combine(currentFilesPath, linkFileName), FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(JsonConvert.SerializeObject(jfis, Formatting.Indented));
                sw.Close();
            }

            //存JSONFiles
            foreach(JTable jt in tables.Values)
            {   
                using (FileStream fs = new FileStream(Path.Combine(currentFilesPath, $"{jt.Name}.json"), FileMode.Create))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(JsonConvert.SerializeObject(jt.GetJsonObject(), Formatting.Indented));
                    sw.Close();
                }
            }
            sslMain.Text = $"\"{currentFilesPath}\"所有檔案已存檔";
        }

        private void tmiCloseAllJsonFiles_Click(object sender, EventArgs e)
        {
            tables = null;
            currentFilesPath = null;
            selectedColumn = null;
            selectedTable = null;
            selectedLine = null;
            RefreshJsonFilesUI();
            RefreshPnlFileInfoUI();
            RefreshLibLinesUI();
            RefreshPnlMainUI();
            sslMain.Text = "";
        }

        private void tmiLoadJsonFile_Click(object sender, EventArgs e)
        {

        }

        private void trvJsonFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                trvJsonFiles.SelectedNode = e.Node;
                tmiOpenJsonFile_Click(this, e);
            }
            else
            {
                //selectedColumn = tables[e.Node.Parent.Tag.ToString()].Columns.Find(t => t.Name == e.Node.Tag.ToString());
                //RefreshPnlFileInfoUI();
            }
        }

        private void trvJsonFiles_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (dblClick)
                e.Cancel = true;
        }

        private void trvJsonFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                trvJsonFiles.ContextMenuStrip = cmsJsonFiles;
            dblClick = e.Button == MouseButtons.Left && e.Clicks >= 2;
        }

        private void trvJsonFiles_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (dblClick)
                e.Cancel = true;
        }

        private void btnUpdateMain_Click(object sender, EventArgs e)
        {
            TextBox tb;
            foreach (Control c in pnlMain.Controls)
            {
                if (c as TextBox == null)
                    continue;
                tb = c as TextBox;
                selectedLine[tb.Name.Substring(3)] = selectedTable.ParseValue(tb.Text, tb.Name.Substring(3));

            }
            RefreshLibLinesUI();
            sslMain.Text = "Data Updated";
        }

        private void btnClearMain_Click(object sender, EventArgs e)
        {
            TextBox tb;
            foreach (Control c in pnlMain.Controls)
            {
                if (c as TextBox == null)
                    continue;
                tb = c as TextBox;
                tb.Text = "";
            }
        }

        private void tmiNewJsonFiles_Click(object sender, EventArgs e)
        {
            List<JFileInfo> jfis = new List<JFileInfo>();
#if DEBUG
            fbdMain.SelectedPath = @"C:\Programs\WinForm\JsonEditor\JsonEditor\TestData";
#endif      
            DialogResult dr = fbdMain.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                
                string[] jsonfiles = Directory.GetFiles(fbdMain.SelectedPath, "*.json");
                if (jsonfiles.Length > 0)
                {
                    if (jsonfiles.Length == 1 && jsonfiles[0] == Path.Combine(fbdMain.SelectedPath, linkFileName))
                        File.Delete(jsonfiles[0]);
                    else
                    {
                        if(File.Exists(Path.Combine(fbdMain.SelectedPath, linkFileName)))
                            dr = MessageBox.Show($"此文件已有現存{jsonfiles.Length - 1} JSON檔案，是否要清空資料夾", "清空Json檔案", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        else
                            dr = MessageBox.Show($"此文件已有現存{jsonfiles.Length} JSON檔案，是否要清空資料夾", "清空Json檔案", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            foreach (string s in jsonfiles)
                                File.Delete(s);
                        }
                        else
                            return;
                    }
                }

                tmiCloseAllJsonFiles_Click(this, e);
                tables = new Dictionary<string, JTable>();
                currentFilesPath = fbdMain.SelectedPath;
                tmiCloseAllJsonFiles.Enabled = true;
                sslMain.Text = $"已在\"{fbdMain.SelectedPath}\"新建檔案資料夾";
            }
        }

        private void tmiOpenJsonFile_Click(object sender, EventArgs e)
        {
            selectedTable = tables[trvJsonFiles.SelectedNode.Tag.ToString()];
            selectedLine = null;
            selectedColumn = null;
            RefreshPnlFileInfoUI();
            RefreshPnlMainUI();
            RefreshLibLinesUI();
        }

        private void tmiRenameJsonFile_Click(object sender, EventArgs e)
        {
            trvJsonFiles.SelectedNode.BeginEdit();
        }

        private void trvJsonFiles_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            //檔案改名
            //MessageBox.Show(e.Label);
            //MessageBox.Show(e.Node.Text);
            try
            {
                JTable tb = tables[e.Node.Tag.ToString()];
                tables.Remove(e.Node.Tag.ToString());
                tb.Name = e.Label;
                e.Node.Tag = e.Label;
                tables.Add(e.Label, tb);                
                File.Move(Path.Combine(currentFilesPath, $"{e.Node.Text}.json"), Path.Combine(currentFilesPath, $"{e.Label}.json"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.HResult.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trvJsonFiles_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Parent != null)
                e.CancelEdit = true;
        }

        private void tmiCloseJsonFile_Click(object sender, EventArgs e)
        {
            selectedTable = null;
            selectedLine = null;
            selectedColumn = null;
            RefreshPnlFileInfoUI();
            RefreshPnlMainUI();
            RefreshLibLinesUI();
        }
    }
}
