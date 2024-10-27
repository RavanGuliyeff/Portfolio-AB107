namespace Core.Helpers.Exceptions
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException(string msg = "Not available"):base(msg)
        {
            
        }
    }
}
