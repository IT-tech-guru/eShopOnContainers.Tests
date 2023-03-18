using OpenQA.Selenium;

namespace eShopOnContainers;

public partial class RegisterPage : BasePage
{
    private readonly IWebDriver _driver;

    public RegisterPage(Driver driver) : base(driver)
    {
        _driver = driver.WrappedDriver;
    }

    public void FillUserData(UserModel userModel)
    {
        Name.SendKeys(userModel.Name);
        LastName.SendKeys(userModel.LastName);
        Address.SendKeys(userModel.Address);
        City.SendKeys(userModel.City);
        State.SendKeys(userModel.State);
        Country.SendKeys(userModel.Country);
        Postcode.SendKeys(userModel.Postcode);
        PhoneNumber.SendKeys(userModel.PhoneNumber);
        CardNumber.SendKeys(userModel.CardNumber);
        CardholderName.SendKeys(userModel.CardholderName);
        ExpirationDate.SendKeys(userModel.ExpirationDate);
        SecurityCode.SendKeys(userModel.SecurityCode);
        Email.SendKeys(userModel.Email);
        Password.SendKeys(userModel.Password);
        ConfirmPassword.SendKeys(userModel.ConfirmPassword);
        RegisterButton.Click();
    }
}
