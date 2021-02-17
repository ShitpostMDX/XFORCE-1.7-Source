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
using FastColoredTextBoxNS;
using System.IO;

namespace XFORCE
{
    public partial class Form7 : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        ShadowCheats.Module ShadowCheatsDemo = new ShadowCheats.Module();
        OxygenU_API.Client OxygenU_API = new OxygenU_API.Client();
        public Form7()
        {
            InitializeComponent();

            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("795348433711005787", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("795348433711005787", ref this.handlers, true, null);
            this.presence.details = "XFORCE Beta";
            this.presence.state = "https://discord.gg/Fkz4tK8XFn";
            this.presence.largeImageKey = "monobrasil";
            this.presence.smallImageKey = "";
            this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            //fastColoredTextBox1.Clear();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
          //  module.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void flatButton2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void flatButton1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void flatButton4_Click_1(object sender, EventArgs e)
        {
            //fastColoredTextBox1.Clear();
        }

        private DiscordRpc.EventHandlers handlers;

        // Token: 0x04000002 RID: 2
        private DiscordRpc.RichPresence presence;

        public object RichTextBox2 { get; private set; }
        public object RichTextBox1 { get; private set; }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Move(object sender, EventArgs e)
        {

        }

        private void flatButton3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/qyfgNpB5Vv"); 
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCpvpa7I4fs7MZjG5-T_9urg"); //xd
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void bunifuImageButton5_Click_1(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
 
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            //fastColoredTextBox1.Clear();
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (apis.api == "ZeusX")
            {
                FastColoredTextBox fastColoredTextBox1
           =
            this.tabControl1.SelectedTab.Controls.Find
           ("fastColoredTextBox1", true).FirstOrDefault<Control>()
           as FastColoredTextBox;
                object[] args = new string[0];
                object obj = fastColoredTextBox1.Text;
                string script = obj.ToString();
                NamedPipes.LuaPipe(script);
            }
            if (apis.api == "Sirhurt")
            {
                FastColoredTextBox fastColoredTextBox1
           =
            this.tabControl1.SelectedTab.Controls.Find
           ("fastColoredTextBox1", true).FirstOrDefault<Control>()
           as FastColoredTextBox;
                object[] args = new string[0];
                object obj = fastColoredTextBox1.Text;
                string script = obj.ToString();
                SirHurtAPI.SirHurtAPI.Execute(script, true);

            }
            if (apis.api == "Electron")
            {
                FastColoredTextBox fastColoredTextBox1
           =
            this.tabControl1.SelectedTab.Controls.Find
           ("fastColoredTextBox1", true).FirstOrDefault<Control>()
           as FastColoredTextBox;
                object[] args = new string[0];
                object obj = fastColoredTextBox1.Text;
                string script = obj.ToString();
                Electron.NamedPipes.LuaPipe(script);

            }
            if (apis.api == "KRNL")
            {
                FastColoredTextBox fastColoredTextBox1
           =
            this.tabControl1.SelectedTab.Controls.Find
           ("fastColoredTextBox1", true).FirstOrDefault<Control>()
           as FastColoredTextBox;
                object[] args = new string[0];
                object obj = fastColoredTextBox1.Text;
                string script = obj.ToString();
                MainAPI.Execute(script);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FastColoredTextBox fastColoredTextBox1
         =
         this.tabControl1.SelectedTab.Controls.Find
         ("fastColoredTextBox1", true).FirstOrDefault<Control>()
         as FastColoredTextBox;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "|Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt| All Files (*.)|*.";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Title = "Open File";
            openFileDialog.RestoreDirectory = true;
            bool flag = openFileDialog.ShowDialog() != DialogResult.OK;
            if (!flag)
            {
                try
                {
                    fastColoredTextBox1.Text = "";
                    Stream stream;
                    bool flag2 = (stream = openFileDialog.OpenFile()) == null;
                    if (!flag2)
                    {
                        using (stream)
                        {
                            fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Debug :" + ex.Message, "Unexpected Error");
                }
            }
        }


        private void fastColoredTextBox2_Load(object sender, EventArgs e)
        {
           
        }

        private void fastColoredTextBox3_Load(object sender, EventArgs e)
        {
            
        }

        private void fastColoredTextBox4_Load(object sender, EventArgs e)
        {
        
        }

        private void fastColoredTextBox5_Load(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que quieres salir?", "XFORCE");
            Application.Exit();
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void bunifuFlatButton4_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "XFORCE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bunifuFlatButton3_Click_2(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("It is a very powerful api so when you give ATTACH it will give you an error or something like that but just wait for it to load", "Krnl"); 
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("Its like KRNL but without key", "XFORCE");
        }

        private void bunifuFlatButton5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry but it won't be available until the next update", "XFORCE");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Code newTab = new Code();
            string title = "Script" + (tabControl1.TabCount + 1) + ".lua".ToString();
            TabPage tab = new TabPage();
            tab.Text = title.ToString();
            newTab.Dock = DockStyle.Fill;
            tab.Controls.Add(newTab);
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            Functions.ListBox(this.ListBox1, "./scripts", "*.txt");
            Functions.ListBox(this.ListBox1, "./scripts", "*.lua");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Code newTab = new Code();
            string title = "Script" + (tabControl1.TabCount + 1) + ".lua".ToString();
            TabPage tab = new TabPage();
            tab.Text = title.ToString();
            newTab.Dock = DockStyle.Fill;
            tab.Controls.Add(newTab);
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
        }

        private void notabchecker_Tick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1)
            {
                Code newTab = new Code();
                string title = "Script1.lua".ToString();
                TabPage tab = new TabPage();
                tab.Text = title.ToString();
                newTab.Dock = DockStyle.Fill;
                tab.Controls.Add(newTab);
                tabControl1.Controls.Add(tab);
                tabControl1.SelectTab(tabControl1.TabCount - 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 options = new Form5();
            options.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (apis.api == "ZeusX")
            {
                ZeusX.Functions.Inject();
            }
            if (apis.api == "Sirhurt")
            {
                SirHurtAPI.SirHurtAPI.LaunchExploit();

            }
            if (apis.api == "Electron")
            {
                Electron.Functions.Inject();

            }
            if (apis.api == "KRNL")
            {
                MainAPI.Inject();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FastColoredTextBox fastColoredTextBox1
           =
           this.tabControl1.SelectedTab.Controls.Find
           ("fastColoredTextBox1", true).FirstOrDefault<Control>()
           as FastColoredTextBox;
            fastColoredTextBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


