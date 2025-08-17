using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ookii.Dialogs.WinForms;

namespace OxyPlayer
{
    public partial class Setting : Form
    {

        public delegate void RefreshHandler();
        public event RefreshHandler Refresh;
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            button1.BackColor = OxySettings.Default.DesktopLyricsColor;
            button2.Text = OxySettings.Default.DesktopLyricsFont.Name;
            colorDialog1.Color = button1.BackColor;
            fontDialog1.Font = OxySettings.Default.DesktopLyricsFont;
            richTextBox1.ForeColor = colorDialog1.Color;
            richTextBox1.Font = fontDialog1.Font;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
            button2.Text = fontDialog1.Font.Name;
            OxySettings.Default.DesktopLyricsFont = fontDialog1.Font;
            OxySettings.Default.Save();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
            richTextBox1.ForeColor = colorDialog1.Color;
            OxySettings.Default.DesktopLyricsColor = colorDialog1.Color;
            OxySettings.Default.Save();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            OxySettings.Default.Opacity = ((double)numericUpDown1.Value / 100.0);
            OxySettings.Default.ShowStartup = checkBox1.Checked;
            OxySettings.Default.Save();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog vfbd = new VistaFolderBrowserDialog();
            vfbd.SelectedPath = OxySettings.Default.MusicFolderPath;
            vfbd.ShowDialog();
            if(vfbd.SelectedPath!=OxySettings.Default.MusicFolderPath)
            {
                OxySettings.Default.MusicFolderPath = vfbd.SelectedPath;
                OxySettings.Default.Save();
                textBox1.Text = OxySettings.Default.MusicFolderPath;
                Refresh();
            }
        }

        
    }
}
