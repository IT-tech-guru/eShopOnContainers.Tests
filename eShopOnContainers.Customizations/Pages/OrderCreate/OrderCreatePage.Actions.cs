using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class OrderCreatePage : BasePage
{
    private readonly IWebDriver _driver;

    public ShippingAddressSection? ShippingAddressSection { get; set; }
    public PaymentMethodSection? PaymentMethodSection { get; set; }
    public OrderDetailsSection? OrderDetailsSection { get; set; }


    public OrderCreatePage(Driver driver) : base(driver)
    {
        _driver = driver.WrappedDriver;
        ShippingAddressSection = new ShippingAddressSection(driver);
        PaymentMethodSection = new PaymentMethodSection(driver);
        OrderDetailsSection = new OrderDetailsSection(driver);
    }
}
