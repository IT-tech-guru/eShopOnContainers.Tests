using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class ShippingAddressSection : BasePage
{
    private readonly IWebDriver _driver;

    public ShippingAddressSection(Driver driver) : base(driver)
    {
        _driver = driver.WrappedDriver;
    }

}
