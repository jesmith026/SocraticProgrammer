using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book()
            {
                Id = 1000,
                Title = "Introduction to SRP",
                Category = "Programming",
                Author = "Socratic Programmer",
                PublicationDate = DateTime.Now
            };

            var writer = new DescriptionWriter();
            writer.Display(book);
        }
    }
}
