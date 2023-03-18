using OpenQA.Selenium;

namespace eShopOnContainers;

public class Driver
{
    public IWebDriver WrappedDriver { get; set; }

    public Driver(IWebDriver driver)
    {
        WrappedDriver = driver;
    }

    public void GoToUrl(string url)
    {
        WrappedDriver.Navigate().GoToUrl(url);
    }

    public void Quit()
    {
        WrappedDriver.Quit();
    }
}
