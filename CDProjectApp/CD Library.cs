using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;        //Allows files to be loaded and saved

namespace CDProjectApp
{
    public partial class CDLibrary : Form
    {
        string currentGenre, currentArtist, currentAlbum, currentRunTime, currentLocation;
        int currentReleaseYear, currentTracks;
        CD currentCD;       //Creates a new CD object
        List<CD> cdList;        //List of objects of the class CD is declared as class variable
        public CDLibrary()
        {
            InitializeComponent();
            cdList = new List<CD>();        //The list is created on program startup
        }
        private void checkFieldsFilled()        //Will enable the add cd button if all fields have been filled
        {
            if (!string.IsNullOrEmpty(currentGenre)
                && !string.IsNullOrEmpty(currentArtist)
                && !string.IsNullOrEmpty(currentAlbum)
                && currentReleaseYear.ToString().Length == 4
                && !string.IsNullOrEmpty(currentRunTime)        //BUGFIX: Added to prevent crash when accessing .Length on a null
                && currentRunTime.Length == 5
                && currentTracks != 0
                && !string.IsNullOrEmpty(currentLocation))
            {
                addDataToListButton.Enabled = true;
            }
            else
            {
                addDataToListButton.Enabled = false;        //In case a field becomes empty after all being filled
            }
        }
        private void genreComboBox_Leave(object sender, EventArgs e)
        {
            currentGenre = genreComboBox.Text;      //Current genre is defined as string selected in the genreComboBox
            checkFieldsFilled();
        }
        private void artistTextBox_Leave(object sender, EventArgs e)
        {
            currentArtist = artistTextBox.Text;
            checkFieldsFilled();
        }
        private void albumTextBox_Leave(object sender, EventArgs e)
        {
            currentAlbum = albumTextBox.Text;
            checkFieldsFilled();
        }
        private void releaseMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(releaseMaskedTextBox.Text))
            {
                currentReleaseYear = Convert.ToInt16(releaseMaskedTextBox.Text);        //String representation of int converted to int unless empty
            }
            checkFieldsFilled();
        }
        private void runTimeMaskedTextBox_Leave(object sender, EventArgs e)
        {
            currentRunTime = runTimeMaskedTextBox.Text;
            checkFieldsFilled();
        }
        private void tracksUpDown_Leave(object sender, EventArgs e)
        {
            currentTracks = Convert.ToInt16(tracksUpDown.Value);        //Value associated with CD will be int, not decimal
            checkFieldsFilled();
        }
        private void locationTextBox_Leave(object sender, EventArgs e)
        {
            currentLocation = locationTextBox.Text;
            checkFieldsFilled();
        }
        private void addDataToListButton_Click(object sender, EventArgs e)
        {
            bool duplicateCD = false;
            foreach (CD cd in cdList)
            {
                if (currentArtist.Equals(cd.Artist) && currentAlbum.Equals(cd.Album))       //CD found to be duplicate if a CD in cdList has the same artist and album
                {
                    addDataButtonError.SetError(addDataToListButton, "CD of this name and artist already in library");
                    duplicateCD = true;
                    break;
                }
            }
            if (duplicateCD == false)       //CD will only be added if it is not found to be a duplicate
            {
                addDataButtonError.Clear();
                currentCD = new CD(currentGenre, currentArtist, currentAlbum, currentTracks, currentRunTime, currentLocation, currentReleaseYear);      //Creates new CD with current fields passed as args
                cdList.Add(currentCD);      //Current CD added to CD list. Next we would display this list in a list box
                saveToolStripMenuItem.Enabled = true;
            }
        }
        private void clearButton_Click(object sender, EventArgs e)      //Sets string fields to null and numerical fields to 0 on click
        {
            genreComboBox.Text = null;
            artistTextBox.Text = null;
            albumTextBox.Text = null;
            releaseMaskedTextBox.Text = null;
            runTimeMaskedTextBox.Text = null;
            tracksUpDown.Value = 0;
            locationTextBox.Text = null;
            currentGenre = null;
            currentArtist = null;
            currentAlbum = null;
            currentReleaseYear = 0;
            currentRunTime = null;
            currentTracks = 0;
            currentLocation = null;
            checkFieldsFilled();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)     //Makes fields visible and creates a new CD list. May be redundant in future
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
            clearButton.Visible = true;
            cdList = new List<CD>();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)        //Saves current cd list as a CSV file
        {
            if (saveCDList.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveCDList.FileName);
                foreach (CD cd in cdList)
                {
                    tw.Write(cd.Genre + ",");
                    tw.Write(cd.Artist + ",");
                    tw.Write(cd.Album + ",");
                    tw.Write(cd.Tracks + ",");
                    tw.Write(cd.RunTime + ",");
                    tw.Write(cd.Location + ",");
                    tw.Write(cd.ReleaseYear + "\n");
                }
                tw.Close();
            }
        }
    }
}
