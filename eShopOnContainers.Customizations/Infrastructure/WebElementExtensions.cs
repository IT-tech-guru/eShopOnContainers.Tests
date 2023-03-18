using OpenQA.Selenium;

namespace eShopOnContainers;

public static class WebElementExtensions
{
    public static void AddProductToCart(this IWebElement webElement, int quantity)
    {
        for (int i = 1; i <= quantity; i++)
        {
            webElement.Click();
        }
    }
}
