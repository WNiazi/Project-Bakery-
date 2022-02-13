using System;

namespace Bakery.Models
{
  public class Pastries
  {
    public int AmountPastries { get; set; }
    public int CostPastries { get; set; }
    public Pastries(int amountPastries)
    {
      AmountPastries = amountPastries;
      CostPastries = this.CalculateTotalPastries();
    }
    public int CalculateTotalPastries()
    {
      if (AmountPastries % 3 == 0)
      {
        int costPastry = ((2 * AmountPastries) - (AmountPastries / 3));
        return costPastry;
      }
      else if (AmountPastries >= 3 && AmountPastries <= 6)
      {
        int costPastry = (((2 * AmountPastries) - 1));
        return costPastry;
      }
      else if (AmountPastries == 1 || AmountPastries == 2)
      {
        int costPastry = (AmountPastries * 2);
        return costPastry;
      }
      else
      {
        return (AmountPastries);
      }
    }
  }
}
