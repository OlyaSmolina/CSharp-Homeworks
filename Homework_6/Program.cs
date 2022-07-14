// // Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int DigitsN(int number)
// {
//     int count = 0;
//     int result = 0;
//     while (count < number)
//     {
//         Console.Write("Input one number: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         if (n > 0) result++;
//         count++;
//     }
//     return result;
// }

// Console.WriteLine("Input the number of digits you want to enter: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"You enter {DigitsN(N)} numbers greater then zero");

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. 
// Значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Input number b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Two lines intersect at a poin with coordinates X: {x}, Y: {y}");