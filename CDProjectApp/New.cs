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
    /// <summary>
    /// A form to add a new CD to the library using various controls.
    /// It has fields for each variable that will be used to make a new CD object.
    /// It has a field for the current CD being created.
    /// It has a cdList field which is defined by the constructor
    /// </summary>
    public partial class New : Form
    {
        string currentGenre, currentArtist, currentAlbum, currentRunTime, currentLocation;
        int currentReleaseYear, currentTracks;
        CD currentCD;
        List<CD> cdList;
        /// <summary>
        /// Constructor initialises the form and takes a parameter that is the loaded list of CDs
        /// </summary>
        /// <param name="cds">The list of CDs that was loaded on the Start form</param>
        public New(List<CD> cds)
        {
            InitializeComponent();
            cdList = cds;
        }
        /// <summary>
        /// Enables the 'Add Data' button once all form fields have a value which is not null.
        /// The release year must be a 4 digit integer, the run time must have the format 00:00 and the number of tracks must be > 0
        /// </summary>
        private void CheckFieldsFilled()
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
        /// <summary>
        /// currentGenre is defined as string selected in genreComboBox upon losing focus
        /// </summary>
        /// <param name="sender">The genere comboBox</param>
        /// <param name="e">Empty</param>
        private void GenreComboBox_Leave(object sender, EventArgs e)
        {
            currentGenre = genreComboBox.Text;
            CheckFieldsFilled();
        }
        /// <summary>
        /// currentArtist is defined as string in artistTextBox upon losing focus
        /// </summary>
        /// <param name="sender">The artist textBox</param>
        /// <param name="e">Empty</param>
        private void ArtistTextBox_Leave(object sender, EventArgs e)
        {
            currentArtist = artistTextBox.Text;
            CheckFieldsFilled();
        }
        /// <summary>
        /// currentAlbum is defined as string in albumTextBox upon losing focus
        /// </summary>
        /// <param name="sender">The album textBox</param>
        /// <param name="e">Empty</param>
        private void AlbumTextBox_Leave(object sender, EventArgs e)
        {
            currentAlbum = albumTextBox.Text;
            CheckFieldsFilled();
        }
        /// <summary>
        /// currentReleaseYear is defined as integer in releaseMaskedTextBox upon losing focus
        /// </summary>
        /// <param name="sender">The realease year maskedTextBox</param>
        /// <param name="e">Empty</param>
        private void ReleaseMaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(releaseMaskedTextBox.Text))
            {
                currentReleaseYear = Convert.ToInt16(releaseMaskedTextBox.Text);        //String representation of int converted to int unless empty
            }
            CheckFieldsFilled();
        }
        /// <summary>
        /// currentRunTime is defined as string in runTimeMaskedTextBox upon losing focus
        /// </summary>
        /// <param name="sender">The run time maskedTextBox</param>
        /// <param name="e">Empty</param>
        private void RunTimeMaskedTextBox_Leave(object sender, EventArgs e)
        {
            currentRunTime = runTimeMaskedTextBox.Text;
            CheckFieldsFilled();
        }

        private void newLabel_Click(object sender, EventArgs e)
        {

        }

        private void New_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// currentTracks is defined as integer in tracksUpDown upon losing focus
        /// </summary>
        /// <param name="sender">The number of tracks numericUpDown</param>
        /// <param name="e">Empty</param>
        private void TracksUpDown_Leave(object sender, EventArgs e)
        {
            currentTracks = Convert.ToInt16(tracksUpDown.Value);        //Value associated with CD will be int, not decimal
            CheckFieldsFilled();
        }
        /// <summary>
        /// currentLocation is defined as string in location TextBox upon losing focus
        /// </summary>
        /// <param name="sender">The location textBox</param>
        /// <param name="e">Empty</param>
        private void LocationTextBox_Leave(object sender, EventArgs e)
        {
            currentLocation = locationTextBox.Text;
            CheckFieldsFilled();
        }
        /// <summary>
        /// Creates a currentCD object and adds it to cdList if it is not found to be a duplicate when clicked.
        /// This enables saveToolStripMenuItem
        /// </summary>
        /// <param name="sender">The Add Data button</param>
        /// <param name="e">Empty</param>
        private void AddDataToListButton_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Controls and fields are all set to null or 0 when clicked
        /// </summary>
        /// <param name="sender">The Clear button</param>
        /// <param name="e">Empty</param>
        private void ClearButton_Click(object sender, EventArgs e)      //Sets string fields to null and numerical fields to 0 on click
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
            CheckFieldsFilled();
        }
        /// <summary>
        /// Displays a saveFileDialog to save the current cdList field to a CSV file
        /// </summary>
        /// <param name="sender">The Save toolStripMenuItem</param>
        /// <param name="e">Empty</param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)        //Saves current cd list as a CSV file
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
