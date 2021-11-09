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
            CDLibrary newCD = new CDLibrary();
            newCD.ShowDialog();
        }
    }
}
