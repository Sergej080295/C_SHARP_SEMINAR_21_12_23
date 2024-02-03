/*Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.*/

Console.WriteLine("Введите текст с заглавными и строчными буквами:");
string originalText = Console.ReadLine()?.Trim();
if (string.IsNullOrEmpty(originalText))
{
    Console.WriteLine("Вы не ввели ничего!");
}
else
{
    string modifiedText = originalText.ToLower();
    Console.WriteLine(modifiedText);
}