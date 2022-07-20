using System;
using System.Collections.Generic;
using System.Linq;
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
        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();
            Type type = Type.GetType($"Stealer.{className}");
            var classFields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
            var classPublicMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var classNonPublicMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var classField in classFields)
            {
                sb.AppendLine($"{classField.Name} must be private!");
            }
            foreach (var classNonPublicMethod in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{classNonPublicMethod.Name} have to be public!");
            }
            foreach (var classPublicMethod in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{classPublicMethod.Name} have to be private!");
            }
            return sb.ToString().TrimEnd();
        }
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();
            Type type = Type.GetType(className);
            var privateMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {type.BaseType.Name}");
            foreach (var item in privateMethods)
            {
                sb.AppendLine(item.Name);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
