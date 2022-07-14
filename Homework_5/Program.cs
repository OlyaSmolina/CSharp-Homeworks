// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве. 

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(100, 1000);
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
// }
// int EvenDigits(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     if (array[i] % 2 == 0)
//     count++;
//     return count;
// }
// int[] numbers = new int[4];

// FillArray(numbers);
// PrintArray(numbers);
// Console.WriteLine();

// int result = EvenDigits(numbers);
// Console.WriteLine($"Tne number of even digits in the array is: {result}");

// Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int RandomNDigits(int numberOfElements, int min, int max)
// {
//   int[] randomDigits = new int[numberOfElements];
//   int sumElements = 0;
//   Console.Write("The array of random numbers is: ");

//   for (int i = 0; i <randomDigits.Length; i++ )
//   {
//     randomDigits[i] = new Random().Next(min, max);
//     Console.Write(randomDigits[i] + " ");
//     if (i % 2 != 1)
//     sumElements = sumElements + randomDigits[i];
//   }
//   return sumElements;
// }

// Console.Write($"Input the number of array's elements: ");
// int numOfElements = Convert.ToInt32(Console.ReadLine()); 

// int randomNumbers =  RandomNDigits(numOfElements, 1, 10);
// Console.WriteLine($"Sum of elements in odd positions is: {randomNumbers}");

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double[] RealDigitArray = new double[4];
  
  for (int i = 0; i < RealDigitArray.Length; i++)
  {
    RealDigitArray[i] = new Random().Next(10, 100);
    Console.Write(RealDigitArray[i] + " ");
  }

double maxNumber = RealDigitArray[0];
double minNumber = RealDigitArray[0];

  for (int i = 1; i < RealDigitArray.Length; i++)
  {
    if (maxNumber < RealDigitArray[i])
    maxNumber = RealDigitArray[i];
    
    if (minNumber > RealDigitArray[i])
    minNumber = RealDigitArray[i];
  }

  double result = maxNumber - minNumber;

  Console.WriteLine($"Difference between maximum ({maxNumber}) and minimum ({minNumber}) array elements is: {result}");
