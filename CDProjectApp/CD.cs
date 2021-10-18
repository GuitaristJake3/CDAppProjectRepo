using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDProjectApp
{
    class CD
    {
        string genre, artist, album, releaseYear, runTime, location;
        int tracks;
        //Define a constructor based on values we should have
        public CD(string g, string ar, string al, string ry, string rt, string l, int t)
        {
            genre = g;
            artist = ar;
            album = al;
            releaseYear = ry;
            runTime = rt;
            location = l;
            tracks = t;
        }
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
        public string ReleaseYear
        {
            get { return releaseYear; }
        }
        public string RunTime
        {
            get { return runTime; }
        }
        public string Location
        {
            get { return location; }
        }
        public int Tracks
        {
            get { return tracks; }
        }

    }
}
