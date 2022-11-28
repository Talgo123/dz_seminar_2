// int number = new Random().Next(1,99999);
// Console.WriteLine($"ввели число {number}");
// int ThirdDigit = 0;    
// if (number >= 100  & number < 999)
// {
//     ThirdDigit = number % 10;
//     Console.WriteLine(number+ "->" + ThirdDigit);
// }
// if (number < 100)
// {
//     Console.WriteLine($"{number} -> третьей цифры нет");
// }
// if (number >= 1000 & number < 9999 )
// {
//     ThirdDigit = number /10 % 10;
//     Console.WriteLine(number+ "->" + ThirdDigit);
// }
// if (number >= 10000 & number < 99999 )
// {
//     ThirdDigit = number /100 % 10;
//     Console.WriteLine(number+ "->" + ThirdDigit);
// }

// Альтернативное решение


int number = new Random().Next(1,99999);
Console.WriteLine($"ввели число {number}");
if (number < 100)
{
    Console.WriteLine(number + " не трехзначное число (третьей цифры нет)");
    return;
}
string TextNumbers = number.ToString();  //перевели  цифру в строку
if (TextNumbers.Length > 3)  
{
     TextNumbers = TextNumbers.Substring(0, TextNumbers.Length - (TextNumbers.Length - 3)); //оставили только 3 первые цифры в строке
}
Console.WriteLine(TextNumbers[2]); // Показываем третью цифру под индексом 2