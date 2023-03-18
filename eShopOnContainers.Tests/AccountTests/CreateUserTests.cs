using System.Reflection;

namespace eShopOnContainers.AccountTests;

public class CreateUserTests
{
    private UserModel _user;
    private Driver _driver;
    private LoginPage _loginPage;
    private HomePage _homePage;
    private CartPage _cartPage;
    private RegisterPage _registerPage;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        _driver = WebDriverSetUp.SetUp(Browser.Chrome);
        _loginPage = new LoginPage(_driver);
        _homePage = new HomePage(_driver);
        _cartPage = new CartPage(_driver);
        _registerPage = new RegisterPage(_driver);
    }

    [SetUp]
    public void Setup()
    {
        _user = UserFactory.CreateUser();
        _homePage.Open();
        _homePage.LoginButton.Click();
        _loginPage.RegisterAsNewUserButton.Click();
    }

    [TearDown]
    public void TearDown()
    {
        //_driver.Quit();
    }


    [Test]
    public void RegisterPageOpened_When_RegisterNewUserLinkClicked()
    {
        Assert.That(_driver.WrappedDriver.Title, Is.EqualTo("eShopOnContainers Identity"));
    }

    [Test]
    public void UserCreatedSuccessfully_When_ValidDataFilled()
    {
        _registerPage.FillUserData(_user);

        _loginPage.Login(_user.Email, _user.Password);

        Assert.That(_driver.WrappedDriver.Title, Is.EqualTo("Catalog - Microsoft.eShopOnContainers.WebMVC"));
    }

    [Test]
    public void CorrectErrorMessageShown_When_InvalidExpirationDateFieldFormatUsed()
    {
        _user.ExpirationDate = "03-10";

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.DateFormat));
    }

    [Test]
    public void CorrectErrorMessageShown_When_NotMatchingPasswordAndConfirmationPassword()
    {
        _user.Password = "Password";
        _user.ConfirmPassword = "NotMatchingPassword";

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.NotMatchingPasswordAndConfirmation));
    }

    [Test]
    public void CorrectErrorMessageShown_When_InvalidPasswordFieldFormatUsed()
    {
        _user.Password = "Password";
        _user.ConfirmPassword = "Password";

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.InvalidPassword));
    }
}