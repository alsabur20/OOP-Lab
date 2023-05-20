using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS2.BL;

namespace PS2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chapters = new List<string>
            {
                "1. Introduction",
                "2. The Beginning",
                "3. The Climax",
                "4. The End"
            };
            Book b = new Book("anas", 2500, chapters, 2000);

            Console.WriteLine("Chapter Name: {0}",b.getChapter(2));
            Console.WriteLine("BookMark Before: {0}",b.getBookMark());
            b.setBookMark(200);
            Console.WriteLine("BookMark After: {0}",b.getBookMark());
            Console.WriteLine("BookPrice Before: {0}",b.getBookPrice());
            b.setBookPrice(10000);
            Console.WriteLine("BookPrice After: {0}",b.getBookPrice());

            Console.ReadKey();

        }
    }
}
