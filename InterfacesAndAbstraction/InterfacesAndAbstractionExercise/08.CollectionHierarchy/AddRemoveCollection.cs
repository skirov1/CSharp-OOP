using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CollectionHierarchy
{
    public class AddRemoveCollection : AddMethod, IRemove
    {
        public List<string> RemoveOperations { get; }
        public AddRemoveCollection() : base()
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
            var removedElement = Collection[Collection.Count - 1];
            this.Collection.Remove(removedElement);
            this.RemoveOperations.Add(removedElement);
        }
    }
}
