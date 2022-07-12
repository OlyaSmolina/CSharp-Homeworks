// Программа, которая принимает на вход коортинаты двух точек и находит расстояние между ними в 3D пространстве

// double GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double xLine = x2-x1;
//     double yLine = y2-y1;
//     double zLine = z2-z1;

//     double distQuard = xLine * xLine + yLine * yLine + zLine * zLine;
//     double result = Math.Sqrt(distQuard);
//     return result;
// }
// Console.WriteLine("Input x coordinates for the A point ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input у coordinates for the A point ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input z coordinates for the A point ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input x coordinates for the B point ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input у coordinates for the B point ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input z coordinates for the B point ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double res = GetDistance(x1, y1, z1, x1, y2, z2);
// Console.WriteLine($"The distance between these points is {res}");

// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Input your five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

string number = n.ToString();

void Palindrome (string number)

{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine("Yes, it's palindrome");
    }
    else Console.WriteLine("No, it's not palindrome");
}

Palindrome(number);


// bool Palindrome (int n)
// {
//     int[] array =  int[5];
//     int index = 4;
//     int count = 0;
//     while (index >= 0)
//     {
//         count = n % 10;
//         array[index] = count;
//         n = n / 10;
//         index = index - 1;
//     }
//     if (array[0] == array[4] && array[1] == array[3]) return true;
//     else return false;
// }
// Console.WriteLine("Input your five-digit number ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n < 10000 || n > 99999)
// {
//     Console.Write("It's not a five-digit number");
//     return;
// }
// bool res = Palindrome(n);
// if (res == true) Console.WriteLine("Yes, it's palindrome");
// else Console.WriteLine("No, it's not palindrome");

// Программа, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N

// void ShowKubus(int N)
// {
//     int count = 1;
//     while (count <= N)
//     {
//         int cube = count * count * count;
//         Console.Write(cube + " ");
//         count ++; 
//     }
// }

// Console.WriteLine("Input your number ");
// int number = Convert.ToInt32(Console.ReadLine());
// ShowKubus(number);
