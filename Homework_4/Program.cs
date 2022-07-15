// Программа, которая принимает на вход число и выдаёт сумму цифр в числе

// int FindSum(int n)
// {
//     int sum = 0;
//     int current = Convert.ToString(n).Length;
  
//     for (int a = 0; a < current; a++)
//     {
//         sum = sum + (n - (n - (n % 10)));
//         n = n / 10;
//     }
//     return sum;
// }

// Console.Write("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Sum of numbers is " + FindSum(num));

// Программа, которая задаёт массив из 8 чисел и выводит их на экран

void FillRandomArray(int[] numbers)
{
    int size = numbers.Length;
    for (int index = 0; index < size; index++)
    numbers[index] = new Random().Next(1, 8);  
}

void ShowRandomArray(int[] num)
{
    int length = num.Length;
    for (int i = 0; i < length; i++)
    System.Console.Write(num[i] + " ");
}
int[] array = new int [8];

FillRandomArray(array);
ShowRandomArray(array);

