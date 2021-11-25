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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void newCDButton_Click(object sender, EventArgs e)
        {
            CDLibrary newCD = new CDLibrary();      //Opens form to add a new CD on click
            newCD.ShowDialog();
        }

        private void loadCDsButton_Click(object sender, EventArgs e)
        {

        }

        private void viewCDsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
