// Written by Jeremy Derhaag
// 02/27/2025



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Library_System
{
    public class Book
    {
        // private var
        private string title = "n/a";
        private string author = "n/a";
        private int year = 0;

        // gets and sets
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        // Constructor
        public Book(string aTitle, string aAuthor, int aYear)
        {
            Title = aTitle;
            Author = aAuthor;
            Year = aYear;
        }


        // method
        public override string ToString()
        {
            return Title + " by " + Author + " " + Year;
        }







    }
}
