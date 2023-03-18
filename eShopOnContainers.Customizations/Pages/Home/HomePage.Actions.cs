using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class HomePage : BasePage
{
    private readonly IWebDriver _driver;

    public ProductsSection? ProductsSection { get; set; }

    public override string Url => "http://host.docker.internal:5100/";

    public HomePage(Driver driver) : base(driver)
    {
        _driver = driver.WrappedDriver;
        ProductsSection = new ProductsSection(driver);
    }
}
