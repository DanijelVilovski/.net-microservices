using Microsoft.EntityFrameworkCore;
using Uris.Context;
using Uris.Repositories.KatastarskaOpstinaRepository;
using Uris.Repositories.KulturaRepository;
using Uris.Repositories.KursRepository;
using Uris.Repositories.KvalitetZemljistaRepository;
using Uris.Repositories.ParcelaRepository;
using Uris.Repositories.UplataRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(setup =>
                setup.ReturnHttpNotAcceptable = true
            ).AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UrisDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IKursRepository, KursRepository>();  
builder.Services.AddScoped<IKulturaRepository, KulturaRepository>();  
builder.Services.AddScoped<IKvalitetZemljistaRepository, KvalitetZemljistaRepository>();  
builder.Services.AddScoped<IKatastarskaOpstinaRepository, KatastarskaOpstinaRepository>();  
builder.Services.AddScoped<IUplataRepository, UplataRepository>();  
builder.Services.AddScoped<IParcelaRepository, ParcelaRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
