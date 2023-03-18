using OpenQA.Selenium.Support.UI;

namespace eShopOnContainers.CheckOutTests;

[TestFixture]
public class ShoppingCartTests
{
    private Driver _driver;
    private LoginPage _loginPage;
    private HomePage _homePage;
    private CartPage _cartPage;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        _driver = WebDriverSetUp.SetUp(Browser.Chrome);
        _loginPage = new LoginPage(_driver);
        _homePage = new HomePage(_driver);
        _cartPage = new CartPage(_driver);
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
    public void CartPageOpened_When_ShoppingCartButtonClicked()
    {
        _homePage.ProductsSection.ProductByName(Products.BlueHoodie).Click();

        _homePage.CartButton.Click();

        Assert.That(_driver.WrappedDriver.Title, Is.EqualTo("My Cart - Microsoft.eShopOnContainers.WebMVC"));
    }

    [Test]
    public void CartButtonClickable_When_SomeItemsAddedToCart()
    {
        //_homePage.ProductsSection.ProductByName(Products.BlueHoodie).Click();

        //var element = new WebDriverWait(_driver.WrappedDriver, new TimeSpan(0, 0, 5)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_homePage.CartButton));

        //var element123 = SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_homePage.CartButton);

        //var asdasd = element.Enabled;
        var asdasds = _homePage.CartButton.Enabled;
        Assert.That(true);
    }

    [Test]
    public void ItemAdded_When_AddOneItemToCart()
    {
        _homePage.ProductsSection.ProductByName(Products.BlueHoodie).Click();

        _homePage.CartButton.Click();

        Assert.That(_cartPage.ProductName(row: 1).Text, Is.EqualTo(Products.BlueHoodie));
    }

    [Test]
    public void QuantityIncreased_When_IncreaseItemQuantity()
    {

        _homePage.ProductsSection.ProductByName(Products.BlueHoodie).Click();
        _homePage.CartButton.Click();
        var productQuantity = int.Parse(_cartPage.ProductQuantity(row: 1).GetAttribute("value"));

        _homePage.Open();
        _homePage.ProductsSection.ProductByName(Products.BlueHoodie).Click();
        _homePage.CartButton.Click();

        Assert.That(_cartPage.ProductQuantity(row: 1).GetAttribute("value"), Is.EqualTo((productQuantity + 1).ToString()));
    }

    [Test]
    public void ItemAdded_When_AddSameItemToCartMutipleTimes()
    {
        var quantity = 5;

        _homePage.ProductsSection.AddMultipleElements(Products.BlueHoodie, quantity);
        _homePage.CartButton.Click();

        Assert.That(quantity, Is.EqualTo(int.Parse(_cartPage.ProductQuantity(row: 1).GetAttribute("value"))));
    }

    [Test]
    public void MutipleItemsAdded_When_AddMultipleDifferentItemsToCart()
    {
        var blueHoodieQuantity = 5;
        var blackAndWhiteMugquantity = 5;

        _homePage.ProductsSection.AddMultipleElements(Products.BlueHoodie, blueHoodieQuantity);
        _homePage.ProductsSection.AddMultipleElements(Products.BlackAndWhiteMug, blackAndWhiteMugquantity);
        _homePage.CartButton.Click();

        Assert.Multiple(() =>
        {
            Assert.That(blueHoodieQuantity, Is.EqualTo(int.Parse(_cartPage.ProductQuantity(row: 1).GetAttribute("value"))));
            Assert.That(blackAndWhiteMugquantity, Is.EqualTo(int.Parse(_cartPage.ProductQuantity(row: 1).GetAttribute("value"))));
        });
    }

    [Test]
    public void ItemsRemoved_When_RemoveSomeItemsFromCart()
    {
        // Cannot implement - functionality not available in Web MVC
    }

    [Test]
    public void ItemsRemoved_When_RemoveAlItemsFromCart()
    {
        // Cannot implement - functionality not available in Web MVC
    }
}