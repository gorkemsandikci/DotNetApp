using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp
{
    public class AdvancedCollections
    {
        public static void RunExamples()
        {
            //List<T> Example
            List<string> cities = new List<string> { "Ankara", "Istanbul", "İzmir" };
            cities.Add("Bursa");
            cities.Remove("İzmir");
            Console.WriteLine("Cities List: ");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //Dictionary<TKey, TValue> Example
            Dictionary<string, int> cityPlates = new Dictionary<string, int>
            {
                {"Ankara", 06},
                {"Istanbul", 34},
                {"İzmir", 35}
            };

            Console.WriteLine("\nCity Plate Numbers:");
            foreach (var kvp in cityPlates)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            //HashSet<T> Example
            HashSet<int> uniqueNumbers = new HashSet<int> { 1, 2, 3, 4, 5 };
            uniqueNumbers.Add(6);
            uniqueNumbers.Add(1); //Numbers in HashSet are always unique
            Console.WriteLine("\nUnique Numbers: ");
            foreach (var num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }
        }
        public static void LinqExamples()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //LINQ Query: Filtering even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Even Numbers: ");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            //LINQ Query: Picking top 3 numbers

            var topThree = numbers.OrderByDescending(n => n).Take(3);

            Console.WriteLine("\nTop 3 Numbers: ");
            foreach (var number in topThree)
            {
                Console.WriteLine(number);
            }
        }
    }

    public class OOPFundamentals
    {
        //Class & Objects
        public static void DisplayCar()
        {
            ICar myCar = new ICar();
            myCar.Brand = "Mazda";
            myCar.Model = "3";
            myCar.Year = 2014;

            myCar.DisplayInfo();
        }

        class ICar
        {
            public string Brand;
            public string Model;
            public int Year;

            public void DisplayInfo()
            {
                Console.WriteLine($"Car: {Brand} {Model} - {Year}");
            }
        }

        //Inheritance

        class Vehicle
        {
            public string Make;
            public string Model;
        }

        class Car : Vehicle
        {
            public int Doors;
            public void DisplayCarInfo()
            {
                Console.WriteLine($"{Make} {Model}, {Doors} doors");
            }
        }

        //Polymorphism
        class PolyVehicle
        {
            public virtual void Drive()
            {
                Console.WriteLine("Driving a vehicle...");
            }
        }

        class PolyCar : PolyVehicle
        {
            public override void Drive()
            {
                Console.WriteLine("Driving a car...");
            }
        }
    }

    //Encapsulation
    public class BankAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }


}