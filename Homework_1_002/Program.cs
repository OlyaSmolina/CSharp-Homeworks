// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел

int a, b, c;
int max;

Console.Write("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
c = Convert.ToInt32(Console.ReadLine());

max = a;

if(a > b && a > c) 
{
    max = a;
} 

if(b > a && b > c) 
{
    max = b;
}

if(c > a && c > b) 
{
    max = c;
}

Console.WriteLine($"Максимальное число {max}"); 
