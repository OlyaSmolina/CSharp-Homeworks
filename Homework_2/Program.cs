// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

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
