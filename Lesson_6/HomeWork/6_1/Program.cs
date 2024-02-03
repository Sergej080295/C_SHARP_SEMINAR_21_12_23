/*Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.*/

char[,] charArray = { { 'H', 'e', 'l' }, { 'l', 'o', '!' } };
string str = "";
for (int i = 0; i < charArray.GetLength(0); i++)
{
    for (int j = 0; j < charArray.GetLength(1); j++)
    {
        str += charArray[i, j];
    }
}
Console.WriteLine(str);