// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// 2. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.


        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int startNumber = -N;
        int endNumber = N;
        int currentNumber = startNumber;

        while (currentNumber <= endNumber)
        {
            Console.Write(currentNumber + " ");
            currentNumber++;
        }