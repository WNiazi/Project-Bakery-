namespace Bakery.Models
{
  public class Bread
  {
    public int AmountBread { get; set; }
    public Bread(int amountBread)
    {
      AmountBread = amountBread;
    }
    public int CalculateTotalBread()
    {
      if (AmountBread % 3 == 0)
      {
        int costBread = (AmountBread * 5) - ((AmountBread / 3) * 5);
        return costBread;
      }
      else if (AmountBread == 1 || AmountBread == 2)
      {
        int costBread = (AmountBread * 5);
        return costBread;
      }
      else
      {
        int costBread = ((AmountBread * 5) - 5);
        return costBread;
      }
    }

  }
}