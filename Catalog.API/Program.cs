using Catalog.API.Data;
using Catalog.API.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICatalogContext, CatalogContext>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Catalog.API", 
                                        Version = "v1", 
                                        Description = "Cursos de desenvolvimento de MicroService :: Jose Carlos Macoratti" });
    //Esse codigo foi adicionado para resolver a��es conflitantes que � quando a��es est�o
    //usando a mesma rota
    c.ResolveConflictingActions(x => x.First());
}
);

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
