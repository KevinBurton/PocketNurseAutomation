using Microsoft.VisualStudio.TestTools.UnitTesting;
using PocketNurseAutomation.Pages;

namespace PocketNurseTest
{
  [TestClass]
  public class NavigationTests
  {
    [TestMethod]
    public void TestHome()
    {
      HomePage.GoTo();
      Assert.IsTrue(HomePage.IsAt);
    }
  }
}
