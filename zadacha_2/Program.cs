int number = new Random().Next(1,99999);
Console.WriteLine($"ввели число {number}");
int ThirdDigit = 0;
if (number >= 100  & number < 999)
{
    ThirdDigit = number % 10;
    Console.WriteLine(number+ "->" + ThirdDigit);
}
if (number < 100)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
if (number >= 1000 & number < 9999 )
{
    ThirdDigit = number /10 % 10;
    Console.WriteLine(number+ "->" + ThirdDigit);
}
if (number >= 10000 & number < 99999 )
{
    ThirdDigit = number /100 % 10;
    Console.WriteLine(number+ "->" + ThirdDigit);
}