using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDProjectApp
{
    public partial class CDLibrary : Form
    {
        string currentGenre, currentArtist, currentAlbum, currentReleaseYear, currentRunTime, currentLocation;
        int currentTracks;
        CD currentCD;      //Creates a new CD object
        List<CD> cdList;   //List of objects of the class CD is defined as class variable

        public CDLibrary()
        {
            InitializeComponent();
            cdList = new List<CD>();   //The list is created on program startup
        }

        private void genreComboBox_Leave(object sender, EventArgs e)
        {
            currentGenre = genreComboBox.Text;     //Current genre is whatever is selected in the genreComboBox
        }
        private void artistTextBox_Leave(object sender, EventArgs e)
        {
            currentArtist = artistTextBox.Text;
        }
        private void albumTextBox_Leave(object sender, EventArgs e)
        {
            currentAlbum = albumTextBox.Text;
        }
        private void releaseMaskedTextBox_Leave(object sender, EventArgs e)
        {
            currentReleaseYear = releaseMaskedTextBox.Text;
        }
        private void runTimeMaskedTextBox_Leave(object sender, EventArgs e)
        {
            currentRunTime = runTimeMaskedTextBox.Text;
        }
        private void tracksUpDown_Leave(object sender, EventArgs e)
        {
            currentTracks = (int)tracksUpDown.Value;    //Value associated with CD will be int, not decimal
        }
        private void locationTextBox_Leave(object sender, EventArgs e)
        {
            currentLocation = locationTextBox.Text;
        }
        private void addDataToListButton_Click(object sender, EventArgs e)
        {
            currentCD = new CD(currentGenre, currentArtist, currentAlbum, currentReleaseYear, currentRunTime, currentLocation, currentTracks);      //Creates new CD with current fields passed as args
            cdList.Add(currentCD);      //Current CD added to CD list. Next we would display this list in a list box
            saveToolStripMenuItem.Enabled = true;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genreComboBox.Visible = true;
            genreLabel.Visible = true;
            artistLabel.Visible = true;
            artistTextBox.Visible = true;
            albumLabel.Visible = true;
            albumTextBox.Visible = true;
            releaseLabel.Visible = true;
            releaseMaskedTextBox.Visible = true;
            locationLabel.Visible = true;
            locationTextBox.Visible = true;
            tracksLabel.Visible = true;
            tracksUpDown.Visible = true;
            runTimeLabel.Visible = true;
            runTimeMaskedTextBox.Visible = true;
            addDataToListButton.Visible = true;
            cdList = new List<CD>();
        }
    }
}
