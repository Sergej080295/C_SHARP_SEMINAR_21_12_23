//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.  
    
    Console.WriteLine("Введите координату <X>:");
    int number_x = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату <Y>:");
    int number_y = int.Parse(Console.ReadLine());

    if (number_x == 0 ^ number_y == 0)
    {
        Console.WriteLine("Среди введенных значений есть нулевое!");
    }
    else if (number_x > 0 && number_y > 0)
    {
        Console.WriteLine("Точка находится в 1 четверти");
    }
        else if (number_x < 0 && number_y > 0)
    {
        Console.WriteLine("Точка находится во 2 четверти");
    }
        else if (number_x < 0 && number_y < 0)
    {
        Console.WriteLine("Точка находится в 3 четверти");
    }
        else if (number_x > 0 && number_y < 0)
    {
        Console.WriteLine("Точка находится в 4 четверти");
    }