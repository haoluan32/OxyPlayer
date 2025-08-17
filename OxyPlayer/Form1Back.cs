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
    partial class Form1
    {
        private void DrawTreeNode()
        {
            SupportedFormating = MusicSh.GetSupportedFormating();
            if(OxySettings.Default.MusicFolderPath=="")
            {
                OxySettings.Default.MusicFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                OxySettings.Default.Save();
            }
            DirectoryInfo ld = new DirectoryInfo(OxySettings.Default.MusicFolderPath);

            FileInfo[] ldis = ld.GetFiles();
            treeView1.Nodes["NodeZ"].Nodes.Clear();
            foreach (FileInfo tldi in ldis)
            {
                if (Array.IndexOf(SupportedFormating, tldi.Extension) == -1)
                    continue;

                TreeNode ntn = new TreeNode();
                ntn.Text = tldi.Name;
                ntn.ToolTipText = tldi.FullName;
                treeView1.Nodes["NodeZ"].Nodes.Add(ntn);
            }
            if (OxySettings.Default.FileCount != treeView1.Nodes["NodeZ"].Nodes.Count||!File.Exists("songs.db"))
                Ldbc.updataSongsTable(ld);
        }
        private void PlaySong(string songad)
        {
            mp.Stop();
            
            try
            {
                mi = MusicSh.GetMusicInfo(songad);

                PlayMusic(songad);
                PlayMusic();

                
                TimeTrackLine.Maximum = mi.TimeLength_Second;
                PlayingTreeNode = treeView1.SelectedNode;


                labelTitle.Text = mi.Title;
                labelArtist.Text = mi.Artist;
                labelAlbum.Text = mi.Album;
                pictureBox1.Image = mi.Cover;
                TimeTrackTimer.Start();
                lyricsBox1.Text = mi.lyric;
                this.Text = mi.Title + " - OxyPlayer";
            }
            catch { }
        }

        private void PlayMusic()
        {
            mp.Play();
            playing = true;
            pictureBoxPause.Image = OxyPlayer.Properties.Resources.Pause;
            dl.pictureBox2.Image = OxyPlayer.Properties.Resources.Pause;
        }
        private void PlayMusic(string url)
        {
            mp.Open(new Uri(url));
            playing = true;
            pictureBoxPause.Image = OxyPlayer.Properties.Resources.Pause;
            dl.pictureBox2.Image = OxyPlayer.Properties.Resources.Pause;

        }

        private void PauseMusic()
        {
            mp.Pause();
            playing = false;
            pictureBoxPause.Image = OxyPlayer.Properties.Resources.Play;
            dl.pictureBox2.Image = OxyPlayer.Properties.Resources.Play;

        }
    }
}
