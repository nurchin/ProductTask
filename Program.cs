using ProductTask.Class;

namespace ProductTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library1 = new Library();
            Book book1= new Book(1,"Jane Eyre", 13, "Romance fiction");
            Book book2= new Book(2,"Metamorphosis", 20, "Fiction"  );
            Book book3 = new Book(3, "White Nights", 15, "Absurdist Fiction");

                library1.AddBook(book1);
                library1.AddBook(book2);
                library1.AddBook(book3); 

            

                Book givenBook = library1.GetBookByName(book1.Name);

                if ( givenBook != null )
            {
                Console.WriteLine(givenBook.Name);
            }
                else {
                Console.WriteLine("Given book name doesn't exist");
                    }

            Book givenBook2 = library1.GetBookById(2);
                if ( givenBook2 != null )
            {
                Console.WriteLine(givenBook2);
            }
                else
            {
                Console.WriteLine("Given book id doesn't exist");
            }

            foreach (var book in library1.GetFilteredBooks("Fiction"))
            {
                Console.WriteLine(book);
            }

            foreach (var book in library1.GetFilteredBooks(10, 18))
            {
                Console.WriteLine(book);
            }
        }
    }
}