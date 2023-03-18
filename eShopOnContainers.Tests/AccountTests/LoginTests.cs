namespace eShopOnContainers.AccountTests;

[TestFixture]
public class LoginTests
{
    private Driver _driver;
    private LoginPage _loginPage;
    private HomePage _homePage;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        _driver = WebDriverSetUp.SetUp(Browser.Chrome);
        _loginPage = new LoginPage(_driver);
        _homePage = new HomePage(_driver);
    }

    [SetUp]
    public void Setup()
    {
        _homePage.Open();
        _homePage.LoginButton.Click();
    }

    [Test]
    public void LoginSuccessful_When_DemoUserUsed()
    {
        _loginPage.Login(Credentials.DemoUserEmail, Credentials.DemoUserPassword);

        Assert.That(_homePage.UserIdentityTextField.Text, Is.EqualTo(Credentials.DemoUserEmail));
    }

    [Test]
    public void CorrectErrorMessage_When_WrongEmailUsed()
    {
        _loginPage.Login("WrongEmail@microsoft.com", Credentials.DemoUserPassword);

        Assert.That(_loginPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.InvalidUserNameOrPassword));
    }

    [Test]
    public void CorrectErrorMessage_When_WrongPasswordUsed()
    {
        _loginPage.Login(Credentials.DemoUserEmail, "WrongPassword");

        Assert.That(_loginPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.InvalidUserNameOrPassword));
    }

    [Test]
    public void CorrectErrorMessage_When_EmptyEmailField()
    {
        _loginPage.Login(string.Empty, Credentials.DemoUserPassword);

        Assert.That(_loginPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.Email));
    }

    [Test]
    public void CorrectErrorMessage_When_EmptyPasswordField()
    {
        _loginPage.Login(Credentials.DemoUserEmail, string.Empty);

        Assert.That(_loginPage.ValidationErrorTextField.Text, Is.EqualTo(MandatoryFieldsErrors.Password));
    }
}