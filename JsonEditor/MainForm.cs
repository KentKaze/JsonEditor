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
        private Dictionary<string, object> data;
        private List<JLink> jl;
        private Dictionary<string, JTable> tables;

        public MainForm()
        {
            InitializeComponent();
            data = new Dictionary<string, object>();
            jl = new List<JLink>();
            
        }

        private void tmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmiLoadJsonDirectory_Click(object sender, EventArgs e)
        {
#if DEBUG
            fbdMain.SelectedPath = @"C:\WebSite\GoogleDrive";
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
                            jl = JsonConvert.DeserializeObject<List<JLink>>(sr.ReadToEnd());
                        else
                        {
                            //data.Add(Path.GetFileNameWithoutExtension(file), JsonConvert.DeserializeObject(sr.ReadToEnd()));
                            tables.Add(Path.GetFileNameWithoutExtension(file), new JTable(Path.GetFileNameWithoutExtension(file), JsonConvert.DeserializeObject(sr.ReadToEnd())));
                        }
                        sr.Close();
                    }
                }
                
                
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
                sspMain.Text = $"{data.Count} 檔案已讀入";                
            }
        }

        private void RefreshUI()
        {
            //Refresh Tree
            TreeNode FileNode;
            trvJsonFiles.Nodes.Clear();

            foreach (KeyValuePair<string, object> kvp in data)
            {
                FileNode = new TreeNode(kvp.Key);
                trvJsonFiles.Nodes.Add(FileNode);
                JArray jr = kvp.Value as JArray;
                JToken jt = jr.First as JToken;

                JObject jo = jt as JObject;
                foreach (KeyValuePair<string, JToken> kvp2 in jo)
                {
                    FileNode.Nodes.Add(new TreeNode(kvp2.Key));
                }

            }
            //TreeNode tn = new TreeNode("");
            //trvJsonFiles.Nodes.Add();
        }
    }
}
