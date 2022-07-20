using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fields)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {className}");
            sb.AppendLine(GetFieldsInfo(className, fields));
            return sb.ToString().TrimEnd();
        }
        private string GetFieldsInfo(string className, params string[] fields)
        {
            StringBuilder sb = new StringBuilder();
            Type type = Type.GetType(className);
            foreach (var field in fields)
            {
                FieldInfo currentField = type.GetField(field, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
                sb.AppendLine($"{currentField.Name} = {currentField.GetValue(new Hacker())}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
