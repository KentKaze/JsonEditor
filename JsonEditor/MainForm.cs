using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
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

        public MainForm()
        {
            InitializeComponent();
            cobColumnType.DataSource = Enum.GetNames(typeof(JType));
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
                if (jfis != null)
                    foreach(JTable jt in tables.Values)
                        jt.LoadFileInfo(jfis.Find(m => m.Name == jt.Name));

                RefreshJsonFilesUI();
                sspMain.Text = $"{tables.Count} 檔案已讀入";
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

            TreeNode fileNode;
            Dictionary<string, string> fks = new Dictionary<string, string>();
            foreach (JTable jt in tables.Values)
            {
                fileNode = new TreeNode(jt.Name, 0, 0);
                fileNode.Tag = jt.Name;                
                foreach (JColumn jc in jt.Columns)
                {
                    fileNode.Nodes.Add(new TreeNode { Text = GetColumnNodeString(jc), Tag = jc.Name, ImageIndex = 1, SelectedImageIndex = 1 });
                    if (!string.IsNullOrEmpty(jc.ForeignKey))
                        fks.Add(jc.Name, jc.ForeignKey);
                }

                foreach (KeyValuePair<string, string> kvp in fks)
                    fileNode.Nodes.Add(new TreeNode($"FK:{kvp.Key} -> {kvp.Value}", 1, 1));
                trvJsonFiles.Nodes.Add(fileNode);
            }

            tmiCloseAllJsonFiles.Enabled = true;
            
        }

        private void RefreshPnlMainValue()
        {            
            foreach(Control ctls in pnlMain.Controls)
                if(ctls is TextBox)
                    ((TextBox)ctls).Text = "";

            if (selectedLine == null)
                return;

            foreach(KeyValuePair<string, object> kvp in selectedLine)
            {
                TextBox tb = pnlMain.Controls.Find($"txt{kvp.Key}", false)[0] as TextBox;
                if (tb != null)
                    tb.Text = kvp.Value.ToString();
            }
        }

        private void RefreshPnlMainUI()
        {
            pnlMain.Controls.Clear();
            for(int i = 0; i < selectedTable.Columns.Count; i++)
            {
                Label lblLabel = new Label();
                lblLabel.Name = string.Concat("lbl", selectedTable.Columns[i].Name);
                lblLabel.Text = selectedTable.Columns[i].Name;
                lblLabel.Left = 10;
                lblLabel.Top = 30 * i;
                pnlMain.Controls.Add(lblLabel);

                TextBox txtText = new TextBox();
                //    if (pis[i].Name == "LastBestowDate" || pis[i].Name == "ID" ||
                //        pis[i].Name == "PersonID")
                //        txtText.Enabled = false;
                //    if (pis[i].Name == "MoralRank" && CurrentModule == typeof(Person).ToString())
                //        txtText.Enabled = false;
                txtText.Name = string.Concat("txt", selectedTable.Columns[i].Name);
                txtText.Left = 200;
                txtText.Top = 30 * i;
                pnlMain.Controls.Add(txtText);
            }
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
        }

        private void RefreshPnlFileInfoUI()
        {
            if(selectedColumn != null)
            {
                cobColumnType.SelectedIndex = cobColumnType.Items.IndexOf(selectedColumn.Type);
                txtColumnName.Text = selectedColumn.Name;
                chbDisplay.Checked = selectedColumn.Display;
                chbIsKey.Checked = selectedColumn.IsKey;
                txtForeigney.Text = selectedColumn.ForeignKey;
                btnUpdateFileInfo.Enabled = true;
            }
            else
            {   
                txtColumnName.Text = "";
                cobColumnType.SelectedIndex = -1;
                chbDisplay.Checked = false;
                chbIsKey.Checked = false;
                txtForeigney.Text = "";
                btnUpdateFileInfo.Enabled = false;
            }
        }

        private void trvJsonFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)           
            {
                //selectedTable = tables[e.Node.Tag.ToString()];
                selectedColumn = null;                
                RefreshPnlFileInfoUI();
            }
            else
            {   
                selectedColumn = tables[e.Node.Parent.Tag.ToString()].Columns.Find(t => t.Name == e.Node.Tag.ToString());
                RefreshPnlFileInfoUI();
            }
        }

        private void libLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLine = selectedTable[libLines.SelectedIndex];
            RefreshPnlMainValue();
        }

        private void btnUpdateFileInfo_Click(object sender, EventArgs e)
        {
            selectedColumn.Type = cobColumnType.SelectedValue.ToString();
            selectedColumn.Name = txtColumnName.Text;
            selectedColumn.Display = chbDisplay.Checked;
            selectedColumn.IsKey = chbIsKey.Checked;
            selectedColumn.ForeignKey = string.IsNullOrEmpty(txtForeigney.Text) ? txtForeigney.Text : null;
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
            foreach (JTable jy in tables.Values)
                jfis.Add(jy.GetJFileInfo());

            //存JSONFileInfo檔
            using (FileStream fs = new FileStream(Path.Combine(currentFilesPath, linkFileName), FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(JsonConvert.SerializeObject(jfis, Formatting.Indented));
                sw.Close();
            }
            sslMain.Text = $"{currentFilesPath}..所有檔案已存檔";
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
        }

        private void tmiLoadJsonFile_Click(object sender, EventArgs e)
        {

        }

        private void trvJsonFiles_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                selectedTable = tables[e.Node.Tag.ToString()];
                selectedColumn = null;
                RefreshPnlFileInfoUI();
                RefreshLibLinesUI();
                RefreshPnlMainUI();
                
            }
            else
            {
                //selectedColumn = tables[e.Node.Parent.Tag.ToString()].Columns.Find(t => t.Name == e.Node.Tag.ToString());
                //RefreshPnlFileInfoUI();
            }
        }
    }
}
