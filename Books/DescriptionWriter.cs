using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class DescriptionWriter
    {
        public void Display(Book book)
        {
            Console.WriteLine($"ID: {book.Id}\nTitle: {book.Title}\nCategory: {book.Category}\nAuthor: {book.Author}\nPublish Date: {book.PublicationDate}\n");
        }
    }
}
