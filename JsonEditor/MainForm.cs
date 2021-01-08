using Newtonsoft.Json;
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

        public MainForm()
        {
            InitializeComponent();
            //data = new Dictionary<string, object>();
            //jl = new List<JFileInfo>();

        }

        private void tmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmiLoadJsonDirectory_Click(object sender, EventArgs e)
        {
            //Dictionary<string, object> data;
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

                ////沒有JFileInfo，產生一個
                //if(jfi == null)
                //{

                //    foreach(JTable jt in tables.Values)
                //    {

                //    }
                //}





                //foreach (KeyValuePair<string, object> kvp in data)
                //{
                //    JTable jTable = new JTable { Name = kvp.Key };


                //    JArray jr = kvp.Value as JArray;
                //    JToken jt = jr.First as JToken;

                //    JObject jo = jt as JObject;
                //    foreach (KeyValuePair<string, JToken> kvp2 in jo)
                //    {
                //        //FileNode.Nodes.Add(new TreeNode(kvp2.Key));
                //    }

                //}

                RefreshUI();
                sspMain.Text = $"{tables.Count} 檔案已讀入";
            }
        }

        private string GetColumnNodeString(JColumn jc)
        {
            return jc.IsKey ? $"{jc.Name}[Key]:{jc.Type}" : $"{jc.Name}:{jc.Type}";
        }

        private void RefreshUI()
        {
            //Refresh Tree
            TreeNode fileNode;
            Dictionary<string, string> fks = new Dictionary<string, string>();
            trvJsonFiles.Nodes.Clear();

            foreach (JTable jt in tables.Values)
            {
                fileNode = new TreeNode(jt.Name);
                foreach (JColumn jc in jt.Columns)
                {
                    fileNode.Nodes.Add(new TreeNode(GetColumnNodeString(jc)));
                    if (!string.IsNullOrEmpty(jc.ForeignKey))
                        fks.Add(jc.Name, jc.ForeignKey);
                }

                foreach (KeyValuePair<string, string> kvp in fks)
                {
                    fileNode.Nodes.Add(new TreeNode($"FK:{kvp.Key} -> {kvp.Value}"));
                }
                trvJsonFiles.Nodes.Add(fileNode);
            }

            //foreach (KeyValuePair<string, object> kvp in table)
            //{
            //    FileNode = new TreeNode(kvp.Key);
            //    trvJsonFiles.Nodes.Add(FileNode);
            //    JArray jr = kvp.Value as JArray;
            //    JToken jt = jr.First as JToken;

            //    JObject jo = jt as JObject;
            //    foreach (KeyValuePair<string, JToken> kvp2 in jo)
            //    {
            //        FileNode.Nodes.Add(new TreeNode(kvp2.Key));
            //    }

            //    //}
            //    //TreeNode tn = new TreeNode("");
            //    //trvJsonFiles.Nodes.Add();
        }

        private void tmiSaveJson_Click(object sender, EventArgs e)
        {
            //存出jfis檔
        }
    }
}
