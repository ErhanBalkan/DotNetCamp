public class Result : IResult
{
    public bool State {get; set;}

    public string Message {get; set;}

    public Result(bool state, string message) : this(state)
    {
        Message = message;
    }
    public Result(bool state)
    {
        State = state;
    }
}