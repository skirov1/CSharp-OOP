using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CollectionHierarchy
{
    public interface IRemove
    {
        public void RemoveElement();
        public List<string> RemoveOperations { get; }
    }
}
