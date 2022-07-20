using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (var prop in properties)
            {
                var attributes = prop.GetCustomAttributes().Where(t => t.GetType().IsSubclassOf(typeof(MyValidationAttribute))).Cast<MyValidationAttribute>().ToArray();

                foreach (var attr in attributes)
                {
                    var isValid = attr.IsValid(prop.GetValue(obj));

                    if (!isValid)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
