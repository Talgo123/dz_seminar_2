
void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = int.Parse(Console.ReadLine());
CheckingTheDayOfTheWeek (dayNumber);
