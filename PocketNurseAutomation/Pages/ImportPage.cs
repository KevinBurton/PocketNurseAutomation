using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PocketNurseAutomation.Selenium;

namespace PocketNurseAutomation.Pages
{
  public class ImportPage
  {

    public static bool IsAt
    {
      get
      {
        // Refactor: Can we create a generalized IsAt for all pages?
        var home = Driver.Instance.FindElement(By.LinkText("PocketNurse"));
        if (home.GetAttribute("href") == "/")
        {
          var homeLink = Driver.Instance.FindElement(By.LinkText("Import"));
          if (home.GetAttribute("href") == "/Import")
          {
            // Hello rkevinburton@charter.net! title="Manage" href="/Manage/Index"
            var logoutLink = Driver.Instance.FindElement(By.LinkText("Log out"));
            if (logoutLink.GetAttribute("type") == "submit")
            {
                return true;
            }
          }
        }
        return false;
      }
    }
  }
}
