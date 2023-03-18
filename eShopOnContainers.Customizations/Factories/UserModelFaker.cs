using Bogus;

namespace eShopOnContainers;

internal class UserModelFaker : Faker<UserModel>
{
    public UserModelFaker()
    {
        RuleFor(user => user.Name, faker => faker.Name.FirstName());
        RuleFor(user => user.LastName, faker => faker.Name.LastName());
        RuleFor(user => user.Address, faker => faker.Address.StreetAddress());
        RuleFor(user => user.City, faker => faker.Address.City());
        RuleFor(user => user.State, faker => faker.Address.State());
        RuleFor(user => user.Country, faker => faker.Address.Country());
        RuleFor(user => user.Postcode, faker => faker.Address.CountryCode());
        RuleFor(user => user.PhoneNumber, faker => faker.Phone.PhoneNumber());
        RuleFor(user => user.CardNumber, faker => "4242424242424242");
        RuleFor(user => user.CardholderName, faker => faker.Name.FullName());
        RuleFor(user => user.ExpirationDate, faker => faker.Date.Future(11).ToString("MM/dd"));
        RuleFor(user => user.SecurityCode, faker => faker.Random.Int(100, 999).ToString());
        RuleFor(user => user.Email, faker => faker.Person.Email.ToString());
        RuleFor(user => user.Password, faker => "Password0)");
        RuleFor(user => user.ConfirmPassword, faker => "Password0)");
    }
}