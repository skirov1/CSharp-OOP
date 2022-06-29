using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CollectionHierarchy
{
    public class MyList : AddMethod, IRemove
    {
        public int Used { get => this.Collection.Count; }

        public List<string> RemoveOperations { get; }

        public MyList() : base()
        {
            this.RemoveOperations = new List<string>();
        }
        public override void AddElement(string element)
        {
            Collection.Insert(0, element);
            AddOperations.Add(0);
        }

        public void RemoveElement()
        {
            var removedElement = Collection[0];
            this.Collection.RemoveAt(0);
            this.RemoveOperations.Add(removedElement);
        }
    }
}
