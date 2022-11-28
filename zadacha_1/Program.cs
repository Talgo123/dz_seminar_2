Console.WriteLine("Введите число от 100 до 999: ");
int number = int.Parse(Console.ReadLine());
int SecondDigit = number / 10 % 10;
Console.WriteLine(number + "->" + SecondDigit);
