using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private List<string> list = new List<string>();
        public string RandomString()
        {
            Random rnd = new Random();
            var elementIndex = rnd.Next(0, list.Count);
            var element = list[elementIndex];
            list.RemoveAt(elementIndex);
            return element;
        }
    }
}
