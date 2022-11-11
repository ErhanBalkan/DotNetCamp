public class EFCarDal : EFGenericRepository<Car, CarRentalContext>, ICarDal
{
    public List<CarDetailDto> GetCarsDetail()
    {
        using (CarRentalContext context = new CarRentalContext())
        {
            var result = from c in context.Cars
                         join b in context.Brands
                         on c.BrandId equals b.Id
                         join clr in context.Colors
                         on c.ColorId equals clr.Id
                         select new CarDetailDto{
                            BrandName = b.Name,
                            CarId = c.Id,
                            CarName = c.Name,
                            ColorName = clr.Name,
                            DailyPrice = c.DailyPrice,
                            Description = c.Description,
                            ModelYear = c.ModelYear,
                         };
            return result.ToList();                        
        }
    }
}