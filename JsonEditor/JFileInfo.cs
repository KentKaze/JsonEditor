using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonEditor
{
    public class JFileInfo
    {
        public string Name { get; set; }
        public string Key { get; set; } 
        public List<JColumn> Columns { get; set; }
        //public List<ForeignKey> ForeignKeys { get; set; }
    }
}
