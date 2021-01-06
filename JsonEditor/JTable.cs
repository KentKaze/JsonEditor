using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

namespace JsonEditor
{
    public class JTable : IList<Dictionary<string, object>>
    {
        public Dictionary<string, object> this[int index] { get => ((IList<Dictionary<string, object>>)Lines)[index]; set => ((IList<Dictionary<string, object>>)Lines)[index] = value; }

        public string Name { get; set; }
        public List<JColumn> Columns { get; set; } = new List<JColumn>();
        public List<Dictionary<string, object>> Lines { get; set; } = new List<Dictionary<string, object>>();

        public int Count => ((IList<Dictionary<string, object>>)Lines).Count;

        public bool IsReadOnly => ((IList<Dictionary<string, object>>)Lines).IsReadOnly;

        public void Add(Dictionary<string, object> item)
        {
            ((IList<Dictionary<string, object>>)Lines).Add(item);
        }

        public void Clear()
        {
            ((IList<Dictionary<string, object>>)Lines).Clear();
        }

        public bool Contains(Dictionary<string, object> item)
        {
            return ((IList<Dictionary<string, object>>)Lines).Contains(item);
        }

        public void CopyTo(Dictionary<string, object>[] array, int arrayIndex)
        {
            ((IList<Dictionary<string, object>>)Lines).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Dictionary<string, object>> GetEnumerator()
        {
            return ((IList<Dictionary<string, object>>)Lines).GetEnumerator();
        }

        public int IndexOf(Dictionary<string, object> item)
        {
            return ((IList<Dictionary<string, object>>)Lines).IndexOf(item);
        }

        public void Insert(int index, Dictionary<string, object> item)
        {
            ((IList<Dictionary<string, object>>)Lines).Insert(index, item);
        }

        public bool Remove(Dictionary<string, object> item)
        {
            return ((IList<Dictionary<string, object>>)Lines).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<Dictionary<string, object>>)Lines).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<Dictionary<string, object>>)Lines).GetEnumerator();
        }

        public JTable()
            : this("", null)
        { }

        public JTable(string name, object jArray)
        {
            Name = name;
            if (jArray == null)
                return;

            JArray jr = jArray as JArray;
            if (jr == null)
                throw new System.Exception();

            foreach (JToken jt in jr)
            {
                Dictionary<string, object> items = new Dictionary<string, object>();
                JObject jo = jt as JObject;
                foreach (KeyValuePair<string, JToken> kvp in jo)
                {
                    switch (kvp.Value.Type)
                    {
                        case JTokenType.Integer:
                            items.Add(kvp.Key, Convert.ToInt32(kvp.Value));
                            break;
                        case JTokenType.Float:
                            items.Add(kvp.Key, Convert.ToDouble(kvp.Value));
                            break;
                        case JTokenType.Null:
                            items.Add(kvp.Key, null);
                            break;
                        case JTokenType.Boolean:
                            items.Add(kvp.Key, Convert.ToBoolean(kvp.Value));
                            break;
                        case JTokenType.Guid:
                            items.Add(kvp.Key, Guid.Parse(kvp.Value.ToString()));
                            break;
                        case JTokenType.Date:
                            items.Add(kvp.Key, DateTime.Parse(kvp.Value.ToString()));
                            break;
                        default:
                            items.Add(kvp.Key, kvp.Value.ToString());
                            break;
                    }
                }
                Lines.Add(items);

            }

        }
        //public static implicit operator JTable(JArray data)
        //{
        //    JTable result = new JTable();

        //    foreach (KeyValuePair<string, object> kvp in data)
        //    {
        //        result.Name = 


        //    //    JArray jr = kvp.Value as JArray;
        //    //    JToken jt = jr.First as JToken;

        //    //    JObject jo = jt as JObject;
        //    //    foreach (KeyValuePair<string, JToken> kvp2 in jo)
        //    //    {
        //    //        //FileNode.Nodes.Add(new TreeNode(kvp2.Key));
        //    //    }

        //    //}
        //    return new JTable();
        //}

        //public static implicit operator JTable(JArray data)
        //{
        //    JTable result = new JTable();

        //    return new JTable();
        //}
    }
}
