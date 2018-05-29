using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PocketNurseAutomation
{
  public class HomePage
  {
    public static void GoTo()
    {
      Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
      var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
      wait.Until(d => d.FindElement(By.LinkText("PocketNurse")));
    }
    public static bool IsAt
    {
      get
      {
        // Refactor: Can we create a generalized IsAt for all pages?
        var home = Driver.Instance.FindElement(By.LinkText("PocketNurse"));
        if(home.GetAttribute("href") == "/")
        {
          var homeLink = Driver.Instance.FindElement(By.LinkText("Home"));
          if (home.GetAttribute("href") == "/")
          {
            var aboutLink = Driver.Instance.FindElement(By.LinkText("About"));
            if (aboutLink.GetAttribute("href") == "/Home/About")
            {
              var contactLink = Driver.Instance.FindElement(By.LinkText("Contact"));
              if (contactLink.GetAttribute("href") == "/Home/Contact")
              {
                return true;
              }
            }
          }
        }
        return false;
      }
    }
  }
}
