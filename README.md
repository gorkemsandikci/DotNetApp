# MyApp - C# Fundamentals

This project is designed to help you learn and practice the basic features of the C# language. It includes arrays, lists, dictionaries, queues, and other fundamental data structures and functions. Additionally, it provides simple mathematical functions and user info input processing.

## Contents

1. **Program.cs** - The main program file.
2. **ArraysListsCollections.cs** - A helper class that contains operations related to arrays, lists, dictionaries, and other collections.

## Running the Project

To run the project on your local machine, follow these steps.

### 1. Requirements

- .NET Core SDK (version 3.1 or higher)
- An IDE (such as Visual Studio, Visual Studio Code)

### 2. Setup

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/your-username/MyApp.git
   ```

2. Navigate to the project directory:

   ```bash
   cd MyApp
   ```

3. Build and run the project using the following command:

   ```bash
   dotnet run
   ```

### 3. Functions Used

**Program.cs**

- `plateNumber(bool choice)`: Returns a car plate number based on the input choice.
- `displayUserInfo(string name, int age, double height, bool isPlateOwner)`: Displays user information on the console.
- `Add(int x, int y)`: Returns the sum of two numbers.
- `isGreater(int x, int y)`: Returns whether the first number is greater than the second.
- `checkNumber(int number)`: Checks if a number is positive, negative, or zero.
- `calculateSum(int n)`: Returns the sum of numbers from 0 to n.

**ArraysListsCollections.cs**

- `CalculateArraySum(int[] arr)`: Returns the sum of numbers in an array.
- `DisplayNames(List<string> nameList)`: Displays the names in a list on the console.
- `GetStudentGrade(Dictionary<string, int> grades, string studentName)`: Returns the grade of a student.
- `PrintMatrix(int[,] matrix)`: Prints the elements of a 2D matrix.

### 4. Example Usage

**ArraysListsCollections.units()**

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
int totalSum = CalculateArraySum(numbers);

Console.WriteLine($"The sum of the array is: {totalSum}");

List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
DisplayNames(names);

Dictionary<string, int> studentGrades = new Dictionary<string, int> {
    { "Alice", 60 },
    { "Bob", 70 },
    { "Charlie", 79 }
};
Console.Write("Enter student name: ");
string name = Console.ReadLine();
int grade = GetStudentGrade(studentGrades, name);
Console.WriteLine($"{name}'s grade: {grade}");
```

### 5. Contributing

If you want to contribute to this project, feel free to submit a pull request or report any issues you encounter.

---

**Author**: [Gorkem Sandikci](https://github.com/gorkemsandikci)
