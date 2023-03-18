using OpenQA.Selenium;

namespace eShopOnContainers
{
    public partial class ProductsSection
    {
        public IWebElement ProductByPosition(int position)
        {
            var product = _driver.FindElement(By.XPath($"(//input[@class='esh-catalog-button '])[{position}]"));

            return product;
        }

        public IWebElement ProductByName(string name)
        {
            var product = _driver.FindElement(By.XPath($"(//span[text()='{name}']/../../input)[1]"));
        
            return product;
        }
    }
}
