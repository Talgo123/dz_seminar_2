
void CheckingTheDayOfTheWeek (int DayNumber) 
{
  if (DayNumber == 6 || DayNumber == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (DayNumber < 1 || DayNumber > 7) 
  {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

Console.Write("Введи цифру, обозначающую день недели: ");
int DayNumber = int.Parse(Console.ReadLine());
CheckingTheDayOfTheWeek (DayNumber);
