using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class OrderDetailsSection : BasePage
{
    private readonly IWebDriver _driver;

    public OrderDetailsSection(Driver driver) : base(driver)
    {
        _driver = driver.WrappedDriver;
    }

}
