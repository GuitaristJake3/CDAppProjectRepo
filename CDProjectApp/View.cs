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
    public partial class View : Form
    {
        List<CD> cdList;
        public View(List<CD> cds)
        {
            InitializeComponent();
            cdList = cds;
        }

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
