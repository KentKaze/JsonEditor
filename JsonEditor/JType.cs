﻿using Newtonsoft.Json.Linq;
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
        Date,
        Time,
        DateTime,
        Guid,
        Uri,
        TimeSpan,
        Undefied
    }

    public static class Extentions
    {
        //public static JType Parse(this JType jt, string str)
        //{
        //    return JType.Byte;
        //}

        public static JType ToJType(this JToken jt)
        {
            
            switch (jt.Type)
            {
                case JTokenType.None:
                    return JType.None;
                case JTokenType.Integer:                    
                    return JType.Long;
                case JTokenType.Float:
                    return JType.Double;
                case JTokenType.String:
                    if (Guid.TryParse(jt.ToString(), out Guid guid))
                        return JType.Guid;
                    else if (DateTime.TryParse(jt.ToString(), out DateTime datetime))
                    {
                        //To do 不嚴謹
                        if (jt.ToString().Length > 10)
                            return JType.DateTime;
                        else if (datetime.TimeOfDay.TotalSeconds == 0)
                            return JType.Date;
                        else
                            return JType.Time;
                    }   
                    return JType.String;
                case JTokenType.Guid:
                    return JType.Guid;
                case JTokenType.Date:
                    return JType.Date;                
                case JTokenType.TimeSpan:
                    return JType.TimeSpan;
                case JTokenType.Uri:
                    return JType.Uri;
                case JTokenType.Null:
                    return JType.String; //Return String
                default:
                    return JType.Undefied;
            }
        }
    }
}
