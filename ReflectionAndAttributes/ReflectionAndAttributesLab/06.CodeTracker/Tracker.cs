using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance))
                {
                    var attr = method.GetCustomAttribute<AuthorAttribute>();
                    if (attr != null)
                    {
                        Console.WriteLine($"{method.Name} is written by {attr.Name}");
                    }
                }
            }
        }
    }
}
