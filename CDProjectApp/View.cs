using System;
using System.Collections.Generic;
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
        List<CD> selectedCDs;
        List<ListViewItem> selectedItems;
        /// <summary>
        /// Constructor initialises the form and takes a parameter that is the loaded list of CDs
        /// </summary>
        /// <param name="cds">The list of CDs that was loaded on the Start form</param>
        public View(List<CD> cds)
        {
            InitializeComponent();
            cdList = cds;
            selectedCDs = new List<CD>();
            selectedItems = new List<ListViewItem>();
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
                selectedCDs.Add(new CD(e.Item.SubItems[1].Text, e.Item.SubItems[2].Text, e.Item.SubItems[3].Text, Convert.ToInt16(e.Item.SubItems[4].Text),
                e.Item.SubItems[5].Text, e.Item.SubItems[7].Text, Convert.ToInt16(e.Item.SubItems[6].Text)));
                selectedItems.Add(e.Item);
            }
            else
            {
                selectedItems.Remove(e.Item);
                foreach (CD cd in selectedCDs)
                {
                    if (cd.Artist == e.Item.SubItems[2].Text && cd.Album == e.Item.SubItems[3].Text)
                    {
                        selectedCDs.Remove(cd);
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// Removes selected CD from cdList and the CD listView
        /// </summary>
        /// <param name="sender">The Delete CD button</param>
        /// <param name="e">Empty</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (CD selectedCD in selectedCDs)
            {
                foreach (CD cd in cdList)
                {
                    if (cd.Artist == selectedCD.Artist && cd.Album == selectedCD.Album)
                    {
                        cdList.Remove(cd);
                        break;
                    }
                }
            }   
            foreach (ListViewItem selectedItem in selectedItems)
            {
                cdListView.Items.Remove(selectedItem);
            }
        }
    }
}
