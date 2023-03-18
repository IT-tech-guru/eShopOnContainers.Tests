using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class ProductsSection : BasePage
{
    private readonly IWebDriver _driver;

    public ProductsSection(Driver driver) : base(driver)
    {
        _driver = driver.WrappedDriver;
    }

    public void AddMultipleElements(string name, int quantity)
    {
        for (int i = 1; i <= quantity; i++)
        {
            ProductByName(name).Click();
        }
    }
}
