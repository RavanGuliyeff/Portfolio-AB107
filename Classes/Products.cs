namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook("Apple MacBook Pro M3", 1, 8519.99, 36)
            {
                Description = "Apple MacBook Pro M3 is a macOS laptop with a 14.2-inch display that has a resolution of 3024 x 1964 pixels.",
                Storage = 512
            };

            notebook1.GetFullInfo();
            notebook1.ShowFullData();
            notebook1.Sale();
            notebook1.Sale();
        }
    }

    class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

        public Product(string name, int count, double price)
        {
            Name = name;
            Price = price;
            if (count > 0)
            {
                IsStock = true;
                Count = count;
            }
        }

        public void Sale()
        {
            if (IsStock)
            {
                Count--;
                if (Count == 0) IsStock = false;
            }
            else Console.WriteLine("Mehsul yoxdur!");
        }
    }

    class Notebook : Product
    {
        public byte RAM;
        public int Storage;

        public Notebook(string name, int count, double price, byte ram) : base(name, count, price)
        {
            RAM = ram;
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"Name: {Name}\nDescription: {Description}\nPrice: {Price}\nRam: {RAM}\nStorage: {Storage}\n");
        }

        public void ShowFullData()
        {
            Console.WriteLine($"Name: {Name}\nDescription: {Description}\nPrice: {Price}\nRam: {RAM}\nStorage: {Storage}\nCount: {Count}\nIt is in stock: {IsStock}\n");
        }
    }
}
