using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var type = Console.ReadLine();
                if (type == "Beast!")
                {
                    break;
                }
                var data = Console.ReadLine().Split();
                if (type == "Cat")
                {
                    var name = data[0];
                    var age = int.Parse(data[1]);
                    var gender = data[2];
                    var cat = new Cat(name, age, gender);
                    Console.WriteLine(cat.ToString());
                }
                else if (type == "Dog")
                {
                    var name = data[0];
                    var age = int.Parse(data[1]);
                    var gender = data[2];
                    var dog = new Dog(name, age, gender);
                    Console.WriteLine(dog.ToString());
                }
                else if (type == "Frog")
                {
                    var name = data[0];
                    var age = int.Parse(data[1]);
                    var gender = data[2];
                    var frog = new Frog(name, age, gender);
                    Console.WriteLine(frog.ToString());
                }
                else if (type == "Kitten")
                {
                    var name = data[0];
                    var age = int.Parse(data[1]);
                    var gender = data[2];
                    var kitten = new Kitten(name, age);
                    Console.WriteLine(kitten.ToString());
                }
                else if (type == "Tomcat")
                {
                    var name = data[0];
                    var age = int.Parse(data[1]);
                    var gender = data[2];
                    var tomcat = new Tomcat(name, age);
                    Console.WriteLine(tomcat.ToString());
                }
            }
        }
    }
}
