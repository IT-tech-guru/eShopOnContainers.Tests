using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class LoginPage
{
    public IWebElement HeaderTextField => _driver.FindElement(By.XPath("//h4[text() = 'ARE YOU REGISTERED?']"));
    public IWebElement EmailTextField => _driver.FindElement(By.XPath("//input[@id='Email']"));
    public IWebElement PasswordTextField => _driver.FindElement(By.XPath("//input[@id='Password']"));
    public IWebElement RememberMeCheckBox => _driver.FindElement(By.XPath("//input[@id='RememberMe']"));
    public IWebElement LoginButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
    public IWebElement RegisterAsNewUserButton => _driver.FindElement(By.XPath("//a[contains(text(), 'Register')]"));
    public IWebElement ValidationErrorTextField => _driver.FindElement(By.XPath("//div[@class='text-danger validation-summary-errors']//li"));
}
