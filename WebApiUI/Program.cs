using Applicaion;
using Persistance;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ApplicationServiceExtensionsIoC(); // Assembly olarak tamomladik dikkat !!!
//?rne?in, bir web uygulamas?nda kullan?c? bilgilerini saklamak i?in bir veritaban? kullanmak, persistans katman? kullan?m?d?r.
//Bu sayede kullan?c? bilgileri kal?c? olarak saklan?r ve
//kullan?c? uygulamaya tekrar giri? yapt???nda bu bilgiler h?zl? bir ?ekilde eri?ilebilir.
builder.Services.PersistanseExtensionsIoC(builder.Configuration);// persistance islemi dbcontext configuration 



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
