using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonEditor
{
    public class JSONLink
    {
        public string JSONName { get; set; }
        public string KeyName { get; set; }
        public List<ForeignKey> ForeignKeys { get; set; }
    }
}
