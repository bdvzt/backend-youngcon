using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using FluentValidation;
using YoungConService.Infrastructure.Auth;
using Microsoft.OpenApi.Models;
using Polly;
using YoungConService.Infrastructure.Repositories;
using YoungConService.Repositories.Events;
using YoungConService.Repositories.Achievments;
using YoungConService.Services;
using YoungConService.Services.Achievments;
using YoungConService.Services.Events.Event;
using YoungConService.Services.Events.Festival;
using YoungConService.Services.Events.Floor;
using YoungConService.Services.Events.Speaker;
using YoungConService.Services.Events.Zone;
using YoungConService.Infrastructure.Errors.Exceptions;
using YoungConService.Services.Validators;
using Swashbuckle.AspNetCore.Annotations;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });


builder.Services.AddCors(options =>
{
    options.AddPolicy("FrontCors", policy =>
    {
        var origins = builder.Configuration
            .GetSection("Cors:AllowedOrigins")
            .Get<string[]>() ?? Array.Empty<string>();

        policy
            .WithOrigins(origins)
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<YoungConDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


var jwtSettings = builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>()!;
builder.Services.AddSingleton(jwtSettings);
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IFestivalRepository, FestivalRepository>();
builder.Services.AddScoped<IFloorRepository, FloorRepository>();
builder.Services.AddScoped<IZoneRepository, ZoneRepository>();
builder.Services.AddScoped<ISpeakerRepository, SpeakerRepository>();
builder.Services.AddScoped<IAchievmentRepository, AchievmentRepository>();
builder.Services.AddScoped<IConEventRepository, ConEventRepository>();
builder.Services.AddScoped<IFestivalService, FestivalService>();
builder.Services.AddScoped<IFloorService, FloorService>();
builder.Services.AddScoped<IZoneService, ZoneService>();
builder.Services.AddScoped<ISpeakerService, SpeakerService>();
builder.Services.AddScoped<IAchievmentService, AchievmentService>();
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICurrentUser, CurrentUser>();
builder.Services.AddValidatorsFromAssemblyContaining<CreateUserValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<PagedRequestValidator>();

builder.Services.AddSwaggerGen(options =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath);
    
    options.EnableAnnotations();
    
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Введите JWT токен в формате: Bearer {токен}"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference 
                { 
                    Type = ReferenceType.SecurityScheme, 
                    Id = "Bearer" 
                }
            },
            []
        }
    });
});

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        var key = Encoding.UTF8.GetBytes(jwtSettings.Secret);

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings.Issuer,
            ValidAudience = jwtSettings.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });

builder.Services.AddAuthorization();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<YoungConDbContext>();

    var retry = Policy
        .Handle<Exception>()
        .WaitAndRetry(5, _ => 
            TimeSpan.FromSeconds(5));

    retry.Execute(() =>
    {
        db.Database.Migrate();
    });
}

app.UseSwagger(c =>
{
    c.RouteTemplate = "swagger/{documentName}/swagger.json";
    c.PreSerializeFilters.Add((swaggerDoc, httpReq) =>
    {
        swaggerDoc.Servers = new List<OpenApiServer>
        {
            new OpenApiServer { Url = $"http://{httpReq.Host.Value}" }
        };
    });
});

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "YoungCon API V1");
    c.RoutePrefix = "swagger";
});

app.UseCors("FrontCors");

app.UseAuthentication();
app.UseMiddleware<BlacklistTokenMiddleware>();
app.UseAuthorization();

app.UseMiddleware<ExceptionMiddleware>();
app.MapControllers();

app.Run();