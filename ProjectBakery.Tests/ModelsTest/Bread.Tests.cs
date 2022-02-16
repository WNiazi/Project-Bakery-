using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests

{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_DeclareObject_Bread()
    {
      Bread breadTotal = new Bread(1);
      Assert.AreEqual(typeof(Bread), breadTotal.GetType());
    }
    [TestMethod]
    public void BreadConstructor_GettingTwoLoaves_Int()
    {
      int inputtedBreadAmount = 2;
      Bread breadTotal = new Bread(inputtedBreadAmount);
      int total = breadTotal.AmountBread;
      Assert.AreEqual(inputtedBreadAmount, total);
    }
    [TestMethod]
    public void BreadConstructor_CalculatingTwoLoaves_Int()
    {
      int inputtedBreadAmount = 2;
      int cost = 10;
      Bread breadTotal = new Bread(inputtedBreadAmount);
      int total = breadTotal.CalculateTotalBread();
      Assert.AreEqual(cost, total);
    }
    [TestMethod]
    public void BreadConstructor_CalculatingThreeLoaves_Int()
    {
      int inputtedBreadAmount = 3;
      int cost = 10;
      Bread breadTotal = new Bread(inputtedBreadAmount);
      int total = breadTotal.CalculateTotalBread();
      Assert.AreEqual(cost, total);
    }
    [TestMethod]
    public void BreadConstructor_CalculatingFiveLoaves_Int()
    {
      int inputtedBreadAmount = 5;
      int cost = 20;
      Bread breadTotal = new Bread(inputtedBreadAmount);
      int total = breadTotal.CalculateTotalBread();
      Assert.AreEqual(cost, total);
    }
  }
}