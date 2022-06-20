// Программа, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.

int num1, num2;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}

if(num1 < num2)
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}

else
{
   Console.WriteLine("Оба числа равны"); 
}
