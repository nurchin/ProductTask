using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.Class
{
    internal class Library
    {
            public Book[] Books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
        }
        public Book? GetBookById(int id) { 

        foreach(var book in Books)
            {
                if (book.Id == id)
                {
                    return book;
                }      
            }
            return null;
           

        }

        public Book? GetBookByName(string name)
        {

            foreach (var book in Books)
            {
                if (book.Name == name)
                {
                    return book;
                }
            }
            return null;


        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filteredBooks = Array.FindAll(Books, book => book.Genre == genre);
            return filteredBooks;

        }
        
             public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book[] filteredBooks = Array.FindAll(Books, book => book.Price >= minPrice && book.Price <= maxPrice);
            return filteredBooks;
        }
    }
    }

