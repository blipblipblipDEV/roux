using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            
         
        }

        private void txtConsole_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void visit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.roblox.com");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtConsole.AppendText(string.Format("party blob") + Environment.NewLine);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void getRouxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtConsole.AppendText(string.Format("Getting Secret ROUX...") + Environment.NewLine);
            System.Threading.Thread.Sleep(2000);
            txtConsole.AppendText(string.Format("Done! You now have secret ROUX! (a.k.a. infinite roux)") + Environment.NewLine);
        }

        private void fortniteIsCringeTiktokIsCringierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtConsole.AppendText(string.Format("ERROR: V-BUCK is not a resource in this current context. Did you mean ROUX-REWARD?") + Environment.NewLine);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
// txtConsole.AppendText(string.Format("Generating {0} roux for {1}...{2}", numRoux.Value, txtUsername.Text, Environment.NewLine));