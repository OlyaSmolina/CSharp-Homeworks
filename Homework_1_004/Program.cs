// Программа, которая на вход принимает число (N), а на входе показывает все чётные числа от 1 до N.

int N;
int current = 1;

Console.Write("Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

while(current <= N)
{
    if (current % 2 ==0)
    {
        Console.Write(current + " "); 
        current+=2; 
    }
    else
    {
        current++;
    }
}
