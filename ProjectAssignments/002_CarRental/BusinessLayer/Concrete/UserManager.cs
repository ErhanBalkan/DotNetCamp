public class UserManager : IUserService
{
    IUserDal _userDal;
    public UserManager(IUserDal userDal)
    {
        _userDal = userDal;
    }
    public IResult Add(User user)
    {
        _userDal.Add(user);
        return new SuccessResult();
    }

    public IResult Delete(User user)
    {
        _userDal.Delete(user);
        return new SuccessResult();
    }

    public IDataResult<List<User>> GetAll()
    {
        List<User> data = _userDal.GetAll();
        return new SuccessDataResult<List<User>>(data);
    }

    public IDataResult<User> GetById(int id)
    {
        User data = _userDal.Get(u => u.Id == id);
        return new SuccessDataResult<User>(data);
    }

    public IResult Update(User user)
    {
        _userDal.Update(user);
        return new SuccessResult();
    }
}