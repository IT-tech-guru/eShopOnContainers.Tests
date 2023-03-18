using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class CartPage
{
    public IWebElement ProductName(int row)
    {
        return _driver.FindElement(By.XPath($"//article[@class='esh-basket-items  row'][{row}]/section[2]"));
    }

    public IWebElement ProductPrice(int row)
    {
        return _driver.FindElement(By.XPath($"//article[@class='esh-basket-items  row'][{row}]/section[3]"));
    }

    public IWebElement ProductQuantity(int row)
    {
        return _driver.FindElement(By.XPath($"//article[@class='esh-basket-items  row'][{row}]/section[4]/input[@type='number']"));
    }

    public IWebElement ProductTotalPrice(int row)
    {
        return _driver.FindElement(By.XPath($"//article[@class='esh-basket-items  row'][{row}]/section[5]"));
    }

    public IWebElement UpdateButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
    public IWebElement CheckoutButton => _driver.FindElement(By.XPath("//input[@type='submit']"));
}
