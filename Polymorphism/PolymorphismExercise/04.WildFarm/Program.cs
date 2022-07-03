using _04.WildFarm.Animals;
using _04.WildFarm.Food;
using System;
using System.Collections.Generic;

namespace _04.WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>();
            while (true)
            {
                var animalInfo = Console.ReadLine().Split();
                if (animalInfo[0] == "End")
                {
                    break;
                }
                var animalType = animalInfo[0];
                var animalName = animalInfo[1];
                IAnimal animal = null;
                if (animalType == "Cat" || animalType == "Tiger")
                {
                    var animalWeight = double.Parse(animalInfo[2]);
                    var animalLivingRegion = animalInfo[3];
                    var animalBreed = animalInfo[4];
                    if (animalType == "Cat")
                    {
                        animal = new Cat(animalName, animalWeight, animalLivingRegion, animalBreed);
                    }
                    else if (animalType == "Tiger")
                    {
                        animal = new Tiger(animalName, animalWeight, animalLivingRegion, animalBreed);
                    }
                }
                else if (animalType == "Hen" || animalType == "Owl")
                {
                    var animalWeight = double.Parse(animalInfo[2]);
                    var animalWingSize = double.Parse(animalInfo[3]);
                    if (animalType == "Hen")
                    {
                        animal = new Hen(animalName, animalWeight, animalWingSize);
                    }
                    else if (animalType == "Owl")
                    {
                        animal = new Owl(animalName, animalWeight, animalWingSize);
                    }
                }
                else if (animalType == "Mouse" || animalType == "Dog")
                {
                    var animalWeight = double.Parse(animalInfo[2]);
                    var animalLivingRegion = animalInfo[3];
                    if (animalType == "Mouse")
                    {
                        animal = new Mouse(animalName, animalWeight, animalLivingRegion);
                    }
                    else if (animalType == "Dog")
                    {
                        animal = new Dog(animalName, animalWeight, animalLivingRegion);
                    }
                }
                Console.WriteLine(animal.ProduceSound());
                animals.Add(animal);

                var foodInfo = Console.ReadLine().Split();
                var foodType = foodInfo[0];
                var foodQuantity = int.Parse(foodInfo[1]);
                IFood food = null;
                if (foodType == "Vegetable")
                {
                    food = new Vegetable(foodQuantity);
                }
                else if (foodType == "Fruit")
                {
                    food = new Fruit(foodQuantity);
                }
                else if (foodType == "Meat")
                {
                    food = new Meat(foodQuantity);
                }
                else if (foodType == "Seeds")
                {
                    food = new Seeds(foodQuantity);
                }
                animal.Eat(food);
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
