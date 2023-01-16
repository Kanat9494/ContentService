var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(
            builder.Configuration.GetConnectionString("ContentConnectionString")
        )
);

builder.Services.AddScoped(typeof(IDataContent<Category>), typeof(ExecuteCategoryData));
builder.Services.AddScoped(typeof(IDataContent<PopularProduct>), typeof(ExecuteProductData));

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
