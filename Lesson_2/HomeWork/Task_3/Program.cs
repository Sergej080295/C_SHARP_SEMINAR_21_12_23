//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 123 % 10 -> 3 
// 123 % 100 -> 23 
// 123 % 1000 -> 123 

// 123 / 10 -> 12 
// 123 / 100 -> 1 
// 123 / 1000 -> 0        
    
    
    Console.WriteLine("Введите целое число, лежащее на отрезке [10, 99]: ");
    int number_x = int.Parse(Console.ReadLine());
    int a = number_x % 10;
    int b = number_x / 10;

    if (number_x < 10 ^ number_x > 99)
    {
        Console.WriteLine($"Введенное число {number_x} не лежит на отрезке [10, 99]");
    }
    else if (a >= b)
    {
        Console.WriteLine($"Наибольшая цифра числа {number_x} равна: {a}");
    }
    else if (a < b)
    {
        Console.WriteLine($"Наибольшая цифра числа {number_x} равна: {b}");
    }