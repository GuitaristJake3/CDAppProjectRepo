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
    public partial class Form1 : Form
    {
        string currentGenre, currentArtist, currentAlbum, currentReleaseYear, currentRunTime, currentTracks, currentLocation;
        CDDataClass currentCD;
        List<CDDataClass> cdList;   //List of objects of the class CDDataClass is defined as class variable
        public Form1()
        {
            InitializeComponent();
            cdList = new List<CDDataClass>();   //The list is created on program startup
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentGenre = genreComboBox.Items[genreComboBox.SelectedIndex].ToString();     //Current genre is whatever is selected in the genreComboBox
        }

        private void addDataToListButton_Click(object sender, EventArgs e)
        {
            currentCD = new CDDataClass(currentGenre);      //Creates new CD with current fields passed as args
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
            cdList = new List<CDDataClass>();
            genreComboBox.SelectedIndex = 0;    //First item in range of genreComboBox values will be the initial value
        }
    }
}
