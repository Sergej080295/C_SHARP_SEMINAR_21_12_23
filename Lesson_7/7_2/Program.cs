/*
Задание 2. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

void PrintNumbers(int n, int current = 1)
{
    if (current > n)
        return;
    Console.Write(current + " ");
    PrintNumbers(n, current + 1);
}

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Натуральные числа от 1 до " + n + ":");
PrintNumbers(n);