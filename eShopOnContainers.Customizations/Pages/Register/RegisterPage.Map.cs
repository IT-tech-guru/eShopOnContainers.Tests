using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class RegisterPage
{
    public IWebElement Name => _driver.FindElement(By.XPath("//input[@id='User_Name']"));
    public IWebElement LastName => _driver.FindElement(By.XPath("//input[@id='User_LastName']"));
    public IWebElement Address => _driver.FindElement(By.XPath("//input[@id='User_Street']"));
    public IWebElement City => _driver.FindElement(By.XPath("//input[@id='User_City']"));
    public IWebElement State => _driver.FindElement(By.XPath("//input[@id='User_State']"));
    public IWebElement Country => _driver.FindElement(By.XPath("//input[@id='User_Country']"));
    public IWebElement Postcode => _driver.FindElement(By.XPath("//input[@id='User_ZipCode']"));
    public IWebElement PhoneNumber => _driver.FindElement(By.XPath("//input[@id='User_PhoneNumber']"));
    public IWebElement CardNumber => _driver.FindElement(By.XPath("//input[@id='User_CardNumber']"));
    public IWebElement CardholderName => _driver.FindElement(By.XPath("//input[@id='User_CardHolderName']"));
    public IWebElement ExpirationDate => _driver.FindElement(By.XPath("//input[@id='User_Expiration']"));
    public IWebElement SecurityCode => _driver.FindElement(By.XPath("//input[@id='User_SecurityNumber']"));
    public IWebElement Email => _driver.FindElement(By.XPath("//input[@id='Email']"));
    public IWebElement Password => _driver.FindElement(By.XPath("//input[@id='Password']"));
    public IWebElement ConfirmPassword => _driver.FindElement(By.XPath("//input[@id='ConfirmPassword']"));

    public IWebElement RegisterButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
    public IWebElement ValidationErrorTextField => _driver.FindElement(By.XPath("//div[@class='text-danger validation-summary-errors']//li"));

}
