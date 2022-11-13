public interface IRentalService
{
    IResult Add(Rental rental);
    IDataResult<List<Rental>> GetAll();
    IDataResult<Rental> GetById(int id);
}