public class ErrorDataResult<T> : DataResult<T>
{
    public ErrorDataResult(T data, string message): base(data, false, message)
    {
        
    }
    public ErrorDataResult(T data): base(data, false)
    {
        
    }
    // Default çalıştığın tipin yani data'nın default değerini temsil eder.
    public ErrorDataResult(string message): base(default, false, message)
    {
        
    }
    public ErrorDataResult(): base(default, false)
    {
        
    }
}