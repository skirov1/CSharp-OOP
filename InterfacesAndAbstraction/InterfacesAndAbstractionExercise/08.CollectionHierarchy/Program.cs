using System;

namespace _08.CollectionHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();
            var elementsToAdd = Console.ReadLine().Split();
            foreach (var element in elementsToAdd)
            {
                addCollection.AddElement(element);
                addRemoveCollection.AddElement(element);
                myList.AddElement(element);
            }
            var countOfRemoveOperations = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfRemoveOperations; i++)
            {
                addRemoveCollection.RemoveElement();
                myList.RemoveElement();
            }
            Console.WriteLine(string.Join(" ", addCollection.AddOperations));
            Console.WriteLine(string.Join(" ", addRemoveCollection.AddOperations));
            Console.WriteLine(string.Join(" ", myList.AddOperations));
            Console.WriteLine(string.Join(" ", addRemoveCollection.RemoveOperations));
            Console.WriteLine(string.Join(" ", myList.RemoveOperations));
        }
    }
}
