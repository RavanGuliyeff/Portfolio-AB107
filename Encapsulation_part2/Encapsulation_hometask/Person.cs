//FullName check ( ən azı 2 sözdən ibarət olmalıdı ad və soyaddan hər ikisi böyük hərf-lə başlamalıdır )

//ps:Person yaradılarkən bütün dəyərlərin verilməsi məcburidir

namespace Encapsulation_hometask
{
    internal class Person
    {
        private string _fullName;
        private byte _age;
        private string _phoneNumber;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                string[] str = value.Split();
                if (str.Length == 2)
                {
                    if (char.IsUpper(str[0][0]) && char.IsUpper(str[1][0]))
                    {
                        _fullName = value;
                    }
                    else Console.WriteLine("The initials of the name and surname must be written in capital letters\n");
                }
                else Console.WriteLine("Name must consist of two words\n");
            }
        }

        public byte Age
        {
            get { return _age; }
            set
            {
                if (value > 0) _age = value;
                else Console.WriteLine("Age can not be negative or 0.");
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public Person(string fullName, byte age, string phoneNumber)
        {
            FullName = fullName;
            Age = age;
            PhoneNumber = phoneNumber;
        }
    }
}
