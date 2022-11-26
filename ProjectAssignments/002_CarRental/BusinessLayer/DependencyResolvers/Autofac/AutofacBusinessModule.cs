using Autofac;

public class AutofacBusinessModule : Module
{
    // override edilebilecek metodları görebilmek için over yaz space bas
    protected override void Load(ContainerBuilder builder)
    {
        // biri senden ICarService isterse ona CarManager ver
        // WepApi program.cs'te yaptığımız işlemin aynısı
        // builder.Services.AddSingleton<ICarService, CarManager>();
        builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();
        builder.RegisterType<EFCarDal>().As<ICarDal>().SingleInstance();
        builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
        builder.RegisterType<EFUserDal>().As<IUserDal>().SingleInstance();
        builder.RegisterType<RentalManager>().As<IRentalService>().SingleInstance();
        builder.RegisterType<EFRentalDal>().As<IRentalDal>().SingleInstance();
        
    }
}

