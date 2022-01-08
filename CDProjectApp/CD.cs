using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDProjectApp
{
    /// <summary>
    /// This will inherit from the General_Media class and will make CD objects to go into a CD list.
    /// It is made public so may be accessed by different forms
    /// </summary>
    public class CD : GeneralMedia
    {
        /// <summary>
        /// Class fields that are not inherited are declared and are private
        /// </summary>
        string genre, artist, album;
        int tracks;
        /// <summary>
        /// A constructor is defined which will pass field values to each CD as it is made
        /// </summary>
        /// <param name="g">The genre of the music</param>
        /// <param name="ar">Album artist. Will be a unique identifier with album</param>
        /// <param name="al">Album title. Will be a unique identifier with artist</param>
        /// <param name="t">The number of tracks</param>
        /// <param name="rt">The run time of the CD(inherited)</param>
        /// <param name="l">The physical location of the CD(inherited)</param>
        /// <param name="ry">The year the CD was released(inherited)</param>
        public CD(string g, string ar, string al, int t, string rt, string l, int ry) : base(rt, l, ry)
        {
            genre = g;
            artist = ar;
            album = al;
            tracks = t;
        }
        /// <summary>
        /// Accessors allow private class fields to be accessed indirectly so they may not be modified
        /// </summary>
        public string Genre
        {
            get { return genre; }
        }
        public string Artist
        {
            get { return artist; }
        }
        public string Album
        {
            get { return album; }
        }
        public int Tracks
        {
            get { return tracks; }
        }
    }
}
