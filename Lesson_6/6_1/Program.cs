// 1. Задайте массив символов (тип char []).
//    Создайте строку из символов этого массива.
//    Конструктор строки вида string(char []) не использовать.

char[] charArray = { 'H', 'e', 'l', 'l', 'o' };
string str = "";
foreach (char i in charArray)
{
    str += i;
}
Console.WriteLine(str);