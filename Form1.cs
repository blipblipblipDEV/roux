using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeRoux_Click(object sender, EventArgs e)
        {
            txtConsole.AppendText(string.Format("Connecting to {0}...", txtUsername.Text) + Environment.NewLine);
            System.Threading.Thread.Sleep(2000);
            txtConsole.AppendText(string.Format("Preparing for injection...") + Environment.NewLine);
            System.Threading.Thread.Sleep(1500);
            txtConsole.AppendText(string.Format("Injecting packets...") + Environment.NewLine);
            System.Threading.Thread.Sleep(3000);
            txtConsole.AppendText(string.Format("Cleaning up injection traces...") + Environment.NewLine);
            System.Threading.Thread.Sleep(1600);
            txtConsole.AppendText(string.Format("Generating {0} Roux...", numRoux.Value) + Environment.NewLine);
            System.Threading.Thread.Sleep(3700);
            txtConsole.AppendText(string.Format("Adding {0} Roux for {1}...", numRoux.Value, txtUsername.Text) + Environment.NewLine);
            System.Threading.Thread.Sleep(3000);
            txtConsole.AppendText(string.Format("Cleaning up audit logs...") + Environment.NewLine);
            System.Threading.Thread.Sleep(500);
            txtConsole.AppendText(string.Format("Finalizing...") + Environment.NewLine);
            System.Threading.Thread.Sleep(2000);
            txtConsole.AppendText(string.Format("Successfully added {0} Roux! Enjoy!", numRoux.Value) + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtConsole.AppendText(string.Format("DONT CLICK THIS LABEL!") + Environment.NewLine);
         
        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
// txtConsole.AppendText(string.Format("Generating {0} roux for {1}...{2}", numRoux.Value, txtUsername.Text, Environment.NewLine));