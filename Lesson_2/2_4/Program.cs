// 4. Напишите программу, которая выводит третью с конца
//    цифру заданного числа или сообщает, что третьей цифры нет.

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    int num1 = (number / 100) % 10;

    if (num1 != 0)
    {
        Console.WriteLine($"Третья цифра с конца: {num1}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }