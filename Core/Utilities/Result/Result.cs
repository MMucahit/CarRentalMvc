namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public bool Success { get; }
        public string Message { get; }

        //Overloading
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
    }
}
