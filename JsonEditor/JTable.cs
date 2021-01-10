using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using System.Dynamic;

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
            bool isFirst = true;
            bool isFirstFirst = true;

            Name = name;
            if (jArray == null)
                return;

            JArray jr = jArray as JArray;
            if (jr == null)
                throw new ArgumentNullException();

            foreach (JToken jt in jr)
            {
                Dictionary<string, object> items = new Dictionary<string, object>();
                JObject jo = jt as JObject;
                foreach (KeyValuePair<string, JToken> kvp in jo)
                {
                    if (isFirstFirst)
                    {
                        JColumn jc = new JColumn(kvp.Key, kvp.Value.ToJType(), kvp.Key == "ID", true,
                            Math.Abs(kvp.Value.ToString().Length / 50) + 1);
                        Columns.Add(jc);
                        isFirstFirst = false;
                    }
                    else if (isFirst)
                        Columns.Add(new JColumn(kvp.Key, kvp.Value.ToJType(), kvp.Key == "ID", false,
                            Math.Abs(kvp.Value.ToString().Length / 50) + 1));

                    switch (kvp.Value.Type)
                    {
                        case JTokenType.Integer:
                            items.Add(kvp.Key, Convert.ToInt32(kvp.Value));
                            break;
                        case JTokenType.Float:
                            items.Add(kvp.Key, Convert.ToDouble(kvp.Value));
                            break;
                        case JTokenType.Guid:
                            items.Add(kvp.Key, Guid.Parse(kvp.Value.ToString()));
                            break;
                        case JTokenType.Null:
                            items.Add(kvp.Key, null);
                            break;
                        case JTokenType.Boolean:
                            items.Add(kvp.Key, Convert.ToBoolean(kvp.Value));
                            break;                        
                        case JTokenType.Date:
                            items.Add(kvp.Key, DateTime.Parse(kvp.Value.ToString()));
                            break;
                        default:
                            items.Add(kvp.Key, kvp.Value.ToString());
                            break;
                    }
                }
                isFirst = false;
                Lines.Add(items);
            }

        }

        /// <summary>
        /// 讀取JFileInfo檔案設定
        /// </summary>
        /// <param name="jfi"></param>
        public void LoadFileInfo(JFileInfo jfi)
        {
            //檢查一下是否正確
            if (jfi == null)
                throw new ArgumentNullException();            
            if (Name != jfi.Name)
                throw new InvalidCastException();            
            if (Columns.Count != jfi.Columns.Count)
                throw new MissingFieldException();
            for(int i = 0; i < jfi.Columns.Count; i++)
                if (Columns[i].Name != jfi.Columns[i].Name)
                    throw new MissingFieldException();
            Columns = jfi.Columns;
        }

        /// <summary>
        /// 擷取JFileInfo檔案內容
        /// </summary>
        /// <returns></returns>
        public JFileInfo GetJFileInfo()
        {
            JFileInfo jfi = new JFileInfo();
            List<JColumn> jcs = new List<JColumn>(Columns);            
            jfi.Name = Name;
            jfi.Columns = jcs;
            return jfi;
        }
        /// <summary>
        /// 擷取存檔用的Data Object
        /// </summary>
        /// <returns></returns>
        public object GetJsonObject()
        {            
            List<object> result = new List<object>();
            foreach(Dictionary<string, object> l in Lines)
            {                
                var line = new ExpandoObject() as IDictionary<string, object>;
                foreach (KeyValuePair<string, object> kvp in l)
                {
                    line.Add(kvp.Key, kvp.Value);                    
                }
                result.Add(line);
            }
            return result;
        }

        /// <summary>
        /// 用欄位資訊確認末端值的型別並進行轉換
        /// </summary>
        /// <param name="inputValue">值</param>
        /// <param name="columnName">欄位名</param>
        /// <returns></returns>
        public object ParseValue(object inputValue, string columnName)
        {
            JType jt = Columns.Find(m => m.Name == columnName).Type;
            switch (jt)
            {
                case JType.Boolean:
                    return Convert.ToBoolean(inputValue);
                case JType.Long:
                    return Convert.ToInt64(inputValue);
                case JType.Integer:
                    return Convert.ToInt32(inputValue);
                case JType.Double:
                    return Convert.ToDouble(inputValue);
                case JType.Byte:
                    return Convert.ToByte(inputValue);
                case JType.Date:
                    return Convert.ToDateTime(inputValue).ToShortDateString();
                case JType.Time:
                    return Convert.ToDateTime(inputValue).TimeOfDay.ToString();
                case JType.DateTime:
                    return Convert.ToDateTime(inputValue);
                case JType.String:
                    return Convert.ToString(inputValue);
                case JType.Guid:
                    return Guid.Parse(inputValue.ToString());                        
                default:
                    return Convert.ChangeType(inputValue, Type.GetType(jt.ToString()));
            }
        }
    }
}
