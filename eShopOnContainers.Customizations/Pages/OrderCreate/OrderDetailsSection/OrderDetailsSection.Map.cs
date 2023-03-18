using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class OrderDetailsSection
{
    public IWebElement ProductName(int row)
    {
        var element = _driver.FindElement(By.XPath($"//article[@class='esh-orders_new-items esh-orders_new-items--border row'][{row}]/section[2]"));

        return element;
    }

    public IWebElement ProductPrice(int row)
    {
        var element = _driver.FindElement(By.XPath($"//article[@class='esh-orders_new-items esh-orders_new-items--border row'][{row}]/section[3]"));

        return element;
    }

    public IWebElement ProductQuantity(int row)
    {
        var element = _driver.FindElement(By.XPath($"//article[@class='esh-orders_new-items esh-orders_new-items--border row'][{row}]/section[4]"));

        return element; 
    }

    public IWebElement ProductTotalPrice(int row)
    {
        var element = _driver.FindElement(By.XPath($"//article[@class='esh-orders_new-items esh-orders_new-items--border row'][{row}]/section[5]"));

        return element;
    }
}
