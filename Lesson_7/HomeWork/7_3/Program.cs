/*
Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
*/


int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine("Элементы массива, начиная с конца:");
PrintArrayReverse(myArray, myArray.Length - 1);

static void PrintArrayReverse(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write($"{arr[index]} ");
        PrintArrayReverse(arr, index - 1);
    }
}