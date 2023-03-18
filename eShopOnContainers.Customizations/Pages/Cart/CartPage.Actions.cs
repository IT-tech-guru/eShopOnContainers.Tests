using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class CartPage : BasePage
{
    private readonly IWebDriver _driver;

    public CartPage(Driver driver) : base(driver)
    {
        _driver = driver.WrappedDriver;
    }
}
