namespace Rki.CancerDataGenerator.Services
{
    public interface IJwtAuthenticator
    {
        JwtAuthenticator.UserJwt DecodeToken(string token);
        string IsUserAuthenticated(string username, string passwd);
    }
}