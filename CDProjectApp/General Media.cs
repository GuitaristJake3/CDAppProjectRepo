using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDProjectApp
{
    public class General_Media
    {
        string runTime, location;
        int releaseYear; 

        public General_Media(string rt, string l, int ry)
        {
            runTime = rt;
            location = l;
            releaseYear = ry;
        }
        public string RunTime
        {
            get { return runTime; }
        }
        public string Location
        {
            get { return location; }
        }
        public int ReleaseYear
        {
            get { return releaseYear; }
        }
    }
}
