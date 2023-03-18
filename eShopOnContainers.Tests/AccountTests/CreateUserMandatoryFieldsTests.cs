using System.Reflection;

namespace eShopOnContainers.AccountTests;

public class CreateUserMandatoryFieldsTests
{
    private UserModel _user;
    private Driver _driver;
    private LoginPage _loginPage;
    private HomePage _homePage;
    private RegisterPage _registerPage;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        _driver = WebDriverSetUp.SetUp(Browser.Chrome);
        _loginPage = new LoginPage(_driver);
        _homePage = new HomePage(_driver);
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

    [Test]
    public void CorrectErrorMessageShown_When_NameFieldMissing()
    {
        _user.Name = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.Name));
    }

    [Test]
    public void CorrectErrorMessageShown_When_LastNameFieldMissing()
    {
        _user.LastName = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.LastName));
    }

    [Test]
    public void CorrectErrorMessageShown_When_StreetFieldMissing()
    {
        _user.Address = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.Street));
    }

    [Test]
    public void CorrectErrorMessageShown_When_CityFieldMissing()
    {
        _user.City = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.City));
    }

    [Test]
    public void CorrectErrorMessageShown_When_StateFieldMissing()
    {
        _user.State = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.State));
    }

    [Test]
    public void CorrectErrorMessageShown_When_CountryFieldMissing()
    {
        _user.Country = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.Country));
    }

    [Test]
    public void CorrectErrorMessageShown_When_ZipCodeFieldMissing()
    {
        _user.Postcode = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.ZipCode));
    }

    [Test]
    public void CorrectErrorMessageShown_When_CardNumberFieldMissing()
    {
        _user.CardNumber = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.CardNumber));
    }

    [Test]
    public void CorrectErrorMessageShown_When_CardHolderNameFieldMissing()
    {
        _user.CardholderName = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.CardHolderName));
    }

    [Test]
    public void CorrectErrorMessageShown_When_ExpirationFieldMissing()
    {
        _user.ExpirationDate = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.Expiration));
    }

    [Test]
    public void CorrectErrorMessageShown_When_SecurityNumberFieldMissing()
    {
        _user.SecurityCode = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.SecurityNumber));
    }

    [Test]
    public void CorrectErrorMessageShown_When_EmailFieldMissing()
    {
        _user.Email = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.Email));
    }

    [Test]
    public void CorrectErrorMessageShown_When_PasswordFieldMissing()
    {
        _user.Password = string.Empty;

        _registerPage.FillUserData(_user);

        Assert.That(_registerPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.Password));
    }
}