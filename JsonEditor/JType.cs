using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonEditor
{
    public enum JType
    {
        None = 0,
        Long,
        Double,
        String,
        Boolean,
        Null,
        Date,
        Guid,
        Uri,
        TimeSpan
    }
}
