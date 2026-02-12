using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Teknoroma.DataAccess;
using Teknoroma.BLL;
using Teknoroma.DataAccess.Context;
using Teknoroma.WinFormUI;

var builder = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false);

IConfiguration configuration = builder.Build();

var services = new ServiceCollection();

// DbContext
services.AddDbContext<TeknoromaDbContext>(options =>
    options.UseSqlServer(
        configuration.GetConnectionString("DefaultConnection")
    )
);

//Form Kayýt
services.AddTransient<CategoryForm>();
services.AddTransient<LoginForm>();
services.AddTransient<UserCreateForm>();
services.AddTransient<LoginFormWithAPI>();

// BLL – DAL
//services.AddScoped<IUserService, UserService>();

ServiceProvider serviceProvider = services.BuildServiceProvider();

// WinForms baþlatma
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);

Application.Run(serviceProvider.GetRequiredService<LoginFormWithAPI>());
