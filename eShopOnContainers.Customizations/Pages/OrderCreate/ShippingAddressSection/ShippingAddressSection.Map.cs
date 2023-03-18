using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class ShippingAddressSection
{
    public IWebElement AddressTextField => _driver.FindElement(By.XPath(""));
    public IWebElement CityTextField => _driver.FindElement(By.XPath(""));
    public IWebElement StateTextField => _driver.FindElement(By.XPath(""));
    public IWebElement CountryTextField => _driver.FindElement(By.XPath(""));
}
