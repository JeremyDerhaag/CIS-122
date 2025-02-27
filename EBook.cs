// Written by Jeremy Derhaag
// 02/27/2025


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_5_Library_System
{
    public class EBook : Book
    {
        // private var
        private double fileSize = -1;


        // get and set
        public double FileSize
        {  
            get { return fileSize; }
            set { fileSize = value; }
        }


        // constructor
        public EBook(string aTitle, string aAuthor, int aYear, double aFileSize) : base(aTitle,aAuthor, aYear)
        {
            this.FileSize = aFileSize;
        }


        // method
        public override string ToString()
        {
            return base.ToString() + ", File size: " + FileSize;
        }




    }
}
