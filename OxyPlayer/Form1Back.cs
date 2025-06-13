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
            DirectoryInfo ld = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
            FileInfo[] ldis = ld.GetFiles();
            Ldbc.updatadb(ld);
            foreach (FileInfo tldi in ldis)
            {
                if (Array.IndexOf(SupportedFormating, tldi.Extension) == -1)
                    continue;

                TreeNode ntn = new TreeNode();
                ntn.Text = tldi.Name;
                ntn.ToolTipText = tldi.FullName;
                treeView1.Nodes["NodeZ"].Nodes.Add(ntn);
            }
        }
        private void PlayMusic()
        {
            mp.Play();
            playing = true;
            pictureBoxPause.Image = OxyPlayer.Properties.Resources.Pause;
        }
        private void PlayMusic(string url)
        {
            mp.Open(new Uri(url));
            playing = true;
            pictureBoxPause.Image = OxyPlayer.Properties.Resources.Pause;
        }

        private void PauseMusic()
        {
            mp.Pause();
            playing = false;
            pictureBoxPause.Image = OxyPlayer.Properties.Resources.Play;
        }
    }
}
