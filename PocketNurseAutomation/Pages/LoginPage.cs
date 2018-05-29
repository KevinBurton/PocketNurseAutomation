using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PocketNurseAutomation
{
  public class LoginPage
  {
    public static void GoTo()
    {
      Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + "/Account/Login");
      var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
      wait.Until(d => d.FindElement(By.CssSelector("input#Email.form-control")));
    }

    public static LoginCommand LoginAs(string userName)
    {
      return new LoginCommand(userName);
    }
  }

  public class LoginCommand
  {
    private readonly string userName;
    private string password;

    public LoginCommand(string userName)
    {
      this.userName = userName;
    }

    public LoginCommand WithPassword(string password)
    {
      this.password = password;
      return this;
    }

    public void Login()
    {
      var loginInput = Driver.Instance.FindElement(By.CssSelector("input#Email.form-control"));
      loginInput.SendKeys(userName);

      var passwordInput = Driver.Instance.FindElement(By.CssSelector("input#Password.form-control"));
      passwordInput.SendKeys(password);

      var loginButton = Driver.Instance.FindElement(By.CssSelector("button.btn.btn-default"));
      loginButton.Click();
    }
  }
}
