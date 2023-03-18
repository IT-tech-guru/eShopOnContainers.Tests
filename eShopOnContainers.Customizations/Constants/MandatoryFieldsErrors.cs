namespace eShopOnContainers;

public static class MandatoryFieldsErrors
{
    // Register page
    public static string Name = "The Name field is required.";
    public static string LastName = "The LastName field is required.";
    public static string Street = "The Street field is required.";
    public static string City = "The City field is required.";
    public static string State = "The State field is required.";
    public static string Country = "The Country field is required.";
    public static string ZipCode = "The ZipCode field is required.";
    public static string CardNumber = "The CardNumber field is required.";
    public static string CardHolderName = "The CardHolderName field is required.";
    public static string Expiration = "The Expiration field is required";
    public static string SecurityNumber = "The SecurityNumber field is required.";
    public static string Email = "The Email field is required.";
    public static string Password = "The Password field is required.";
    public static string DateFormat = "Expiration should match a valid MM/YY value";
    public static string NotMatchingPasswordAndConfirmation = "The password and confirmation password do not match.";
    public static string InvalidPassword = "Passwords must have at least one non alphanumeric character.";

    //Login page
    public static string InvalidUserNameOrPassword = "Invalid username or password.";
}
