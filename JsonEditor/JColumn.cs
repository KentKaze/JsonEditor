using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonEditor
{
    public class JColumn
    {
        public string Name { get; set; }
        public bool IsKey { get; set; }
        public string Type { get; set; }
        public string ForeignKey { get; set; }
        public bool Display { get; set; }

        public JColumn(string name, string type, bool isKey = false, bool display = false, string fk = null)
        {
            Name = name;
            IsKey = isKey;
            Type = type;
            Display = display;
            ForeignKey = fk;
            
        }
    }
}
