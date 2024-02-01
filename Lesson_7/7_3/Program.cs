/*
Задание 3. Считать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
*/

void PrintConsonants(string str, int index = 0)
{
    if (index == str.Length)
        return;

    char ch = str[index];
    if (char.IsLetter(ch) && "aeiouAEIOU".IndexOf(ch) == -1)
        Console.Write(ch + " ");

    PrintConsonants(str, index + 1);
}

Console.WriteLine("Введите строку:");
string input = Console.ReadLine();
Console.WriteLine("Согласные буквы в строке:");
PrintConsonants(input);