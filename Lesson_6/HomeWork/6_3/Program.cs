/*Задайте произвольную строку. Выясните, является ли она палиндромом*/

Console.WriteLine("Введите палиндром:");
string palindrome = Console.ReadLine()?.ToLower().Trim();
if (string.IsNullOrEmpty(palindrome))
{
    Console.WriteLine("Вы не ввели ничего!");
}
else
{
    bool isPalindrome = true;
    for (int i = 0, j = palindrome.Length - 1; i < j; i++, j--)
    {
        if (palindrome[i] != palindrome[j])
        {
            isPalindrome = false;
            break;
        }
    }
    if (isPalindrome)
    {
        Console.WriteLine("Входные данные являются палиндромом!");
    }
    else
    {
        Console.WriteLine("Входные данные не является палиндромом!");
    }
}