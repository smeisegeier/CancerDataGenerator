# Rki.CancerDataGenerator
Generator for German Clinical Cancer Data<br>
# Documentation
swagger.authentification.jwt.code analyzer

## packages

## Configuring services
Startup.cs
```csharp
/* security */
            services.AddSingleton<IJwtAuthenticator, JwtAuthenticator>();   // add service as singleton
            services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
                {
                    //options.RequireHttpsMetadata = false;
                    //options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetValue<string>("JwtTokenPw"))),
                        ValidateAudience = false, 
                        // if ClockSkew is not nulled, 5min delay always apply!
                        ValidateLifetime = true, ClockSkew = TimeSpan.Zero,
                        ValidateIssuer = true, ValidIssuers = new string[] { "dexterDSD", "rki" }
                    };
                });
```
- Register own JwtAuthenticator as singleton service including Interface (ref)
- Add Authenticator service with jwt Options
- TokenValidationParameters define how jwt are processed
- IssuerSigningKey
    - can be symmetric or asymmetric
    - e.g. SHA256 means minimum 16 characters in secret must be provided
    - proposed: get secret from config files and load via ``GetValue`` from appsettings.json / local secret file

appsettings.json:
```csharp  
}
  },
  "JwtTokenPw": "my-secret-key",
  "AllowedHosts": "*"
}    
```
 - ValidateAudience / Issuer
  - provide values to check against - if Validation = true
  - LifeSpan: ClockSkew problem *must* be adressed to avoid minimum of 5min lifespan of jwt


## Configure swagger
Startup.cs
```csharp  
            /* Swagger */
            services.AddSwaggerGen(c =>
            {

                /* Versions */
                var v1 = new OpenApiInfo()
                {
                    Title = Globals.APPNAME,
                    Version = "v1",
                    License = new OpenApiLicense() { Name = "Testlicense", Url = new Uri("https://example.com/license") },
                    Contact = new OpenApiContact() { Name = "creator", Email = "me@exampl.com" },
                    Description = @"<h1>API</h1> <b>description</b> can be written using <strong>html</strong> tags.<br> <small>More to come.</small>",
                };
                var v2 = v1;
                v2.Version = "v2";

                /* create versioned docs*/
                c.SwaggerDoc("v1", v1);
                c.SwaggerDoc("v2", v2);

                /* Authentification JUST SWagger */
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Insert the received JWT token into field, no leading 'Bearer' keyword.<br> It is valid for 2hrs.",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                        },
                        new List<string>()
                    }
                });


                // Set the comments path for the Swagger JSON and UI.
                // Also note checking xml doc generation in build options
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

            });
```




[![Readme Card](https://github-readme-stats.vercel.app/api/pin/?username=smeisegeier&repo=VsCode)](https://github.com/anuraghazra/github-readme-stats)
<br>
[![smeisegeier's GitHub stats](https://github-readme-stats.vercel.app/api?username=smeisegeier&count_private=true&hide_border=true&show_icons=true)](https://github.com/anuraghazra/github-readme-stats)
<br>


You can render UML diagrams using [Mermaid](https://mermaidjs.github.io/). For example, this will produce a sequence diagram:

```mermaid
sequenceDiagram
Alice ->> Bob: Hello Bob, how are you?
Bob-->>John: How about you John?
Bob--x Alice: I am good thanks!
Bob-x John: I am good thanks!
Note right of John: Bob thinks a long<br/>long time, so long<br/>that the text does<br/>not fit on a row.

Bob-->Alice: Checking with John...
Alice->John: Yes... John, how are you?
```

And this will produce a flow chart:

```mermaid
graph LR
A[Square Rect] -- Link text --> B((Circle))
A --> C(Round Rect)
B --> D{Rhombus}
C --> D
```
