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
        List<CD> cdList;        //List of objects of the class CD is declared as class variable
        public Start()
        {
            InitializeComponent();
            cdList = new List<CD>();        //The list is created on program startup
        }

        private void newCDButton_Click(object sender, EventArgs e)      //Opens form to add a new CD on click
        {
            CDLibrary newCD = new CDLibrary();
            newCD.ShowDialog();
        }

        private void loadCDsButton_Click(object sender, EventArgs e)        //Opens a dialog to open a CSV file of CD information
        {
            if (openCDList.ShowDialog() == DialogResult.OK)
            {
                TextReader tr = new StreamReader(openCDList.FileName);
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    string[] cdInfo = line.Split(',');
                    CD currentCD = new CD(cdInfo[0], cdInfo[1], cdInfo[2], Convert.ToInt16(cdInfo[3]), cdInfo[4], cdInfo[5], Convert.ToInt16(cdInfo[6]));
                    cdList.Add(currentCD);
                }
            }
        }

        private void viewCDsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
