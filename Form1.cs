using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loadForm lF = new loadForm();
            lF.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
        
        private void headerLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
