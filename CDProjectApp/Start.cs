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

        private void loadCDsButton_Click(object sender, EventArgs e)        //Opens a dialog to open a CSV file of CD information
        {
            if (openCDList.ShowDialog() == DialogResult.OK)
            {
                TextReader tr = new StreamReader(openCDList.FileName);
                Console.WriteLine(tr.ReadToEnd());
                
            }
        }

        private void viewCDsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
