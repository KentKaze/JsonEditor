using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace JsonEditor
{
    public partial class MainForm : Form
    {
        const string linkFileName = "JSONLink.json";
        private Dictionary<string, JTable> tables;
        private JColumn selectedColumn;
        private JTable selectedTable;
        private Dictionary<string, object> selectedLine;

        public MainForm()
        {
            InitializeComponent();

            cobColumnType.DataSource = Enum.GetNames(typeof(JTokenType));
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
                string[] jsonfiles = Directory.GetFiles(fbdMain.SelectedPath, "*.json");
                tables = new Dictionary<string, JTable>();
                foreach (string file in jsonfiles)
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        StreamReader sr = new StreamReader(fs);
                        if (file == Path.Combine(fbdMain.SelectedPath, linkFileName))
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
                {
                    //相連
                }

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
            TreeNode fileNode;
            Dictionary<string, string> fks = new Dictionary<string, string>();
            trvJsonFiles.Nodes.Clear();

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
         
        }

        private void RefreshLibLinesUI()
        {
            List<string> displayColumns = new List<string>();
            string displayString;
            libLines.Items.Clear();
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
            cobColumnType.SelectedIndex = cobColumnType.Items.IndexOf(selectedColumn.Type);
            txtColumnName.Text = selectedColumn.Name;
            chbDisplay.Checked = selectedColumn.Display;
            chbIsKey.Checked = selectedColumn.IsKey;
            txtForeigney.Text = selectedColumn.ForeignKey;
        }

        private void tmiSaveJson_Click(object sender, EventArgs e)
        {
            //存出jfis檔
            
        }

        private void trvJsonFiles_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {           
            if (e.Node.Parent == null)           
            {
                selectedTable = tables[e.Node.Tag.ToString()];
                RefreshLibLinesUI();
            }
            else
            {   
                selectedColumn = tables[e.Node.Parent.Tag.ToString()].Columns.Find(t => t.Name == e.Node.Tag.ToString());                
                RefreshPnlFileInfoUI();
            }
        }

        private void libLines_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateFileInfo_Click(object sender, EventArgs e)
        {

        }

        private void trvJsonFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
