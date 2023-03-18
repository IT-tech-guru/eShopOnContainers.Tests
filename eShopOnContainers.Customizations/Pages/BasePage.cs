using OpenQA.Selenium;

namespace eShopOnContainers;

public abstract class BasePage
{
    private readonly IWebDriver _webDriver;

    public

    virtual string? Url
    { get; set; }

    public BasePage(Driver driver)
    {
        _webDriver = driver.WrappedDriver;
    }

    public void Open()
    {
        _webDriver.Navigate().GoToUrl(Url);
    }

}
