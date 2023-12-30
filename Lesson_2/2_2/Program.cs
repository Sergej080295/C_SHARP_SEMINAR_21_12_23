﻿// 2. Напишите программу, которая принимает на вход трёхзначное
//    число и возводит вторую цифру этого числа в степень, равную
//    третьей цифре.

// 123 % 10 -> 3 
// 123 % 100 -> 23 
// 123 % 1000 -> 123 

// 123 / 10 -> 12 
// 123 / 100 -> 1 
// 123 / 1000 -> 0

int n = int.Parse(Console.ReadLine()!);
int n3 = n % 10;
int n2 = n / 10 % 10;
Console.WriteLine(Math.Pow(n2, n3));