/* Задание 1. Совместная работа 
Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
*/

int sum(int numbers)
{
    if(numbers == 0)
        return 0;
    return numbers % 10 + sum(numbers / 10);
}
Console.WriteLine("Напишите число");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр числа: " + sum(num_1));