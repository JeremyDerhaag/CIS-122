// Written by Jeremy Derhaag
// 02/27/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Library_System
{
    public class PrintedBook : Book
    {
        // private var
        private int page = -1;

        // get and set
        public int Page
        {
            get { return page; }
            set { page = value; }
        }

        // constructor
        public PrintedBook(string aTitle, string aAuthor, int aYear,int aPage) : base(aTitle,aAuthor,aYear)
        {
            this.Page = aPage;
        }


        // method
        public override string ToString()
        {
            return base.ToString() + ", Page count: " + this.Page;
        }


    }
}
