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

        bool selectedrefresh=false;
        public Setting()
        {
            InitializeComponent();
        }

        private void refreshFloderList()
        {
            treeView1.Nodes.Clear();
            foreach (Floder floder in Ldbc.getAllMusicFloders())
            {
                TreeNodeWithFloder newNode = new TreeNodeWithFloder();
                newNode.Floder = floder;
                newNode.Text = floder.Path;
                treeView1.Nodes.Add(newNode);
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            button1.BackColor = OxySettings.Default.DesktopLyricsColor;
            button2.Text = OxySettings.Default.DesktopLyricsFont.Name;

            richTextBox1.ForeColor = colorDialog1.Color;
            richTextBox1.Font = fontDialog1.Font;

            button4.BackColor = OxySettings.Default.MainWindowLyricsColor;
            button5.Text = OxySettings.Default.MainWindowsLyricsFont.Name;

            richTextBox2.ForeColor = OxySettings.Default.MainWindowLyricsColor;
            richTextBox2.Font = OxySettings.Default.MainWindowsLyricsFont;

            if (AppInfo.Default.IsTesing)  
                labelVersion.Text = $"版本 {AppInfo.Default.VersionFull}"; 
            else
                labelVersion.Text = $"版本 {AppInfo.Default.Version}";

            labelPreflex.Text = $"发布通道 {AppInfo.Default.VersionPrefix}";
            refreshFloderList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = OxySettings.Default.DesktopLyricsFont;
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
            colorDialog1.Color = button1.BackColor;
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
            OxySettings.Default.ExitWhenFormClosing = checkBox2.Checked;
            OxySettings.Default.Save();
            Refresh();
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
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button4.BackColor;
            colorDialog1.ShowDialog();
            button4.BackColor = colorDialog1.Color;
            richTextBox2.ForeColor = colorDialog1.Color;
            OxySettings.Default.DesktopLyricsColor = colorDialog1.Color;
            OxySettings.Default.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = OxySettings.Default.MainWindowsLyricsFont;
            fontDialog1.ShowDialog();
            richTextBox2.Font = fontDialog1.Font;
            button5.Text = fontDialog1.Font.Name;
            OxySettings.Default.MainWindowsLyricsFont = fontDialog1.Font;
            OxySettings.Default.Save();
        }

        private void transfer1_TransferChanged(object sender, AntdUI.Transfer.TransferEventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            vistaFolderBrowserDialog1.ShowDialog();
            textBoxFolderPath.Text = vistaFolderBrowserDialog1.SelectedPath;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedrefresh = true;
            checkBoxEnableFloder.Checked = ((TreeNodeWithFloder)treeView1.SelectedNode).Floder.enabled;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ldbc.addMusicFlodersTable(textBoxFolderPath.Text);
            textBoxFolderPath.Text = "";
            refreshFloderList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ldbc.delMusicFlodersTable(((TreeNodeWithFloder)treeView1.SelectedNode).Floder.Path);
            refreshFloderList();
        }

        private void checkBoxEnableFloder_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedrefresh==false)
            {
                Ldbc.setMusicFloderEnable(((TreeNodeWithFloder)treeView1.SelectedNode).Floder.Path, checkBoxEnableFloder.Checked);
                refreshFloderList();
            }
            else
            { selectedrefresh = false; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextViewer tv = new TextViewer("LICENSE");
            tv.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextViewer tv = new TextViewer("NOTICE");
            tv.ShowDialog();
        }
    }

    class TreeNodeWithFloder : TreeNode
    {
        public Floder Floder { get; set; }
    }
}
