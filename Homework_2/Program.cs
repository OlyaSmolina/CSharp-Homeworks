// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int ShowSecondDigit()

{
    Console.WriteLine($"Input your three-digit number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int dec = n % 100;
    int ed = n % 10;
    int number = (dec - ed)/10;
    return number;
}

int result = ShowSecondDigit();
Console.WriteLine($"The second digit of your number is {result}");
*/

// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/* 
int ShowThirdDigit (int number)
{ 
    while (number > 999)
    {
        number = number / 10;
    }
        int result = number % 10;
        return result;
}

Console.WriteLine($"Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100) 
{
    Console.WriteLine($"The third digit is not exist");
    return;
}

int digit = ShowThirdDigit(number);
Console.WriteLine($"The third digit of your numer is {digit} ");
*/

// Программа, которая принимает на вход цифру дня недели и проверяет, является ли этот день выходным.

bool DayOff (int n)
{
    if (n == 6) return true;
    if (n == 7) return true;
    else return false;
}
Console.WriteLine($"Input your number from 1 to 7: ");
int n = Convert.ToInt32(Console.ReadLine());

bool result = DayOff (n);
if(result == true)
Console.WriteLine($"Today is the day off!");
else
Console.WriteLine($"Today is the working day. Try again tomorrow! ;)");
