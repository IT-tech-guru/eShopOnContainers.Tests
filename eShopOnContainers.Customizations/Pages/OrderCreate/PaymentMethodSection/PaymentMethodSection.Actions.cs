using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class PaymentMethodSection : BasePage
{
    private readonly IWebDriver _driver;

    public PaymentMethodSection(Driver driver) : base(driver)
    {
        _driver = driver.WrappedDriver;
    }

}
