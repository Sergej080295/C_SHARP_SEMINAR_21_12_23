int[] array = new int[10] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int sum = 0;
int i = 0;
for (i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        sum = sum + 1;
    }
}
Console.WriteLine(sum);


//То, что закинул в автотест:
//using System;
//using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
//class UserInputToCompileForTest
//{
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
//    public static int CountEvenItems(int[] numbers)
//    {
//        int count = 0;
//        int i = 0;
//        for (i = 0; i < numbers.Length; i++)
//        {
//            if (numbers[i] % 2 == 0)
//            {
//                count = count + 1;
//            }
//        }
//        return count;
//    }

//    public static void PrintResult(int[] array)
//    {
//      int count = CountEvenItems(array);
//      Console.WriteLine(count);
//    }
//}