namespace Core.Helpers.Exceptions
{
    internal class InvalidPriceException: Exception
    {
        public InvalidPriceException(string msg = "Price can not be negative"):base(msg)
        {         
        }
    }
}
