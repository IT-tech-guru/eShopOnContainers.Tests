namespace eShopOnContainers.dCheckOutTests;

[TestFixture]
public class CheckOutTests
{
    private Driver _driver;
    private LoginPage _loginPage;
    private HomePage _homePage;
    private CartPage _cartPage;
    private OrderCreatePage _orderCreatePage;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        _driver = WebDriverSetUp.SetUp(Browser.Chrome);
        _loginPage = new LoginPage(_driver);
        _homePage = new HomePage(_driver);
        _cartPage = new CartPage(_driver);
        _orderCreatePage = new OrderCreatePage(_driver);
    }

    [SetUp]
    public void Setup()
    {
        _homePage.Open();
        _homePage.LoginButton.Click();
        _loginPage.LoginDemoUser();
    }

    [TearDown]
    public void TearDown()
    {
        _driver.Quit();
    }

    [Test]
    public void OrderCreatePageOpened_When_CheckoutButtonClicked()
    {
        _homePage.ProductsSection.ProductByName(Products.BlueHoodie).Click();
        _homePage.CartButton.Click();

        _cartPage.CheckoutButton.Click();

        Assert.That(_driver.WrappedDriver.Title, Is.EqualTo("New Order - Microsoft.eShopOnContainers.WebMVC"));
    }

    [Test]
    public void CorrectQuantityOnOrderCreatePage_When_SomeItemsAddedToCart()
    {
        _homePage.ProductsSection.ProductByName(Products.BlueHoodie).Click();
        _homePage.CartButton.Click();
        _cartPage.CheckoutButton.Click();
        var initialQuantity = int.Parse(_orderCreatePage.OrderDetailsSection.ProductQuantity(row: 1).Text);

        _homePage.Open();
        _homePage.ProductsSection.ProductByName(Products.BlueHoodie).Click();
        _homePage.CartButton.Click();
        _cartPage.CheckoutButton.Click();
        var actualQuantity = int.Parse(_orderCreatePage.OrderDetailsSection.ProductQuantity(row: 1).Text);

        Assert.That(actualQuantity, Is.EqualTo(initialQuantity - 1));
    }

    [Test]
    public void CorrectTotalPriceOnOrderCreatePage_When_SomeItemsAddedToCart()
    {

    }

    [Test]
    public void CorrectDataOnOrderCreatePage_When_ItemAddedToCart()
    {

    }

    [Test]
    public void CorrectDataOnOrderCreatePage_When_ItemRemovedFromCart()
    {

    }

    [Test]
    public void CartPageEditable_When_OrderCreateProcessStarted()
    {

    }

    [Test]
    public void CorrectErrorMessageDisplayed_When_MandatoryFieldIsEmpty()
    {

    }

    [Test]
    public void CannotOpenOrderCreatePage_When_UserNotLogged()
    {

    }

    [Test]
    public void CannotOpenOrderCreatePage_When_ItemNotAddedToCart()
    {

    }
}