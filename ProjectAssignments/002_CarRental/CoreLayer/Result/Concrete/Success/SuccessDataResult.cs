public class SuccessDataResult<T> : DataResult<T>
{
    public SuccessDataResult(T data, string message) : base(data, true, message){}
    public SuccessDataResult(T data) : base(data, true){}
    public SuccessDataResult() : base(default, true){} // default data girilmezse default değer verir yani null
}