using BookStore.ODataApi.Models;

public static class DataSource
{
    private static IList<Book> listBooks { get; set; }
    public static IList<Book> GetBooks()
    {
        if (listBooks != null)
        {
            return listBooks;
        }

        listBooks = new List<Book>();
        Book book = new Book
        {
            Id = 1,
            ISBN = "978-0-321-87758-1",
            Title = "Essential C#5.0",
            Author = "Mark Michaelis",
            Price = 59.99m,
            Location = new Address
            {
                City = "HCM City",
                Street = "D2, Thu Duc District"
            },
            Press = new Press
            {
                Id = 1,
                Name = "Addison-Wesley",
                Category = Category.Book
            }
        };
        listBooks.Add(book);

        book = new Book
        {
            Id = 2,
            ISBN = "063-6-920-02371-5",
            Title = "Enterprise Games",
            Author = "Michael Hugos",
            Price = 59.99m,
            Location = new Address
            {
                City = "HCM City",
                Street = "D2, Thu Duc District"
            },
            Press = new Press
            {
                Id = 2,
                Name = "Michael Hugos",
                Category = Category.Magazine
            }
        };
        listBooks.Add(book);

        book = new Book
        {
            Id = 3,
            ISBN = "063-6-920-02371-9",
            Title = "Game Programming with Unity and C#",
            Author = "Casey Hardman",
            Price = 59.99m,
            Location = new Address
            {
                City = "HCM City",
                Street = "D2, Thu Duc District"
            },
            Press = new Press
            {
                Id = 3,
                Name = "Casey Hardman",
                Category = Category.EBook
            }
        };
        listBooks.Add(book);

        return listBooks;
    }

}