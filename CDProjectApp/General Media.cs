using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDProjectApp
{
    /// <summary>
    /// This is a base class which provides generic media fields.
    /// Child classes for specific media such as CDs will inherit and use these fields
    /// </summary>
    public class GeneralMedia
    {
        /// <summary>
        /// Class fields to be inherited are declared and are private
        /// </summary>
        string runTime, location;
        int releaseYear;
        /// <summary>
        /// A constructor is defined even though the class will not be instantiated.
        /// This is so fields may be inherited by child class
        /// </summary>
        /// <param name="rt">The run time of the media</param>
        /// <param name="l">The physical location of the media</param>
        /// <param name="ry">The year the media was released</param>
        public GeneralMedia(string rt, string l, int ry)
        {
            runTime = rt;
            location = l;
            releaseYear = ry;
        }
        /// <summary>
        /// Accessors allow private class fields to be accessed indirectly so they may not be modified.
        /// These will be inherited by child class
        /// </summary>
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
