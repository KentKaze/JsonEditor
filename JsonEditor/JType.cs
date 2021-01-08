using Newtonsoft.Json.Linq;
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
        Byte,
        Integer,
        Long,
        Double,
        String,
        Boolean,
        Null,
        Date,
        Guid,
        Uri,
        TimeSpan,
        Undefied
    }

    public static class Extentions
    {
        public static JType ToJType(this JTokenType jtt)
        {
            switch (jtt)
            {
                case JTokenType.None:
                    return JType.None;
                case JTokenType.Integer:
                    return JType.Long;
                case JTokenType.String:
                    return JType.String;
                case JTokenType.Float:
                    return JType.Double;
                case JTokenType.Guid:
                    return JType.Guid;
                case JTokenType.Date:
                    return JType.Date;
                case JTokenType.TimeSpan:
                    return JType.TimeSpan;
                case JTokenType.Uri:
                    return JType.Uri;
                case JTokenType.Null:
                    return JType.Null;                
                default:
                    return JType.Undefied;
            }
        }
    }
}
