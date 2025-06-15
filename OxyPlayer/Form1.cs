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
using System.Diagnostics;
using System.Windows.Forms.Integration;
using LiteDB;


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

        private void pictureBoxPause_Click(object sender, EventArgs e)
        {
            if (playing)
                PauseMusic();
            else
                PlayMusic();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PlaySong(treeView1.SelectedNode.ToolTipText);
        }


        #region TimeTrack's Codes

        bool UserChangedValue = false;

        private void TimeTrackTimer_Tick(object sender, EventArgs e)
        {
            TimeTrackLine.Value = (int)mp.Position.TotalSeconds;
            UserChangedValue = false;
            TimeTrackText.Text = string.Format("{0} / {1}", MusicSh.Second2MMSS(mp.Position), MusicSh.Second2MMSS(mi.TimeLength_Second));
            try
            {
                richTextBox1.Text = mi.lrcsheet[(int)mp.Position.TotalSeconds];
            }
            catch { }
        }

        private void TimeTrack_MouseDown(object sender, MouseEventArgs e)
        {
            TimeTrackTimer.Stop();
        }

        private void TimeTrack_ValueChanged(object sender, EventArgs e)
        {
            UserChangedValue = true;
            if (TimeTrackLine.Value >= TimeTrackLine.Maximum)
                pictureBoxNext_Click(new object(), new EventArgs());
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
            mp.Volume = VolumeTrackBar.Value / 100.0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ImageViewer iv = new ImageViewer(mi.Cover);
            iv.Show();
        }

        private void musicTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = @".\MusicTag\MusicTag.exe";
            p.StartInfo.Arguments = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            p.Start();
        }

        private void klabel_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            Form2 f = new Form2(l.Name.Substring(5), l.Text);
            f.Show();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            Song nextsong = null;
            using (var ldb = new LiteDatabase("songs.db"))
            {

                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                int dbcount = table.Count();
                int nextid = mi.Id + 1;
                if (nextid > dbcount)
                    nextid = 1;
                IEnumerable<Song> i = table.Find(x => x.Id == nextid);
                nextsong = i.ToArray<Song>()[0];

            }
            PlaySong(nextsong.Address);
        }

        private void 搜索歌曲SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void 更新数据库UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ldbc.updatadb(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
            MessageBox.Show("更新完成", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxBefore_Click(object sender, EventArgs e)
        {
            Song beforesong = null;
            using (var ldb = new LiteDatabase("songs.db"))
            {

                ILiteCollection<Song> table = ldb.GetCollection<Song>("songs");
                int dbcount = table.Count();
                int nextid = mi.Id -1;
                if (nextid <= 0)
                    nextid = table.Count();
                IEnumerable<Song> i = table.Find(x => x.Id == nextid);
                beforesong = i.ToArray<Song>()[0];

            }
            PlaySong(beforesong.Address);
        }
    }
}

