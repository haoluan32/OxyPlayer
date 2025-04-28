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
using Id3;


namespace OxyPlayer
{
    public partial class Form1 : Form
    {
        MediaPlayer mp = new MediaPlayer();
        Musicinfo mi;
        bool playing = false;
        string[] SupportedFormating;
        TreeNode PlayingTreeNode = new TreeNode();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            

            DrawTreeNode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playing)
                PauseMusic();
            else
                PlayMusic();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mp.Stop();
            
            try
            {
                PlayMusic(treeView1.SelectedNode.ToolTipText);
                mi = MusicSh.GetMusicInfo(treeView1.SelectedNode.ToolTipText);
                TimeTrackLine.Maximum = mi.TimeLength_Second;
                PlayingTreeNode = treeView1.SelectedNode;

                PlayMusic();
                labeltitle.Text =  mi.Title;
                labelartistalbum.Text = mi.Artist + " · " + mi.Album;
                pictureBox1.Image = mi.Cover;
                TimeTrackTimer.Start();
            }
            catch { }
            
        }

        

        #region TimeTrack's Codes

        bool UserChangedValue = false;

        private void TimeTrackTimer_Tick(object sender, EventArgs e)
        {
            TimeTrackLine.Value = (int)mp.Position.TotalSeconds;
            UserChangedValue = false;
            TimeTrackText.Text = string.Format("{0} / {1}", MusicSh.Second2MMSS(mp.Position), MusicSh.Second2MMSS(mi.TimeLength_Second));
        }

        private void TimeTrack_MouseDown(object sender, MouseEventArgs e)
        {
            TimeTrackTimer.Stop();
        }

        private void TimeTrack_ValueChanged(object sender, EventArgs e)
        {
            UserChangedValue = true;
        }

        private void TimeTrack_MouseUp(object sender, MouseEventArgs e)
        {
            if (UserChangedValue)
            {
                mp.Pause();
                mp.Position = new TimeSpan(0, 0, TimeTrackLine.Value);
                mp.Play();
            }
            TimeTrackTimer.Start();
        }
        #endregion

        private void VolumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            mp.Volume = VolumeTrackBar.Value/100.0;
        }

        

        
    }
}
