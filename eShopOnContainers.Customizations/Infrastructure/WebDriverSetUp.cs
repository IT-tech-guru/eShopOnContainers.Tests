using System.Drawing;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace eShopOnContainers;

public static class WebDriverSetUp
{
    public static Driver SetUp(Browser browser)
    {
        Driver driver;

        switch (browser)
        {
            case Browser.Firefox:
                driver = new Driver(new FirefoxDriver());
                break;
            case Browser.Chrome:
                driver = new Driver(new ChromeDriver());
                break;
            case Browser.InternetExplorer:
                driver = new Driver(new InternetExplorerDriver());
                break;
            default:
                throw new NotSupportedException();
        }

        driver.WrappedDriver.Manage().Window.Position = new Point(2000, 1);
        driver.WrappedDriver.Manage().Window.Maximize();

        return driver;
    }
}
