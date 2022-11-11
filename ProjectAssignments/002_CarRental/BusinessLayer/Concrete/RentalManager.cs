public class RentalManager : IRentalService
{
    IRentalDal _rentalDal;
    public RentalManager(IRentalDal rentalDal)
    {
        _rentalDal = rentalDal;
    }
    public IResult Add(Rental rental)
    {
        if (rental.RentDate == null)
        {
            return new ErrorResult();
        }else if(rental.RentDate == new DateTime(0001,01,01)){
            return new ErrorResult();
        }
        _rentalDal.Add(rental);
        return new SuccessResult();
    }
}