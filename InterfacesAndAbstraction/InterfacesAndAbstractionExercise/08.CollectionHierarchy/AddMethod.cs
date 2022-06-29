using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CollectionHierarchy
{
    public abstract class AddMethod
    {
        public List<string> Collection { get; set; }
        public List<int> AddOperations { get; set; }
        public AddMethod()
        {
            this.Collection = new List<string>();
            this.AddOperations = new List<int>();
        }
        public virtual void AddElement(string element) 
        {
            Collection.Add(element);
            AddOperations.Add(Collection.Count - 1);
        }
    }
}
