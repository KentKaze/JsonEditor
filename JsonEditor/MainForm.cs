using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonEditor
{
    public partial class MainForm : Form
    {
        const string linkFileName = "JSONLink.json";
        private Dictionary<string, object> data;
        private JSONLink jl;

        private List<string> currentColumns;
        private List<Type> currentTypes;

        public MainForm()
        {
            InitializeComponent();
            data = new Dictionary<string, object>();
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

                foreach (string file in jsonfiles)
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        StreamReader sr = new StreamReader(fs);
                        if (file == Path.Combine(fbdMain.SelectedPath, linkFileName))
                            jl = JsonConvert.DeserializeObject<JSONLink>(sr.ReadToEnd());
                        else
                            data.Add(Path.GetFileNameWithoutExtension(file), JsonConvert.DeserializeObject(sr.ReadToEnd()));
                        sr.Close();
                    }
                }
                RefreshUI();
                sspMain.Text = $"{data.Count} 檔案已讀入";
                //MessageBox.Show("Files found: " + jsonfiles.Length.ToString(), "Message");
            }
        }

        private void RefreshUI()
        {
            //Refresh Tree
            
            trvJsonFiles.Nodes.Clear();
            currentColumns = new List<string>();
            currentTypes = new List<Type>();

            foreach (object o in data)
            {
                JArray jr = o as JArray;
                
                foreach (JToken jt in jr)
                {
                    JObject jo = jt as JObject;                    
                    foreach(KeyValuePair<string, JToken> kvp in jo)
                    {

                        //MessageBox.Show(kvp.Key);
                        //MessageBox.Show(kvp.Value.ToString());
                        trvJsonFiles.Nodes.Add(new TreeNode($"{kvp.Key}"));
                    }
                    ////IEnumerable<JProperty> jps = ((JObject)jt).Properties();

                    //foreach (JProperty jp in jps)
                    //{
                    //    MessageBox.Show(jp.Name);
                    //}
                    ////MessageBox.Show((jt as JObject).Properties());
                    //foreach(JToken jt2 in jt)
                    //{
                    //    foreach (JToken jt3 in jt2)
                    //        MessageBox.Show(jt3.ToString());
                    //}
                }


                //foreach(JObject o2 in (o as JArray))
                //{
                //    //currentColumns
                //    FieldInfo[] fis =  o2.GetType().GetFields();
                //    foreach(FieldInfo fi in fis)
                //    {
                //        if(!currentColumns.Contains(fi.Name))
                //        {
                //            currentTypes.Add(fi.FieldType);
                //            currentColumns.Add(fi.Name);
                //        }
                //        trvJsonFiles.Nodes.Add(new TreeNode($"{fi.Name}: {fi.GetValue(o2)}"));
                //    }
                //}


            }
            //TreeNode tn = new TreeNode("");
            //trvJsonFiles.Nodes.Add();
        }
    }
}
