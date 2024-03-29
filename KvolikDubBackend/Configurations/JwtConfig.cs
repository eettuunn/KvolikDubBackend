﻿using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace KvolikDubBackend.Configurations;

public class JwtConfig
{
    public const string Issuer = "kvolikdub_backend";              
    public const string Audience = "kvolikdub_frontend";                  
    private const string Key = "TheVeryStrongKeyOrPasswordQwerty123";
    public const int Lifetime = 1;
    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
    }
}