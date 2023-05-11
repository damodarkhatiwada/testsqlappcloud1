using testsqlappcloud.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "Endpoint=https://custumcongi.azconfig.io;Id=sHhM;Secret=dTJm9C99RuLSBsBQbnJz7CzSVzchgGXecPbhwO7E5Z0=";
builder.Host.ConfigureHostConfiguration(builder =>

builder.AddAzureAppConfiguration(connectionString)


); 
builder.Services.AddTransient<IProductService, ProductService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
