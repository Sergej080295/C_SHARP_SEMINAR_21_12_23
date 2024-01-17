/*Заполните массив на N (вводится с консоли, не более 8) 
случайных целых чисел от 0 до 9. 
Сформируйте целое число, которое будет состоять из цифр из 
массива. Старший разряд числа находится на 0-м индексе, 
младший – на последнем. */

using System;

namespace My_4_1
{
    class Program
    {
        static void Main()
        {
            // Запрос количества чисел в массиве
            Console.Write("Введите количество чисел в массиве (не более 8): ");
            int num = int.Parse(Console.ReadLine()!);

            // Проверка, что количество чисел не превышает 8
            if (num > 8)
            {
                Console.WriteLine("Количество чисел не должно превышать 8!");
                return;
            }

            // Заполнение массива случайными числами от 0 до 9
            int[] arr = new int[num];
            Random random = new Random();
            Console.Write("Сформированный массив: [ ");
            for (int i = 0; i < num; i++)
            {
                arr[i] = random.Next(0, 10);
                Console.Write(arr[i]);
                if (i < num - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ]");

            // Формирование числа из цифр массива
            int number = 0;
            for (int i = 0; i < num; i++)
            {
                number += arr[i] * (int)Math.Pow(10, num - i - 1);
            }

            // Вывод старшего и младшего разрядов числа
            int firstDigit = number / (int)Math.Pow(10, num - 1);
            int lastDigit = number % 10;
            Console.WriteLine($"Сформированное число: {number}");
            //Console.WriteLine($"Старший разряд числа: {firstDigit}");
            //Console.WriteLine($"Младший разряд числа: {lastDigit}");
        }
    }
}
