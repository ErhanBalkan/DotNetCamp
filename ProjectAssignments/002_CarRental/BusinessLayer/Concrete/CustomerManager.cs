public class CustomerManager : ICustomerService
{
    ICustomerDal _customerDal;
    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }
    public IResult Add(Customer customer)
    {
        _customerDal.Add(customer);
        return new SuccessResult();
    }

    public IResult Delete(Customer customer)
    {
        _customerDal.Delete(customer);
        return new SuccessResult();
    }

    public IDataResult<List<Customer>> GetAll()
    {
        List<Customer> data = _customerDal.GetAll();
        return new SuccessDataResult<List<Customer>>(data);
    }

    public IDataResult<Customer> GetById(int id)
    {
        Customer data = _customerDal.Get(cs => cs.Id == id);
        return new SuccessDataResult<Customer>(data);
    }

    public IResult Update(Customer customer)
    {
        _customerDal.Update(customer);
        return new SuccessResult();
    }
}