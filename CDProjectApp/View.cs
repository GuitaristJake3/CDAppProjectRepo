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
    /// <summary>
    /// A form to view all the CDs in the library using a listView.
    /// It has a cdList field which is defined by the constructor
    /// </summary>
    public partial class View : Form
    {
        List<CD> cdList;
        /// <summary>
        /// Constructor initialises the form and takes a parameter that is the loaded list of CDs
        /// </summary>
        /// <param name="cds">The list of CDs that was loaded on the Start form</param>
        public View(List<CD> cds)
        {
            InitializeComponent();
            cdList = cds;
        }
        /// <summary>
        /// Displays each CD read from the CSV file in a listView when the form displays
        /// </summary>
        /// <param name="sender">This form</param>
        /// <param name="e">Empty</param>
        private void View_Shown(object sender, EventArgs e)
        {
            foreach (CD cd in cdList)
            {
                ListViewItem currentCD = new ListViewItem();
                currentCD.SubItems.Add(cd.Genre);
                currentCD.SubItems.Add(cd.Artist);
                currentCD.SubItems.Add(cd.Album);
                currentCD.SubItems.Add(cd.ReleaseYear.ToString());
                currentCD.SubItems.Add(cd.RunTime);
                currentCD.SubItems.Add(cd.Tracks.ToString());
                currentCD.SubItems.Add(cd.Location);
                cdListView.Items.Add(currentCD);
            }
        }
    }
}
