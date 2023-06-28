using Creative.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors((o) =>
{
    o.AddPolicy("openpolicy", (c) => { c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod(); });
});

builder.Services.AddDbContext<ApplicationDbContext>((option) =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDb") ?? throw new InvalidOperationException("Connection string 'SchoolDb' not found."));
    option.ConfigureWarnings(w => w.Ignore(SqlServerEventId.DecimalTypeKeyWarning));
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDistributedMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};


app.UseHttpsRedirection();
app.UseCors("openpolicy");
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
