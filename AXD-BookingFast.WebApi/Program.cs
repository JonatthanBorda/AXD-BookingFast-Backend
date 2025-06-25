using AXD_BookingFast.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);


//MediatR (manejo de comandos y queries):
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AXD_BookingFast.Application.AssemblyReference).Assembly));

//AutoMapper (configuración de mapeos de DTOs y entidades):
builder.Services.AddAutoMapper(typeof(AXD_BookingFast.Application.Mapping.MappingProfile));

//Servicios de infraestructura (DbContext, Repositorios, UnitOfWork):
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddInfrastructure(connectionString!);

builder.Services.AddControllers();

//Swagger:
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Pipeline de solicitudes HTTP:
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
