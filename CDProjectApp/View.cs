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
        CD selectedCD;
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
                string[] cdInfo = { null, cd.Genre, cd.Artist, cd.Album, cd.ReleaseYear.ToString(), cd.RunTime, cd.Tracks.ToString(), cd.Location };
                ListViewItem currentCD = new ListViewItem(cdInfo);
                cdListView.Items.Add(currentCD);
            }
        }
        /// <summary>
        /// Selects a CD from the cdList based on the listView item that was checked
        /// </summary>
        /// <param name="sender">The CD listView</param>
        /// <param name="e">Data for the checked item</param>
        private void CDListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == true)
            {
                selectedCD = new CD(e.Item.SubItems[1].Text, e.Item.SubItems[2].Text, e.Item.SubItems[3].Text, Convert.ToInt16(e.Item.SubItems[4].Text),
                e.Item.SubItems[5].Text, e.Item.SubItems[7].Text, Convert.ToInt16(e.Item.SubItems[6].Text));
            }
            else
            {
                selectedCD = null;
            }
        }
    }
}
