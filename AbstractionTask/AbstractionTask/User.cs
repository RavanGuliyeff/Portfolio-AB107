using AbstractionTask.Interfaces;

namespace AbstractionTask
{
    internal class User : IAccount
    {
        private static int idCounter;
        public readonly int ID = ++idCounter;

        private string _password;

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password
        {
            get { return _password; }
            set
            {
                if(PasswordChecker(value)) _password = value;
                else Console.WriteLine(" - the password must have at least 8 characters\n - the password must contain at least 1 capital letter\n - the password must contain at least 1 lowercase letter\n - the password must have at least 1 digit\n\n");
            }
        }


        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        

        public bool PasswordChecker(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            if (password.Length >= 8)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpper = true;
                    if (char.IsLower(c)) hasLower = true;
                    if (char.IsDigit(c)) hasDigit = true;
                    if (hasUpper && hasLower && hasDigit) return true;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"User's fullname: {FullName}\nEMail: {Email}\nID: {ID}\n\n");
        }
        
    }
}
