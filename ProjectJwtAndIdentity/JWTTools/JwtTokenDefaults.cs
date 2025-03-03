namespace ProjectJwtAndIdentity.JWTTools
{
    public class JwtTokenDefaults
    {
        //const sabit demek - bi sınıftaki değere direk erişmek için
        public const string ValidAudience = "https://localhost";
        public const string ValidIssuer = "https://localhost";
        public const string Key = "IdentityJwt.1234567890+-*/Token000";
        public const int Expire = 5;
    }
}
