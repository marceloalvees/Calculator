using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Welcome Calculator");

Console.WriteLine("Welcome to the Math Operations Console!");
Console.WriteLine("Choose an operation:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Exponentiation");
Console.WriteLine("6. Square Root");
var operation = int.Parse(Console.ReadLine());


Console.WriteLine("FIRST VALUE:");
var firstValue = int.Parse(Console.ReadLine());

Console.WriteLine("Second value:");
var secondValue = int.Parse(Console.ReadLine());

switch (operation)
{
    case 1:
        Console.WriteLine($"Result of {firstValue} + {secondValue} is {firstValue + secondValue}");
        break;
    case 2:
        Console.WriteLine($"Result of {firstValue} - {secondValue} is {firstValue - secondValue}");
        break;
    case 3:
        Console.WriteLine($"Result of {firstValue} * {secondValue} is {firstValue * secondValue}");
        break;
    case 4:
        Console.WriteLine($"Result of {firstValue} / {secondValue} is {firstValue / secondValue}");
        break;
    case 5:
        Console.WriteLine($"Result of {firstValue} ^ {secondValue} is {Math.Pow(firstValue, secondValue)}");
        break;
    case 6:
        Console.WriteLine($"Square root of {firstValue} is {Math.Sqrt(secondValue)}");
        break;

    default:
        Console.WriteLine("Invalid choice.Please choose a valid operation.");
        break;
}

