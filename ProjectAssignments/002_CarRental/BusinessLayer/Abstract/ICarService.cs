public interface ICarService
{
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);
    IDataResult<List<Car>> GetAll();
    IDataResult<Car> GetById(int id);
    IDataResult<List<Car>> GetCarsByBrandId(int id);
    IDataResult<List<Car>> GetCarsByColorId (int id);
     IDataResult<List<CarDetailDto>> GetCarsDetail();   
}