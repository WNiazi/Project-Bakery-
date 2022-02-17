using System;
using Bakery.Models;

// namespace Bakery
// {
//   public class Program
//   {
//     public static void Main()
//     {
//       Console.Clear();
//       Console.WriteLine("Welcome to Pierre Bakery!");
//       Console.WriteLine("We have Bread and Pastries.");
//       Console.WriteLine("Current specials are: 3 for 1 on Bread Loaves!");
//       Console.WriteLine("Pastries 1 for $2 and 3 for $5.");
//       Console.WriteLine("How many loaves would you like? [1-6]");
//       string stringTemp = Console.ReadLine();
//       int inputtedBreadAmount = 0;
//       Int32.TryParse(stringTemp, out inputtedBreadAmount);
//       Console.WriteLine("How many pastries would you like? [1 - 6]");
//       string stringTempP = Console.ReadLine();
//       int inputtedPastriesAmount = 0;
//       Int32.TryParse(stringTempP, out inputtedPastriesAmount);

//       Bread breadTotal = new Bread(inputtedBreadAmount);

//       Pastries pastryTotal = new Pastries(inputtedPastriesAmount);

//       int total = (pastryTotal.CalculateTotalPastries() + breadTotal.CalculateTotalBread());

//       Console.WriteLine("Your total cost is " + "$" + (total) + ".");
//       Console.WriteLine("You bought " + (inputtedBreadAmount) + " loaves of bread. For a total of " + "$" + (breadTotal.CalculateTotalBread()) + ".");
//       Console.WriteLine("You bought " + (inputtedPastriesAmount) + " sweet(s). For a total of " + "$" + (pastryTotal.CalculateTotalPastries()) + ".");
//     }
//   }
// }





namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Choose an option by picking [1 or 2 or 3 or 4]:");
      Console.WriteLine("(1) Buy Bread.");
      Console.WriteLine("(2) Buy Pasteries.");
      Console.WriteLine("(3) Buy Both.");
      Console.WriteLine("(4) Exit.");
      Console.Write("\r\nSelect an option: ");
      string temp = Console.ReadLine();
      int menu = int.Parse(temp);

      switch (menu)
      {
        case 1:
          GetBreadOrder();
          break;
        case 2:
          GetPastryOrder();
          break;
        case 3:
          GetBoth();
          break;
        case 4:
          Console.WriteLine("Another time!");
          Main();
          break;
      }

      static void GetBreadOrder()
      {
        Console.WriteLine("How many loaves would you like? [1-6]");
        string stringTemp = Console.ReadLine();
        int inputtedBreadAmount = 0;
        Int32.TryParse(stringTemp, out inputtedBreadAmount);
        if (inputtedBreadAmount < 1 || inputtedBreadAmount > 6)
        {
          Console.WriteLine("Please input number from 1-6");
          Main();
        }

        else
        {
          Bread breadTotal = new Bread(inputtedBreadAmount);
          Console.WriteLine($"Your ordered {breadTotal.AmountBread} loaves");
          Console.WriteLine($"Your total is ${breadTotal.CalculateTotalBread()}");
        }

      }

      static void GetPastryOrder()
      {
        Console.WriteLine("How many pastries would you like? [1 - 10]");
        string stringTempP = Console.ReadLine();
        int inputtedPastriesAmount = 0;
        Int32.TryParse(stringTempP, out inputtedPastriesAmount);
        if (inputtedPastriesAmount < 1 || inputtedPastriesAmount > 10)
        {
          Console.WriteLine("That is too much or not enough! Try Again");
          Main();
        }
        else
        {
          Pastries pastryTotal = new Pastries(inputtedPastriesAmount);
          Console.WriteLine($"You have {pastryTotal.AmountPastries} in your cart.");
          Console.WriteLine($"Your total is ${pastryTotal.CalculateTotalPastries()}");
        }

      }


      static void GetBoth()
      {
        Console.WriteLine("How many loaves would you like? [1-6]");
        string stringTemp = Console.ReadLine();
        int inputtedBreadAmount = 0;
        Int32.TryParse(stringTemp, out inputtedBreadAmount);

        Console.WriteLine("How many pastries would you like? [1 - 10]");
        string stringTempP = Console.ReadLine();
        int inputtedPastriesAmount = 0;
        Int32.TryParse(stringTempP, out inputtedPastriesAmount);
        if (inputtedPastriesAmount < 1 || inputtedPastriesAmount > 10 || inputtedBreadAmount < 1 || inputtedBreadAmount > 6)
        {
          Console.WriteLine("Oops I think you meant something else");
          Main();
        }
        else
        {
          Bread breadTotal = new Bread(inputtedBreadAmount);
          Pastries pastryTotal = new Pastries(inputtedPastriesAmount);
          int total = (pastryTotal.CalculateTotalPastries() + breadTotal.CalculateTotalBread());
          Console.WriteLine($"Your ordered {breadTotal.AmountBread} loave(s).");
          Console.WriteLine($"Your total for the bread is ${breadTotal.CalculateTotalBread()}");
          Console.WriteLine($"You have {pastryTotal.AmountPastries} pastry/pastries in your cart.");
          Console.WriteLine($"Your total for the pastry/pastries is ${pastryTotal.CalculateTotalPastries()}");
          Console.WriteLine($"Your total cost is ${total}");
        }
      }
    }
  }
}