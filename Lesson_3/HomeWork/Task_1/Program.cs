int[] array = new int[10] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
int sum = 0;
int i = 0;
for (i = 0; i < array.Length; i++)
{
    if(array[i] >= 10 && array[i] <= 90)
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
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
//    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//   {
//        int sum = 0;
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            if (numbers[i] >= minRange && numbers[i] <= maxRange)
//            {
//                sum = sum + 1;
//            }
//        }
//        return sum;
//    }
//    
//    public static void PrintResult(int[] array)
//    {
//      int count = CountItemsRange(array, 10, 90);
//      Console.WriteLine(count);
//    }
//
//}