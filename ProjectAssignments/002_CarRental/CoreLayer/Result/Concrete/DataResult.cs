public class DataResult<T> : Result, IDataResult<T>
{
    public T Data {get; set;}

    public DataResult(T data, bool state, string message) : base(state, message)
    {
        Data = data;
    }
    public DataResult(T data, bool state) : base(state)
    {
        Data = data;
    }
}