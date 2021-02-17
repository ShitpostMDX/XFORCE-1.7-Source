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
using XFORCE.ZeusX;
using KrnlAPI;
using ShadowCheats;
using System.IO;

namespace XFORCE
{
    public partial class Form3 : Form

    {
        EasyExploits.Module module = new EasyExploits.Module();
        ShadowCheats.Module ShadowCheatsDemo = new ShadowCheats.Module();
        OxygenU_API.Client OxygenU_API = new OxygenU_API.Client();

    private Point lastPoint;

        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox2.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox2.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox2.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox2.Text);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox3.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox3.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox3.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox3.Text);
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox1.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox1.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox1.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox1.Text);
            }
        }

        private void fastColoredTextBox10_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E to open gui", "Vietnam");
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox11.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox11.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox11.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox11.Text);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox4.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox4.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox4.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox4.Text);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                MessageBox.Show("Please use the api Krnl", "XFORCE");
                NamedPipes.LuaPipe(fastColoredTextBox5.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox5.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox5.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox5.Text);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox6.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox6.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox6.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox6.Text);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox7.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox7.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox7.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox7.Text);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox8.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox8.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox8.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox8.Text);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox9.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox9.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox9.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox9.Text);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox10.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox10.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox10.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox10.Text);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox12.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox12.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox12.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox12.Text);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox13.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox13.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox13.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox13.Text);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox14.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox14.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox14.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox14.Text);
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                NamedPipes.LuaPipe(fastColoredTextBox15.Text);
            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Execute(fastColoredTextBox15.Text);
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Execute(fastColoredTextBox15.Text);
            }
            if (checkBox1.Checked == true)
            {
                module.ExecuteScript(fastColoredTextBox15.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using XFORCE!");
            if (checkBox4.Checked == true)
            {

            }
            if (checkBox3.Checked == true)
            {
                OxygenU_API.Attach();
            }
            if (checkBox2.Checked == true)
            {
                MainAPI.Inject();
            }
            if (checkBox1.Checked == true)
            {
                module.LaunchExploit();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("It is a very powerful api so when you give ATTACH it will give you an error or something like that but just wait for it to load", "Krnl");
        }

        private void fastColoredTextBox5_Load(object sender, EventArgs e)
        {

        }
    }
}
