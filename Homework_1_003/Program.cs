// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно без остатка).

int number;
string division = "нечётное";

Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0) division = "чётное";

Console.WriteLine($"Число {number} - это {division} число"); 


