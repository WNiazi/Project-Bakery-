namespace Bakery.Models
{
  public class Pasteries
  {
    public int AmountPastries { get; set; }
    public int CostPastries { get; set; }
    public Pasteries(int AmountPastries, int CostPastries)
    {
      AmountPastries = Program.GettingPasteryOrder();
      CostPastries = this.CalculateTotalPastries();
    }
    public int CalculateTotalPastries()
    {
      int totalCostPasteries = ((2 * Program.GettingPasteryOrder()) - (Program.GettingPasteryOrder() / 3));
      return totalCostPasteries;
    }
  }
}

