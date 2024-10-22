using System;
using System.Collections.Generic;

namespace MyApp
{
    public class ArraysListsCollections
    {
        public static void units()
        {
            //Array Unit
            int[] numbers = { 1, 2, 3, 4, 5 };
            int totalSum = CalculateArraySum(numbers);

            Console.WriteLine($"The sum of the array is: {totalSum}");

            //List Unit
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            DisplayNames(names);

            //Dictionary Unit
            Dictionary<string, int> studentGrades = new Dictionary<string, int>{
                {"Alice", 60},
                {"Bob", 70},
                {"Charlie", 79}
            };


            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name)) // Boş giriş kontrolü
            {
                int grade = GetStudentGrade(studentGrades, name);
                if (grade != -1)
                {
                    Console.WriteLine($"{name}'s grade: {grade}");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid student name.");
            }

            //Matrix Unit

            int[,] matrix = {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            PrintMatrix(matrix);

            //Queue & Stack Unit

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Task 1");
            queue.Enqueue("Task 2");
            queue.Enqueue("Task 3");

            Console.WriteLine("Queue:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        }

        public static int CalculateArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static void DisplayNames(List<string> nameList)
        {
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
        }

        public static int GetStudentGrade(Dictionary<string, int> grades, string studentName)
        {
            if (grades.TryGetValue(studentName, out int grade))
            {
                return grade;
            }
            else
            {
                Console.WriteLine("Student not found.");
                return -1;
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
