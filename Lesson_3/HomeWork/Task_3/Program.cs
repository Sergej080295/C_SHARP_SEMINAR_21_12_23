double[] array = new double[7] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
double maxValue = array.Max();
double minValue = array.Min();

double difference = maxValue - minValue;

Console.WriteLine(difference);


// Это добавил в автотест:
// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Разница между максимальным и минимальным элементами массива
    
//     // Нахождение минимума массива
//     public static double FindMin(double[] numbers)
//     {
//         double minValue = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (numbers[i] < minValue)
//             {
//                 minValue = numbers[i];
//             }
//         }
//         return minValue;
//     }
    
//     // Нахождение максимума массива
//     public static double FindMax(double[] numbers)
//     {
//         double maxValue = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (numbers[i] > maxValue)
//             {
//                 maxValue = numbers[i];
//             }
//         }
//         return maxValue;
//     }
    
    
    
//     public static void PrintResult(double[] array)
//     {
//         double maxValue = FindMax(array);
//         double minValue = FindMin(array);
//         double difference = maxValue - minValue;
//         Console.WriteLine(difference);
//     }
// }