public interface ICarDal : IGenericRepository<Car>
{
    List<CarDetailDto> GetCarsDetail();
}