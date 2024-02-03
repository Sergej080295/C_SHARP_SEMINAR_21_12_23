/*Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова 
расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.*/


Console.WriteLine("Введите строку, состоящую из слов, разделенных пробелами:");
string originalText = Console.ReadLine()?.Trim();
if (string.IsNullOrEmpty(originalText))
{
    Console.WriteLine("Вы не ввели ничего!");
}
else
{
    string[] words = originalText.Split(' ');
    Array.Reverse(words);
    string reversedString = string.Join(" ", words);
    Console.WriteLine(reversedString);
}