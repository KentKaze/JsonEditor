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
        public JTable ForeignKey { get; set; }

        public static implicit operator JColumn(JObject data)
        {
            return new JColumn();
        }
    }
}
