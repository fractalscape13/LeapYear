using System;
using Calendar;

public class Program
{
  static void Main()
  {
    Console.Clear();
    Console.WriteLine("Please enter a year to check if it is a leap year");
    int inputYear = int.Parse(Console.ReadLine());
    LeapYear inputLeapYear = new LeapYear();
    bool result = inputLeapYear.IsLeapYear(inputYear);
    if (result)
    {
      Console.WriteLine("Yes, " + inputYear + " is a leap year!");
    }
    else
    {
      Console.WriteLine("No, " + inputYear + " is not a leap year.");
    }
  }
}