using System.Diagnostics.Metrics;
using System.Net;

namespace eShopOnContainers;

public static class UserFactory
{
    public static UserModel CreateUser()
    {
        var userModel = new UserModelFaker().Generate();

        return userModel;
    }
}
