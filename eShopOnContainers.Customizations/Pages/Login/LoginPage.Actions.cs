using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class LoginPage : BasePage
{
    private readonly IWebDriver _driver;

    public LoginPage(Driver driver) : base(driver)
    {
        _driver = driver.WrappedDriver;
    }

    public void LoginDemoUser()
    {
        EmailTextField.SendKeys(Credentials.DemoUserEmail);
        PasswordTextField.SendKeys(Credentials.DemoUserPassword);
        RememberMeCheckBox.Click();
        LoginButton.Click();
    }

    public void Login(string username, string password)
    {
        EmailTextField.SendKeys(username);
        PasswordTextField.SendKeys(password);
        RememberMeCheckBox.Click();
        LoginButton.Click();
    }
}
