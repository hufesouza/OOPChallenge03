using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenge03
{
    // base class
    internal class PhotoBook
    {
        protected int numPages;

        //Default Constructor
        public PhotoBook()
        {
            numPages = 16;
        }
        // Simple constructor
        public PhotoBook(int numPage)
        {
            this.numPages = numPage;
        }

        //Method to return page number as required
        public int GetNumberPages()
        {
            return (numPages);
        }
    }
}
