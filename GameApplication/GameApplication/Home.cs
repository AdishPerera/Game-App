using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApplication
{
    public partial class form_GameApplication : Form
    {
        public form_GameApplication()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("This system is created by NIBM Team....", "NIBM Team ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
                System.Windows.Forms.Application.Exit();
                //this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void toolStripMenuItem_FindShortestPath_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_FindShortestPath nxtform = new form_FindShortestPath();
            nxtform.Show();
        }

        private void toolStripMenuItem_IdentifyMinimumConnectors_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_IdentifyMinimumConnectors nxtform = new form_IdentifyMinimumConnectors();
            nxtform.Show();
        }

        private void toolStripMenuItem_KnapsackProblem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_KnapsackProblem nxtform = new form_KnapsackProblem();
            nxtform.Show();
        }

        private void form_GameApplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            System.Windows.Forms.Application.Exit(); 
        }
    }
}
