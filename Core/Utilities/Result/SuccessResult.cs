namespace Core.Utilities.Result
{
    public class SuccessResult : Result, IResult
    {
        public SuccessResult(bool success, string message) : base(success, message)
        {

        }
        public SuccessResult(string message) : base(true, message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
