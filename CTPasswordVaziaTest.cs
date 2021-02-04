// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class CTPasswordVaziaTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new FirefoxDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void cTPasswordVazia() {
    driver.Navigate().GoToUrl("https://mantis-prova.base2.com.br/login_page.php");
    driver.Manage().Window.Size = new System.Drawing.Size(665, 721);
    driver.FindElement(By.Name("username")).Click();
    driver.FindElement(By.Name("username")).SendKeys("tiago.soares");
    driver.FindElement(By.CssSelector(".button")).Click();
    try {
      Thread.Sleep(7000);
    } catch {
      Console.WriteLine("{0} Exception caught.", e);
    }
    Assert.That(driver.FindElement(By.CssSelector("font")).Text, Is.EqualTo("Your account may be disabled or blocked or the username/password you entered is incorrect."));
  }
}
