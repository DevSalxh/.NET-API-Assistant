// Before var app = builder.Build();
builder.Services.AddCors();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(opt =>
{
    var tokenKey = builder.Configuration["TokenKey"]
        ?? throw new Exception("Token Key not found - Program.cs");
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

// before app.MapControllers && after var app = builder.Build

app.UseAuthentication(); // Make sure Authentication before Authorization
app.UseAuthorization();
