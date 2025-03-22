using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;
using System.IO;
using System.Runtime;
using Windows;
using Microsoft;


namespace OxyPlayer
{
    public partial class Form1 : Form
    {
        MediaPlayer mp = new MediaPlayer();
        string[] SupportedFormating;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader SFsr=new StreamReader("SupportedFormating.txt");
            SupportedFormating= SFsr.ReadToEnd().Split(',','\r');
            SFsr.Close();
            timer1.Start();
            DirectoryInfo ld=new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            FileInfo[] ldis = ld.GetFiles();
            foreach (FileInfo tldi in ldis)
            {
                if (Array.IndexOf(SupportedFormating,tldi.Extension)==-1)
                    continue;

                TreeNode ntn = new TreeNode();
                ntn.Text = tldi.Name;
                ntn.ToolTipText = tldi.FullName;
                treeView1.Nodes["NodeZ"].Nodes.Add(ntn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mp.Pause();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mp.Stop();
            try
            {
                mp.Open(new Uri(treeView1.SelectedNode.ToolTipText));
                Musicinfo mi = MusicSh.GetMusicInfo(treeView1.SelectedNode.ToolTipText);
                TimeTrack.Maximum = mi.TimeLength_Second;
                mp.Play();
                labeltitle.Text =  mi.Title;
                labelartistalbum.Text = mi.Artist+" · "+mi.Album;
            }
            catch { }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTrack.Value = (int)mp.Position.TotalSeconds;
        }
    }
}
