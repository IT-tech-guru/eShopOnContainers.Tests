using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class HomePage
{
    public IWebElement LoginButton => _driver.FindElement(By.XPath("//a[contains(text(), 'Login')]"));
    public IWebElement CartButton => _driver.FindElement(By.XPath("//div[@class='esh-basketstatus-image']"));
    public IWebElement UserIdentityTextField => _driver.FindElement(By.XPath("//div[@class='esh-identity-name']"));
}
