namespace Core.Utilities.Result
{
    public class ErrorResult : Result, IResult
    {
        public ErrorResult(bool success, string message) : base(success, message)
        {

        }
        public ErrorResult(string message) : base(false, message)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
