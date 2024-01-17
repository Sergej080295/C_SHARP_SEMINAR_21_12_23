// 2. Задайте массив из N случайных целых
//    чисел (N вводится с клавиатуры).
//    Найдите количество чисел, которые
//    оканчиваются на 1 и делятся нацело на 7.

using System;

namespace My_4_2
{
    class Program
    {
        static void Main()
        {
            // ... (остальной код)

            int num_1(double[] arr)
            {
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 10 == 1 && arr[i] % 7 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            // Запрос количества чисел и границ диапазона
            int num = int.Parse(Console.ReadLine()!);
            int start = int.Parse(Console.ReadLine()!);
            int stop = int.Parse(Console.ReadLine()!);

            // Генерация массива случайных чисел
            double[] mass = GenerateRandomArray(num, start, stop);
            Print(mass);

            // Подсчёт чисел, оканчивающихся на 1 и делящихся нацело на 7
            int result = num_1(mass);
            System.Console.WriteLine(result);
        }

        // Функция для генерации массива случайных чисел
        static double[] GenerateRandomArray(int size, int from, int to)
        {
            double[] arr = new double[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(from, to + 1);
            }
            return arr;
        }

        // Функция для вывода массива
        static void Print(double[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
