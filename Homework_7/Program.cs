//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray(int m, int n, int minValue, int maxValue)
{
    double[,] newArray= new double[m,n];

    for(int i = 0; i < m ; i++)
        for( int j = 0; j < n; j++)
            newArray[i,j] = Math.Round(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble(), 1);
    
    return newArray;
}

void Show2dArray(double[,] newArray)
{
     for(int i = 0;  i < newArray.GetLength(0); i++)
        {
        for(int j = 0; j < newArray.GetLength(1); j++)
            Console.Write(newArray[i,j] + " ");
        Console.WriteLine();
        }
}
Console.WriteLine("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, -10, 10);
Show2dArray(myArray);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray(int[,] newArray)
// {
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//             newArray[i, j] = new Random().Next(1, 10);
//     }
//     return newArray; 
// } 

// void Show2dArray(int[,] newArray)
// {
//      for(int i = 0; i < newArray.GetLength(0); i++)
//         {
//         for(int j = 0; j < newArray.GetLength(1); j++)
//             Console.Write(newArray[i,j] + "   ");
//         Console.WriteLine();
//         }
// }

// void FindElement(int[,] newArray)
// {
//     Console.WriteLine("Input first number: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Input second number: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     if (m >= newArray.GetLength(0) || n >= newArray.GetLength(1)) 
//         Console.WriteLine("Element is not found");
//     else Console.WriteLine($"The number of elements is " + newArray[m, n]);
// }

// int[,] newArray = new int[5, 5];

// CreateRandom2dArray(newArray);
// Show2dArray(newArray);
// FindElement(newArray);

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// void CreateRandom2dArray(int[,] newArray)
// {
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//              newArray[i, j] = new Random().Next(1, 10);
//     }
// }
// void Show2dArray(int[,] newArray)
// {
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//             Console.Write($"{newArray[i, j]} ");

//         Console.WriteLine();
//     }
// }

// void FindAverageNumber(int[,] newArray)
// {
//     for (int j = 0; j < newArray.GetLength(1); j++)
//     {
//         double result = 0;
//         for (int i = 0; i < newArray.GetLength(0); i++) result += newArray[i, j];
//         Console.WriteLine($"The averege number of {j + 1} column is: {result / newArray.GetLength(0)}");
//     }
// }

// int[,] newArray = new int[5, 5];

// CreateRandom2dArray(newArray);
// Show2dArray(newArray);
// FindAverageNumber(newArray);
