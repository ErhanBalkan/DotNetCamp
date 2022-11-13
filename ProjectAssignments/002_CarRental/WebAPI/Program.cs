var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// ------------------------------ IOC CONTAİNER ------------------------------
/*
    burada demek istenilen sana bir IUserService verilirse ona UserManager instance'ı ver.
    diğerinde de IUserDal verilirse EFUserDal instance'ı ver anlamındadır. 
*/
builder.Services.AddSingleton<IUserService,UserManager>();
builder.Services.AddSingleton<IUserDal,EFUserDal>();
builder.Services.AddSingleton<ICarService, CarManager>();
builder.Services.AddSingleton<ICarDal,EFCarDal>();
builder.Services.AddSingleton<IRentalService,RentalManager>();
builder.Services.AddSingleton<IRentalDal,EFRentalDal>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
