﻿//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 123 % 10 -> 3 
// 123 % 100 -> 23 
// 123 % 1000 -> 123 

// 123 / 10 -> 12 
// 123 / 100 -> 1 
// 123 / 1000 -> 0    
    
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());
    if (number % 7 == 0 && number % 23 == 0) {
        Console.WriteLine($"Введенное число {number} кратно одновременно 7 и 23");
    } else {
        Console.WriteLine($"Введенное число {number} не кратно одновременно 7 и 23");
    }