using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.WriteLine("Welcome to Pierre Bakery!");
      Console.WriteLine("We have Bread and Pastries.");
      Console.WriteLine("Current specials are: 3 for 1 on Bread Loaves!");
      Console.WriteLine("Pastries 1 for $2 and 3 for $5.");
      Console.WriteLine("How many loaves would you like? [1-6]");
      string stringTemp = Console.ReadLine();
      int inputtedBreadAmount = 0;
      Int32.TryParse(stringTemp, out inputtedBreadAmount);
      Console.WriteLine("How many pastries would you like? [1 - 6]");
      string stringTempP = Console.ReadLine();
      int inputtedPastriesAmount = 0;
      Int32.TryParse(stringTempP, out inputtedPastriesAmount);

      Bread breadTotal = new Bread(inputtedBreadAmount);

      Pastries pastryTotal = new Pastries(inputtedPastriesAmount);

      int total = (pastryTotal.CalculateTotalPastries() + breadTotal.CalculateTotalBread());

      Console.WriteLine("Your total cost is " + "$" + (total) + ".");
      Console.WriteLine("You bought " + (inputtedBreadAmount) + " loaves of bread. For a total of " + "$" + (breadTotal.CalculateTotalBread()) + ".");
      Console.WriteLine("You bought " + (inputtedPastriesAmount) + " sweet(s). For a total of " + "$" + (pastryTotal.CalculateTotalPastries()) + ".");
    }
  }
}





// namespace Bakery
// {
//   public class Program
//   {
//     public static void Main()
//     {
//       Console.WriteLine("Choose an option by picking [1 or 2 or 3 or 4]:");
//       Console.WriteLine("(1) Buy Bread.");
//       Console.WriteLine("(2) Buy Pasteries.");
//       Console.WriteLine("(3) Buy Both.");
//       Console.WriteLine("(4) Exit.");
//       Console.Write("\r\nSelect an option: ");
//       string temp = Console.ReadLine();
//       int menu = int.Parse(temp);

//       switch (menu)
//       {
//         case 1:
//           GetBreadOrder();
//           GetBreadTotal();
//           break;
//         case 2:
//           GetPastryOrder();
//           GetPastryTotal();
//           break;
//         case 3:
//           GetBreadOrder();
//           GetPastryOrder();
//           GetTotal();
//           break;
//         case 4:
//           Console.WriteLine("Another time!");
//           Main();
//           break;
//       }

//       static int GetBreadOrder()
//       {
//         Console.WriteLine("How many loaves would you like? [1-6]");
//         string stringTemp = Console.ReadLine();
//         int inputtedBreadAmount = 0;
//         Int32.TryParse(stringTemp, out inputtedBreadAmount);
//         if (inputtedBreadAmount <= 0 || inputtedBreadAmount > 7)
//         {
//           Console.WriteLine("Pick from 1-6! ");
//         }
//         return inputtedBreadAmount;
//       }

//       static int GetPastryOrder()
//       {
//         Console.WriteLine("How many pastries would you like? [1 - 10]");
//         string stringTempP = Console.ReadLine();
//         int inputtedPastriesAmount = 0;
//         Int32.TryParse(stringTempP, out inputtedPastriesAmount);
//         if (inputtedPastriesAmount < 0 || inputtedPastriesAmount < 7)
//         {
//           Console.WriteLine("That is too much or not enough!");
//           Main();
//         }
//         return inputtedPastriesAmount;
//       }

//       static void GetBreadTotal()
//       {
//         Bread breadTotal = new Bread();
//         Console.WriteLine($"${breadTotal.AmountBread}");
//         Console.WriteLine($"${breadTotal.CalculateTotalBread()}");
//       }
//       static void GetPastryTotal()
//       {
//         Pastries pastryTotal = new Pastries(GetPastryOrder());
//         Console.WriteLine("$" + (pastryTotal.AmountPastries));
//         Console.WriteLine("$" + (pastryTotal.CalculateTotalPastries()));
//       }
//       static void GetTotal()
//       {
//         Bread breadTotal = new Bread(GetBreadOrder());
//         Pastries pastryTotal = new Pastries(GetPastryOrder());
//         int total = (pastryTotal.CalculateTotalPastries() + breadTotal.CalculateTotalBread());
//         Console.WriteLine($"Your total cost is {total}");
//       }
//     }
//   }
// }