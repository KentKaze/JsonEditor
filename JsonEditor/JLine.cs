using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JsonEditor
{
    public class JLine
    {
        Dictionary<string, object> Data { get; set; }

        public static implicit operator JLine(JObject data)
        {
            return new JLine();
        }
    }
}
