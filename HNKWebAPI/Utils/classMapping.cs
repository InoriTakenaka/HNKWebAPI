using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace HNKWebAPI.Utils {
    public static class ClassMapping {
        public static DST ClassMemberMapping<SRC, DST>(SRC src)
            where DST : new() {
            DST dst = new DST();
            List<PropertyInfo> srcProps = typeof(SRC).GetProperties().ToList();
            List<PropertyInfo> dstProps = typeof(DST).GetProperties().ToList();

            foreach (var dstMember in dstProps) {
                DataMapAttribute tag
                    = dstMember.GetCustomAttributes(typeof(DataMapAttribute), false).FirstOrDefault() as DataMapAttribute;
                if (tag == null) continue;
                PropertyInfo srcPropInfo = srcProps.Where(srcProp =>
                    srcProp.Name.Equals(tag.m_field)
                ).FirstOrDefault();
                object srcPropVal = srcPropInfo.GetValue(src, null);
                dstMember.SetValue(dst, srcPropVal, null);
            }
            return dst;
        }
    }
}
