// // Add services to the container.
using Autofac;
using Autofac.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new AutofacBusinessModule()));

builder.Services.AddControllers();
// // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// // ------------------------------ IOC CONTAİNER ------------------------------
// /*
//     burada demek istenilen sana bir IUserService verilirse ona UserManager instance'ı ver.
//     diğerinde de IUserDal verilirse EFUserDal instance'ı ver anlamındadır. 
// */
// builder.Services.AddSingleton<IUserService,UserManager>();
// builder.Services.AddSingleton<IUserDal,EFUserDal>();
// builder.Services.AddSingleton<ICarService, CarManager>();
// builder.Services.AddSingleton<ICarDal,EFCarDal>();
// builder.Services.AddSingleton<IRentalService,RentalManager>();
// builder.Services.AddSingleton<IRentalDal,EFRentalDal>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

