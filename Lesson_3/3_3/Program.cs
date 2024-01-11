// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив. 
        
        int[] numbers = { 10, 8, 6, 4, 2, 5, 25, 1, 3, 5, 7, 9 };
        int[] res = new int[numbers.Length / 2];

        for (int i = 0; i < numbers.Length / 2; i++)
        {
            res[i] = numbers[i] * numbers[numbers.Length - 1 - i];
            Console.WriteLine("Результат: " + res[i]);
        }