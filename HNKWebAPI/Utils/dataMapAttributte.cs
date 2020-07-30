using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HNKWebAPI.Utils {
    [AttributeUsage(AttributeTargets.Property,AllowMultiple=true)]
    public class DataMapAttribute:Attribute
    {
        public string  m_field { get; set; }

        public DataMapAttribute(string fieldName)
        {
            m_field = fieldName;
        }
    }
}
