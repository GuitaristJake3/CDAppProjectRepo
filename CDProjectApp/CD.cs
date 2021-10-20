using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDProjectApp
{
    class CD : General_Media
    {
        string genre, artist, album;
        int tracks;
        //Define a constructor based on values we should have
        public CD(string g, string ar, string al, int t, string rt, string l, int ry) : base(rt, l, ry)
        {
            genre = g;
            artist = ar;
            album = al;
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
        public int Tracks
        {
            get { return tracks; }
        }

    }
}
