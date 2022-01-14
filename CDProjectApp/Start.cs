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
    /// A form which appears on startup with buttons to add, load and view CDs.
    /// It has a cdList field which is defined when a list is loaded from a file
    /// </summary>
    public partial class Start : Form
    {
        List<CD> cdList;
        /// <summary>
        /// Constructor initialises the form and instantiates an empty list for CDs
        /// </summary>
        public Start()
        {
            InitializeComponent();
            cdList = new List<CD>();
        }
        /// <summary>
        /// Displays form to add a new CD to the library when the 'Add New CD' button is clicked.
        /// The loaded CD list is passed as an argument to the constructor
        /// </summary>
        /// <param name="sender">The Add New CD button</param>
        /// <param name="e">Empty</param>
        private void NewCDButton_Click(object sender, EventArgs e)
        {
            New newCD = new New(cdList);      //BUGFIX: Loaded cdList now accessible in other forms by passing it to constructors
            newCD.ShowDialog();
        }
        /// <summary>
        /// Displays an openFileDialog to select a CSV file to open which will populate cdList
        /// </summary>
        /// <param name="sender">The Load CD Library button</param>
        /// <param name="e">Empty</param>
        private void LoadCDsButton_Click(object sender, EventArgs e)
        {
            if (openCDList.ShowDialog() == DialogResult.OK)
            {
                TextReader tr = new StreamReader(openCDList.FileName);
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    string[] cdInfo = line.Split(',');      //Creates an array of strings from each line of CSV file to make a CD object
                    CD currentCD = new CD(cdInfo[0], cdInfo[1], cdInfo[2], Convert.ToInt16(cdInfo[3]), cdInfo[4], cdInfo[5], Convert.ToInt16(cdInfo[6]));
                    cdList.Add(currentCD);
                }
            }
        }
        /// <summary>
        /// Displays a form to view all the CDs which are currently in the library
        /// </summary>
        /// <param name="sender">The View My CDs button</param>
        /// <param name="e">Empty</param>
        public void ViewCDsButton_Click(object sender, EventArgs e)
        {
            View viewCD = new View(cdList);
            viewCD.ShowDialog();
        }
    }
}
