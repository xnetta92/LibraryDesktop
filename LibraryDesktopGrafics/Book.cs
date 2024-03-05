using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDesktopGrafics
{
    internal class Book
    {
        public Book(int id, string author, int page_count, int publish_year, string title)
        {
            this.id = id;
            this.author = author;
            this.page_count = page_count;
            this.publish_year = publish_year;
            this.title = title;
        }

        //proba ss
        //proba2

        public Book(int id, string title, string author, int publishYear, int pageCount)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.publish_year = publishYear;
            this.page_count = pageCount;
        }

        public int id { get; set; }
        public string author { get; set; }
        public int page_count { get; set; }
        public int publish_year { get; set; }
        public string title { get; set; }
    }
}

