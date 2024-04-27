using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BusinessManagementSystem.Auth
{
    public class AuthOptions
    {
        public const string ISSUER = "BusinessManagement"; // издатель токена
        public const string AUDIENCE = "MyAuthClient"; // потребитель токена
        const string KEY = "123e4567-e89b-12d3-a456-426614174000";   // ключ для шифрации
        public const int LIFETIME = 30; // время жизни токена - 15 минута
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));
    }
}
