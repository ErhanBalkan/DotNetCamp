public class CarManager : ICarService
{
    ICarDal _carDal;
    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }
    public IResult Add(Car car)
    {
        if (car.ModelYear > 2000 && car.DailyPrice > 0)
        {
            _carDal.Add(car);
            return new SuccessResult();
        }
        return new ErrorResult();
    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult();
    }

    public IDataResult<List<Car>> GetAll()
    {
        List<Car> data = _carDal.GetAll();
        return new SuccessDataResult<List<Car>>(data);
    }

    public IDataResult<Car> GetById(int id)
    {
        Car data = _carDal.Get(c => c.Id == id);
        return new SuccessDataResult<Car>(data);
    }

    public IDataResult<List<Car>> GetCarsByBrandId(int id)
    {
        List<Car> data = _carDal.GetAll(c => c.BrandId == id);
        return new SuccessDataResult<List<Car>>(data);
    }

    public IDataResult<List<Car>> GetCarsByColorId(int id)
    {
        List<Car> data = _carDal.GetAll(c => c.ColorId == id);
        return new SuccessDataResult<List<Car>>(data);
    }

    public IDataResult<List<CarDetailDto>> GetCarsDetail()
    {
                List<CarDetailDto> data = _carDal.GetCarsDetail();
        return new SuccessDataResult<List<CarDetailDto>>(data);
    }

    public IResult Update(Car car)
    {
        _carDal.Update(car);
        return new SuccessResult();
    }
}