namespace Bakery.Models
{
  public class Bread
  {
    public int AmountBread { get; set; }
    public int CostBread { get; set; }
    public Bread(int AmountBread, int CostBread)
    {
      AmountBread = Program.GettingBreadOrder();
      CostBread = this.CalculateTotalBread();
    }
    public int CalculateTotalBread()
    {
      int totalCostBread = (Program.GettingBreadOrder() * 5) - ((Program.GettingBreadOrder() / 3) * Program.GettingBreadOrder());
      return totalCostBread;
    }
  }
}

