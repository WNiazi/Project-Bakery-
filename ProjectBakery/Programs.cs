using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      HelloMessage();
      MainMenu();
      // TotalPrice();
    }
    public static void HelloMessage()
    {
      Console.WriteLine("Welcome to Pierre Bakery");
      Console.WriteLine("We have Bread and Pastries");
      Console.WriteLine("Current specials are: 3 for 1 on Bread Loaves and Pastries 1 for $2 and 3 for $5");
      MainMenu();
    }
    public static bool MainMenu()
    {
      Console.Clear();
      Console.WriteLine("Choose an option by picking [1 or 2 or 3 or 4]:");
      Console.WriteLine("1) Buy Bread");
      Console.WriteLine("2) Buy Pasteries");
      Console.WriteLine("3) Buy Both");
      Console.WriteLine("4) Exit");
      Console.Write("\r\nSelect an option: ");
      switch (Console.ReadLine())
      {
        case "1":
          GettingBreadOrder();
          return true;
        case "2":
          GettingPasteryOrder();
          return true;
        case "3":
          GettingBothPasteryBreadOrder();
          return true;
        case "4":
          HelloMessage();
          return false;
        default:
          return true;
      }
    }
    public static int GettingBreadOrder()
    {
      Console.WriteLine("How many loaves would you like? [1-10]");
      string stringInputtedBreadAmount = Console.ReadLine();
      int intInputtedBreadAmount = int.Parse(stringInputtedBreadAmount);
      // Bread InputtedBread = new Bread(intInputtedBreadAmount, 5);
      // InputtedBread.CalculateTotalBread(intInputtedBreadAmount);
      return intInputtedBreadAmount;
    }
    public static int GettingPasteryOrder()
    {
      Console.WriteLine("How many pasteries would you like?"[1 - 10]);
      string stringInputtedPastriesAmount = Console.ReadLine();
      int intInputtedPastriesAmount = int.Parse(stringInputtedPastriesAmount);
      // Pasteries InputtedPastry = new Pasteries(intInputtedPastriesAmount, 2);
      // InputtedPastry.CalculateTotalPastries(intInputtedPastriesAmount);
      return intInputtedPastriesAmount;
    }
    public static void GettingBothPasteryBreadOrder()
    {
      Program.GettingPasteryOrder();
      Program.GettingBreadOrder();
      // Pasteries InputtedPastry =new Pasteries (intInputtedPastriesAmount, 2); 
      // // Bread InputtedBread = new Bread (intInputtedBreadAmount); 
      // // Console.WriteLine($"Your total {InputtedBread.intInputtedBreadAmount} 
    }
  }
}