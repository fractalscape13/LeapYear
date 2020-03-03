using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.TestTools
{
  [TestClass]
  public class LeapYearTests
  {
    [TestMethod]
    public void IsLeapYear_DivisbleByFour_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
    }

    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFour_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(2001));
    }

    [TestMethod]
    public void IsLeapYear_MultiplesofOneHundred_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }

    [TestMethod]
    public void IsLeapYear_MultiplesofFourHundred_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }

  }
}