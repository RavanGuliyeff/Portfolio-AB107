namespace Classes_part2
{
    internal class Library
    {
        public string Name;
        Book[] Books = { };

        public void AddBook(Book book)
        {
            Book[] newBooks = new Book[Books.Length + 1];
            for (int i = 0; i < Books.Length; i++)
            {
                newBooks[i] = Books[i];
            }
            newBooks[^1] = book;
            Books = newBooks;
        }

        public void ShowAllBooks()
        {
            foreach (Book book in Books)

                Console.WriteLine($"Name: {book.Name}\nPrice: {book.Price}\n");

        }

        public void SearchBook()
        {
            string name = Console.ReadLine();
            string result = null;

            foreach (Book book in Books)
            {
                if (book.Name == name)
                {
                    result = $"Name: {book.Name}\nPrice: {book.Price}\n";
                    break;
                };

            }
            Console.WriteLine(result);
            
        }

    }
}
