/* 3. Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
Выяснить, сколько среди введённых букв гласных.*/

string input = Console.ReadLine().ToLower();
int vowelCount = 0;
for (int i = 0; i < input.Length; i++)
{
    if ("aeiou".Contains(input[i]))
    {
        vowelCount++;
    }
}
Console.WriteLine($"Количество гласных букв: {vowelCount}");