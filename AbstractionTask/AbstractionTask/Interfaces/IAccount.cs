namespace AbstractionTask.Interfaces
{
    internal interface IAccount
    {
        public bool PasswordChecker(string password);
        public void ShowInfo();
    }
}
