namespace Core.Utilities.Result
{
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}
