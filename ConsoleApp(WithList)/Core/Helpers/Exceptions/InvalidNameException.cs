namespace Core.Helpers.Exceptions
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string msg = "Invalid name") : base(msg)
        {
        }
    }
}
