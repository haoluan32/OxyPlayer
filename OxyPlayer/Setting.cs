using Ookii.Dialogs.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OxyPlayer
{
    public partial class Setting : Form
    {
        public delegate void RefreshHandler();
        public event RefreshHandler RefreshTheme;

        bool selectedrefresh = false;

        public Setting()
        {
            InitializeComponent();
        }

        private void refreshFloderList()
        {
            tvMusicFolders.Nodes.Clear();
            foreach (Floder floder in Ldbc.getAllMusicFloders())
            {
                TreeNodeWithFloder newNode = new TreeNodeWithFloder();
                newNode.Floder = floder;
                newNode.Text = floder.Path;
                tvMusicFolders.Nodes.Add(newNode);
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            btnDesktopLyricsColor.BackColor = OxySettings.Default.DesktopLyricsColor;
            btnDesktopLyricsFont.Text = OxySettings.Default.DesktopLyricsFont.Name;

            rtbDesktopLyricsPreview.ForeColor = OxySettings.Default.DesktopLyricsColor;
            rtbDesktopLyricsPreview.Font = OxySettings.Default.DesktopLyricsFont;

            btnMainWindowLyricsColor.BackColor = OxySettings.Default.MainWindowLyricsColor;
            btnMainWindowLyricsFont.Text = OxySettings.Default.MainWindowsLyricsFont.Name;

            rtbMainWindowLyricsPreview.ForeColor = OxySettings.Default.MainWindowLyricsColor;
            rtbMainWindowLyricsPreview.Font = OxySettings.Default.MainWindowsLyricsFont;

            chkUpdateOnStartup.Checked = OxySettings.Default.UpdateOnStartup;

            nudDesktopLyricsOpacity.Value = (decimal)(OxySettings.Default.Opacity * 100);

            cbSortKind.SelectedIndex = OxySettings.Default.ListSortKind;

            if (AppInfo.Default.IsTesing)
                lblVersion.Text = $"版本 {AppInfo.Default.VersionFull}";
            else
                lblVersion.Text = $"版本 {AppInfo.Default.Version}";

            lblReleaseChannel.Text = $"发布通道 {AppInfo.Default.VersionPrefix}";
            refreshFloderList();
            refreshDBStatus();
        }

        private void refreshDBStatus()
        {
            rtbDBStatus.Text = $"音乐数据表条目数：{Ldbc.GetItemsCount()}\r\n文件夹数据表条目数：{Ldbc.getAllMusicFloders().Count()}";
        }

        private void gbDesktopLyricsPreview_Enter(object sender, EventArgs e)
        {
        }

        private void btnDesktopLyricsFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = OxySettings.Default.DesktopLyricsFont;
            dlgFont.ShowDialog();
            rtbDesktopLyricsPreview.Font = dlgFont.Font;
            btnDesktopLyricsFont.Text = dlgFont.Font.Name;
            OxySettings.Default.DesktopLyricsFont = dlgFont.Font;
            OxySettings.Default.Save();
        }

        private void lblDesktopLyricsFont_Click(object sender, EventArgs e)
        {
        }

        private void btnDesktopLyricsColor_Click(object sender, EventArgs e)
        {
            dlgColor.Color = btnDesktopLyricsColor.BackColor;
            dlgColor.ShowDialog();
            btnDesktopLyricsColor.BackColor = dlgColor.Color;
            rtbDesktopLyricsPreview.ForeColor = dlgColor.Color;
            OxySettings.Default.DesktopLyricsColor = dlgColor.Color;
            OxySettings.Default.Save();
        }

        private void lblDesktopLyricsColor_Click(object sender, EventArgs e)
        {
        }

        private void dlgFont_Apply(object sender, EventArgs e)
        {
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            OxySettings.Default.Opacity = ((double)nudDesktopLyricsOpacity.Value / 100.0);
            OxySettings.Default.ShowStartup = chkShowStartupScreen.Checked;
            OxySettings.Default.ExitWhenFormClosing = chkExitOnClose.Checked;
            OxySettings.Default.UpdateOnStartup = chkUpdateOnStartup.Checked;
            OxySettings.Default.ListSortKind = cbSortKind.SelectedIndex;
            OxySettings.Default.Save();
            Ldbc.ListSortkind = (SortKind)OxySettings.Default.ListSortKind;
            RefreshTheme();
        }

        private void btnMainWindowLyricsColor_Click(object sender, EventArgs e)
        {
            dlgColor.Color = btnMainWindowLyricsColor.BackColor;
            dlgColor.ShowDialog();
            btnMainWindowLyricsColor.BackColor = dlgColor.Color;
            rtbMainWindowLyricsPreview.ForeColor = dlgColor.Color;
            OxySettings.Default.MainWindowLyricsColor = dlgColor.Color;
            OxySettings.Default.Save();
        }

        private void btnMainWindowLyricsFont_Click(object sender, EventArgs e)
        {
            dlgFont.Font = OxySettings.Default.MainWindowsLyricsFont;
            dlgFont.ShowDialog();
            rtbMainWindowLyricsPreview.Font = dlgFont.Font;
            btnMainWindowLyricsFont.Text = dlgFont.Font.Name;
            OxySettings.Default.MainWindowsLyricsFont = dlgFont.Font;
            OxySettings.Default.Save();
        }

        private void btnBrowseFolder_Click(object sender, EventArgs e)
        {
            dlgFolderBrowser.ShowDialog();
            txtFolderPath.Text = dlgFolderBrowser.SelectedPath;
        }

        private void tvMusicFolders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedrefresh = true;
            chkEnableSelectedFolder.Checked = ((TreeNodeWithFloder)tvMusicFolders.SelectedNode).Floder.enabled;
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            Ldbc.addMusicFlodersTable(txtFolderPath.Text);
            txtFolderPath.Text = "";
            refreshFloderList();
        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            Ldbc.delMusicFlodersTable(((TreeNodeWithFloder)tvMusicFolders.SelectedNode).Floder.Path);
            refreshFloderList();
        }

        private void chkEnableSelectedFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedrefresh == false)
            {
                Ldbc.setMusicFloderEnable(((TreeNodeWithFloder)tvMusicFolders.SelectedNode).Floder.Path, chkEnableSelectedFolder.Checked);
                refreshFloderList();
            }
            else
            {
                selectedrefresh = false;
            }
        }

        private void btnViewLicense_Click(object sender, EventArgs e)
        {
            TextViewer tv = new TextViewer("LICENSE");
            tv.ShowDialog();
        }

        private void btnViewNotice_Click(object sender, EventArgs e)
        {
            TextViewer tv = new TextViewer("NOTICE");
            tv.ShowDialog();
        }

        private void btnRebuildSongTable_Click(object sender, EventArgs e)
        {
            Ldbc.DeleteSongsTable();
            Ldbc.updataSongsTable();
        }

        private void btnDeleteDatabase_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("songs.db");
            Application.Restart();
        }

        private void btnStartLiteDBStudio_Click(object sender, EventArgs e)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = @".\LdbStu\LiteDB.Studio.exe";
                p.StartInfo.Arguments = "songs.db";
                p.Start();
                p.WaitForExit();
            }
        }

        private void btnRefreshDBStatus_Click(object sender, EventArgs e)
        {
            refreshDBStatus();
        }
    }

    class TreeNodeWithFloder : TreeNode
    {
        public Floder Floder { get; set; }
    }
}