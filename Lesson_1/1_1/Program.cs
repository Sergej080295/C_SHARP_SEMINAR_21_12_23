// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

Console.Write("Enter a number 1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter a number 2: ");
int b2 = int.Parse(Console.ReadLine()!);

if (b2 * b2 == b1) 
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

