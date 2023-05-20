using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2.BL
{
    class Book
    {
        public string author;
        public int pages;
        public List<string> chapters = new List<string>();
        public int bookMark;
        public int price;

        public Book(string author,int pages,List<string> chapters,int price)
        {
            this.author = author;
            this.pages = pages;
            this.chapters = chapters;
            this.bookMark =0;
            this.price = price;
        }
        public string getChapter(int chapterNumber)
        {
            string name = "Invalid!!";
            if (chapterNumber <+ chapters.Count)
            {
                name = chapters[chapterNumber - 1];
            }
            return name;
        }
        public int getBookMark()
        {
            return this.bookMark;
        }
        public void setBookMark(int pageNumber)
        {
            this.bookMark = pageNumber;
        }
        public int getBookPrice()
        {
            return this.price;
        }
        public void setBookPrice(int newPrice)
        {
            this.price = newPrice;
        }
    }
}
