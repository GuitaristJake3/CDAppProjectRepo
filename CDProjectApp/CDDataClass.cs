using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDProjectApp
{
    class CD
    {
        string genre;
        //Define a constructor based on values we should have
        public CD(string g)
        {
            genre = g;
        }
        public string Genre
        {
            get { return genre; }
        }
    }
}
