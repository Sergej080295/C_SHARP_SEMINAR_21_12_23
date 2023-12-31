//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.      
    
    
Console.WriteLine("Введите натуральное число N: ");
int number_x = int.Parse(Console.ReadLine());
string number_xStr = number_x.ToString();
int index = 0;

while (index < number_xStr.Length)
{
    Console.Write(number_xStr[index]);

    if (index < number_xStr.Length - 1)
    {
        Console.Write(", ");
    }

    index++;
}