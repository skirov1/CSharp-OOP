using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {          
            var peopleInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            var productsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            var people = new List<Person>();
            var products = new List<Product>();

            foreach (var personInfo in peopleInfo)
            {
                var currentPersonInfo = personInfo.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var currentPersonName = currentPersonInfo[0];
                var currentPersonMoney = decimal.Parse(currentPersonInfo[1]);
                var person = new Person(currentPersonName, currentPersonMoney);
                people.Add(person);
            }

            foreach (var productInfo in productsInfo)
            {
                var currentProductInfo = productInfo.Split('=', StringSplitOptions.RemoveEmptyEntries);
                var currentProductName = currentProductInfo[0];
                var currentProductCost = decimal.Parse(currentProductInfo[1]);
                var product = new Product(currentProductName, currentProductCost);
                products.Add(product);
            }

            while (true)
            {
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "END")
                {
                    break;
                }
                var personName = cmd[0];
                var productName = cmd[1];
                var person = people.Where(x => x.Name == personName).FirstOrDefault();
                var product = products.Where(x => x.Name == productName).FirstOrDefault();
                person.Buy(product);
            }
            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
