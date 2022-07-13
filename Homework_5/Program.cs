//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
}
int QuantityPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        count++;
    return count;
}
int[] numbers = new int[4];
FillArray(numbers);
PrintArray(numbers);
Console.WriteLine();

int sum = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {sum}");

//Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write($"Введи количество элементов массива: ");
int numOfElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numOfElements, int min, int max)
  {
  int[] randomNumbers = new int[numOfElements];
  int sumElements = 0;
  Console.Write("массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);
      Console.Write(randomNumbers[i] + " ");
        if (i % 2 != 1)
      sumElements = sumElements + randomNumbers[i];
    }
  return sumElements;
  }
int randomNumbers =  RandomNumbers(numOfElements, 1, 10);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] arrayNum = new double[4];
  for (int i = 0; i < arrayNum.Length; i++ )
  {
    arrayNum[i] = new Random().Next(10, 100);
    Console.Write(arrayNum[i] + " ");
  }

double maxNumber = arrayNum[0];
double minNumber = arrayNum[0];
  for (int i = 1; i < arrayNum.Length; i++)
  {
    if (maxNumber < arrayNum[i])
    maxNumber = arrayNum[i];
    
        if (minNumber > arrayNum[i])
        minNumber = arrayNum[i];
  }
  double res = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {res}");
