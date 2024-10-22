using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysListsCollections.units();
            displayUserInfo("Gorkem", 30, 1.75, true);

            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            checkNumber(a);
            Console.WriteLine($"0-...-{a} Sum : {calculateSum(a)}");

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            checkNumber(b);
            Console.WriteLine($"0-...-{b} Sum : {calculateSum(b)}");

            Console.WriteLine($"Sum: {Add(a, b)}");
            Console.WriteLine($"Is first number greater than second number?: {isGreater(a, b)}");

        }

        public static string plateNumber(bool choice)
        {
            string plate_number = "";

            if (choice)
            {
                plate_number = "06FY4077";
            }
            return plate_number;
        }

        public static void displayUserInfo(string name, int age, double height, bool isPlateOwner)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Plate: {plateNumber(isPlateOwner)}");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static bool isGreater(int x, int y)
        {
            return x > y;
        }

        public static void checkNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        public static int calculateSum(int n)
        {
            int sum = 0;

            for (int i = 0; i <= n; i = i + 1)
            {
                sum = sum + i;
            }

            return sum;
        }
    }
}