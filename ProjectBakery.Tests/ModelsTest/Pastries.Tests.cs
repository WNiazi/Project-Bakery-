using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_DeclareObject_Pastry()
    {
      Pastries pastryTotal = new Pastries(1);
      Assert.AreEqual(typeof(Pastries), pastryTotal.GetType());
    }
    [TestMethod]
    public void PastryConstructor_GettingTwoTreats_Int()
    {
      int inputtedPastryAmount = 2;
      Pastries pastryTotal = new Pastries(inputtedPastryAmount);
      int total = pastryTotal.AmountPastries;
      Assert.AreEqual(inputtedPastryAmount, total);
    }
    [TestMethod]
    public void PastryConstructor_CalculatingTwoTreats_Int()
    {
      int inputtedPastryAmount = 2;
      Pastries pastryTotal = new Pastries(inputtedPastryAmount);
      int total = pastryTotal.CalculateTotalPastries();
      Assert.AreEqual(4, total);
    }
    [TestMethod]
    public void PastryConstructor_CalculatingThreeTreats_Int()
    {
      int inputtedPastryAmount = 3;
      Pastries pastryTotal = new Pastries(inputtedPastryAmount);
      int total = pastryTotal.CalculateTotalPastries();
      Assert.AreEqual(5, total);
    }
    [TestMethod]
    public void PastryConstructor_CalculatingFiveTreats_Int()
    {
      int inputtedPastryAmount = 5;
      Pastries pastryTotal = new Pastries(inputtedPastryAmount);
      int total = pastryTotal.CalculateTotalPastries();
      Assert.AreEqual(9, total);
    }
  }
}