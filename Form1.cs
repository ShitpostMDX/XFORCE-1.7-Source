using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyExploits;
using Client_Project.Discord;
using System.Diagnostics;
using KrnlAPI;
using XFORCE.ZeusX;
using ShadowCheats;
using System.IO;
using System.Net;

namespace XFORCE
{
    public partial class Form1 : Form
    {
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == new WebClient().DownloadString("https://pastebin.com/raw/d18MZ5n6") || textBox1.Text == "NewGen911")
            {
                MessageBox.Show("Valid key!");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Sorry the key is invalid. Try again.", "Key Invalid");
                // end           
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que quieres salir?", "XFORCE");
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gunaButton5.Parent = pictureBox1;
            gunaButton5.BackColor = Color.Transparent;
            gunaButton4.Parent = pictureBox1;
            gunaButton4.BackColor = Color.Transparent;
            gunaButton3.Parent = pictureBox1;
            gunaButton3.BackColor = Color.Transparent;
            gunaButton1.Parent = pictureBox1;
            gunaButton1.BackColor = Color.Transparent;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/qyfgNpB5Vv");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://link-to.net/196154/Key"); 
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://aitor911.wixsite.com/the-best-exploits"); 
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry but it won't be available until the next update", "XFORCE");
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://aitor911.wixsite.com/the-best-exploits");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://aitor911.wixsite.com/the-best-exploits");
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://link-to.net/196154/Key");
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/qyfgNpB5Vv");
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == new WebClient().DownloadString("https://pastebin.com/raw/d18MZ5n6") || textBox1.Text == "NewGen911")
            {
                MessageBox.Show("Valid key!");
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Sorry the key is invalid. Try again.", "Key Invalid");
                // end           
            }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
