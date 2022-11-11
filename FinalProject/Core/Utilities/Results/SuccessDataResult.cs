public class SuccessDataResult<T> : DataResult<T>
{
    public SuccessDataResult(T data, string message): base(data, true, message)
    {
        
    }
    public SuccessDataResult(T data): base(data, true)
    {
        
    }
    // Default çalıştığın tipin yani data'nın default değerini temsil eder örneğin object için null.
    public SuccessDataResult(string message): base(default, true, message)
    {
        
    }
    public SuccessDataResult(): base(default, true)
    {
        
    }
}