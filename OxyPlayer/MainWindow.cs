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
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Sunny.UI;
using Windows.UI;

namespace OxyPlayer
{
    public partial class MainWindow : Form
    {
        string[] SupportedFormating;
        public MainWindow()
        {
            InitializeComponent();
        }

        void rePaintControl()
        {
        }
        private void DrawTreeNode()
        {
            SupportedFormating = MusicSh.GetSupportedFormating();
            if (OxySettings.Default.MusicFolderPath == "")
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
            if (Ldbc.GetFileCount() != treeView1.Nodes["NodeZ"].Nodes.Count)
                Ldbc.updataSongsTable(ld);
        }

        /*   static public System.Drawing.Color RgbColor2Color(RgbColor rgbColor)
           {
               return System.Drawing.Color.FromArgb(rgbColor.ToArgb());
           }*/

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            DrawTreeNode();
        }
    }
}
