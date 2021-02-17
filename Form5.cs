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
using ShadowCheats;
using XFORCE.ZeusX;
using System.IO;

        
namespace XFORCE
{
    public partial class Form5 : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        ShadowCheats.Module ShadowCheatsDemo = new ShadowCheats.Module();
        OxygenU_API.Client OxygenU_API = new OxygenU_API.Client();
        private Point lastPoint;

        public Form5()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://direct-link.net/196154/TheBestExploit");
        }

        private void gunaWinSwitch3_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void gunaWinSwitch2_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            TopMost.ToString();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaWinSwitch2_CheckedChanged_1(object sender, EventArgs e)
        {
            OxygenU_API.KillRoblox();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://direct-link.net/196154/TheBestExploit");
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://aitor911.wixsite.com/the-best-exploits");
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry but it won't be available until the next update", "XFORCE");
        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            apis.api = "ZeusX";
            krnl.Checked = false;
            electron.Checked = false;
            sirhurt.Checked = false;
        }

        private void guna2CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            apis.api = "KRNL";
            zeus.Checked = false;
            electron.Checked = false;
            sirhurt.Checked = false;
        }

        private void guna2CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            apis.api = "Electron";
            zeus.Checked = false;
            krnl.Checked = false;
            electron.Checked = false;
            sirhurt.Checked = false;
        }

        private void guna2CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            apis.api = "Sirhurt";
            zeus.Checked = false;
            krnl.Checked = false;
            electron.Checked = false;
        }
    }
}
