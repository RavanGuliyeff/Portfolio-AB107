namespace Core.Helpers.Exceptions
{
    internal class InvalidCapacityException : Exception
    {
        public InvalidCapacityException(string msg = "Invalid Capacity") : base(msg)
        {

        }
    }
}
