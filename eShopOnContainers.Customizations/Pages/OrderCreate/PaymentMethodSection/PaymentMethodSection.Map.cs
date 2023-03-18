using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class PaymentMethodSection
{
    public IWebElement CardNumberTextField => _driver.FindElement(By.XPath(""));
    public IWebElement CardHolderNameTextField => _driver.FindElement(By.XPath(""));
    public IWebElement ExpirationCodeTextField => _driver.FindElement(By.XPath(""));
    public IWebElement SecurityCodeTextField => _driver.FindElement(By.XPath(""));

}
