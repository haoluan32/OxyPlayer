using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
using Windows.Media.AppBroadcasting;

namespace OxyPlayer
{
    public partial class MainWindow : Form
    {
        string[] SupportedFormating;
        MusicPlayer_MediaPlayer musicPlayer = new MusicPlayer_MediaPlayer();
        Musicinfo nowPlaying_musicinfo;
        DesktopLyrics desktopLyrics = new DesktopLyrics();

        Setting setting = new Setting();
        SMTC smtc = new SMTC();

        bool inputSearch_Changed = false;
        int searchDelayCount;
        bool randomPlayEnabled = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        void rePaintControl()
        {
            uiScrollingTextLyrics.ForeColor = OxySettings.Default.MainWindowLyricsColor;
            uiScrollingTextLyrics.Font = OxySettings.Default.MainWindowsLyricsFont;
            desktopLyrics.ReadStyle();
        }
        private void InitTreeNode_DB()
        {
            SupportedFormating = MusicSh.GetSupportedFormating();
            if (Ldbc.getAllMusicFloders().Count()==0)
            {
                Ldbc.addMusicFlodersTable(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
                Ldbc.updataSongsTable();
            }


            treeViewPlaylist.Nodes.Clear();
            Song[] songTable = Ldbc.GetAllSongsInfo();
            foreach (Song song in songTable)
            {
                TreeNodeWithInfo ntn = new TreeNodeWithInfo();
                ntn.Text = song.Title + " - " + song.Artist;
                ntn.SongInfo = song;
                treeViewPlaylist.Nodes.Add(ntn);
            }
            
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            TimeTrackTimer.Start();
            setting.Refresh += rePaintControl;
            rePaintControl();
            desktopLyrics.uiSymbolButtonBefore.Click += uiSymbolButtonBefore_Click;
            desktopLyrics.uiSymbolButtonNext.Click += uiSymbolButtonNext_Click;
            desktopLyrics.uiSymbolButtonRandomPlay.Click += uiSymbolButtonRandomPlay_Click;
            desktopLyrics.uiSymbolButtonPlay.Click += uiSymbolButton1_Click;
            desktopLyrics.uiSymbolButtonShowDesktopLyrics.Click += uiSymbolButtonShowDesktopLyrics_Click;
            desktopLyrics.uiSymbolButtonLockDesktopLyrics.Click += uiSymbolButtonLockDesktopLyrics_Click;

            desktopLyrics.Visible = !OxySettings.Default.ShownDesklopLyrics;
            uiSymbolButtonShowDesktopLyrics_Click(new object(),new EventArgs());

            desktopLyrics.LockDesktopLyric = !OxySettings.Default.LockDesktopLyrics;
            uiSymbolButtonLockDesktopLyrics_Click(new object(), new EventArgs());

            randomPlayEnabled = !OxySettings.Default.RandomPlay;
            uiSymbolButtonRandomPlay_Click(new object(), new EventArgs());

            if(OxySettings.Default.PreviousSong!=null)
                playMusic(OxySettings.Default.PreviousSong, false);

            if (AppInfo.Default.IsTesing)
                 labelVersion.Text = $"{AppInfo.Default.VersionFull} ({AppInfo.Default.VersionPrefix})";
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.playMusic(((TreeNodeWithInfo)treeViewPlaylist.SelectedNode).SongInfo);
        }

        private void playMusic(Song song,bool play=true)
        {
            
            nowPlaying_musicinfo = MusicSh.GetMusicInfo(song.Address);
            uiLabelTitle.Text = nowPlaying_musicinfo.Title;
            uiLabelArtist.Text = nowPlaying_musicinfo.Artist;
            pictureBoxCover.Image = nowPlaying_musicinfo.Cover;
            uiTrackBarTimeTrack.MaxValue = nowPlaying_musicinfo.TimeLength_Second;
            toolStripMenuItemPlayingSong.Text = $"{nowPlaying_musicinfo.Title} - {nowPlaying_musicinfo.Artist}";
            musicPlayer.LoadMusic(song);
            desktopLyrics.UpdateSong(song);
            smtc.UpdateMusicInfo(nowPlaying_musicinfo);
            OxySettings.Default.PreviousSong = song;
            OxySettings.Default.Save();
            if (play)
                uiSymbolButton1_Click(new object(), new EventArgs());
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            InitTreeNode_DB();
        }

        private void TimeTrackTimer_Tick(object sender, EventArgs e)
        {
            uiTrackBarTimeTrack.Value = musicPlayer.Position_Int;
            try
            {
                uiLabelTimeDisplayer.Text = $"{musicPlayer.Position_String} / {MusicSh.Second2MMSS(nowPlaying_musicinfo.TimeLength_Second)}";
            }
            catch { }
            if (nowPlaying_musicinfo != null && nowPlaying_musicinfo.lrcsheet != null)
            {
                if (nowPlaying_musicinfo.lrcsheet.ContainsKey(musicPlayer.Position_Int))
                {
                    uiScrollingTextLyrics.Text = nowPlaying_musicinfo.lrcsheet[musicPlayer.Position_Int];
                    desktopLyrics.UpdateLyrics(uiScrollingTextLyrics.Text);
                }
            }

            if(uiTrackBarTimeTrack.Value==uiTrackBarTimeTrack.MaxValue)
            {
                uiSymbolButtonNext_Click(new object(), new EventArgs());
            }

            if (inputSearch_Changed)
                searchDelayCount++;
            if (inputSearch_Changed)
            {
                if (inputSearch.Text != "")
                {
                    if (searchDelayCount >= 10)
                    {
                        inputSearch_Changed = false;
                        treeViewPlaylist.Nodes.Clear();
                        Song[] songTable = Ldbc.searchDBMerged(inputSearch.Text);
                        foreach (Song song in songTable)
                        {
                            TreeNodeWithInfo ntn = new TreeNodeWithInfo();
                            ntn.Text = song.Title + " - " + song.Artist;
                            ntn.SongInfo = song;
                            treeViewPlaylist.Nodes.Add(ntn);
                        }
                    }
                }
                else
                {
                    if (searchDelayCount >= 2)
                    {
                        inputSearch_Changed = false;
                        treeViewPlaylist.Nodes.Clear();
                        Song[] songTable = Ldbc.GetAllSongsInfo();
                        foreach (Song song in songTable)
                        {
                            TreeNodeWithInfo ntn = new TreeNodeWithInfo();
                            ntn.Text = song.Title + " - " + song.Artist;
                            ntn.SongInfo = song;
                            treeViewPlaylist.Nodes.Add(ntn);
                        }
                    }
                }
            }
        }

        

        private void uiSymbolButtonBefore_Click(object sender, EventArgs e)
        {
            Song song;
            try
            {
                song = Ldbc.searchDB(SongsRow.Id, (musicPlayer.NowPlaying.Id - 1).ToString())[0];
                playMusic(song);
            }
            catch 
            {
                song = Ldbc.searchDB(SongsRow.Id, "1")[0];
                playMusic(song);
            }
        }

        private void uiSymbolButtonNext_Click(object sender, EventArgs e)
        {
            Song song;
            try
            {
                if (randomPlayEnabled)
                {
                    song = Ldbc.searchDB(SongsRow.Id, MusicSh.GetRandomNumber(0,Ldbc.GetItemsCount()).ToString())[0];
                    playMusic(song);
                }
                else
                {
                    song = Ldbc.searchDB(SongsRow.Id, (musicPlayer.NowPlaying.Id + 1).ToString())[0];
                    playMusic(song);
                }
            }
            catch
            {
                song = Ldbc.searchDB(SongsRow.Id, "0")[0];
                playMusic(song);
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            inputSearch_Changed = true;
            searchDelayCount = 0;
        }

        private void pictureBoxCover_Click(object sender, EventArgs e)
        {
            ImageViewer imageViewer = new ImageViewer(pictureBoxCover.Image);
            imageViewer.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            setting.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            InitTreeNode_DB();
        }

        private void buttonUpdateDB_Click(object sender, EventArgs e)
        {
            Ldbc.updataSongsTable();
            InitTreeNode_DB();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            //pause 361516
            musicPlayer.SwitchPlayingStatus();
            if (musicPlayer.PlayingStatus)
            {
                uiSymbolButtonPlay.Symbol = 361516;
                uiSymbolButtonPlay.SymbolOffset = new Point(2, 2);
                uiSymbolButtonPlay.SymbolSize = 27;
                desktopLyrics.uiSymbolButtonPlay.Symbol = 361516;
                desktopLyrics.uiSymbolButtonPlay.SymbolOffset = new Point(2, 2);
                desktopLyrics.uiSymbolButtonPlay.SymbolSize = 27;
            }

            else
            {
                uiSymbolButtonPlay.Symbol = 361515;
                uiSymbolButtonPlay.SymbolOffset = new Point(0, 1);
                uiSymbolButtonPlay.SymbolSize = 24;
                desktopLyrics.uiSymbolButtonPlay.Symbol = 361515;
                desktopLyrics.uiSymbolButtonPlay.SymbolOffset = new Point(0, 1);
                desktopLyrics.uiSymbolButtonPlay.SymbolSize = 24;
            }
        }

        private void uiSymbolButtonRandomPlay_Click(object sender, EventArgs e)
        {
            if (randomPlayEnabled)
            {
                randomPlayEnabled = false;
                uiSymbolButtonRandomPlay.FillColor = Color.FromArgb(41, 94, 145);
                desktopLyrics.uiSymbolButtonRandomPlay.FillColor = Color.FromArgb(41, 94, 145);
            }
            else
            {
                randomPlayEnabled = true;
                uiSymbolButtonRandomPlay.FillColor = Color.FromArgb(80, 160, 255);
                desktopLyrics.uiSymbolButtonRandomPlay.FillColor = Color.FromArgb(80, 160, 255);
            }
            ToolStripMenuItemRandomPlay.Checked = randomPlayEnabled;
            OxySettings.Default.RandomPlay = randomPlayEnabled;
            OxySettings.Default.Save();
        }

        private void uiSymbolButtonShowDesktopLyrics_Click(object sender, EventArgs e)
        {
            if(desktopLyrics.Visible)
            {
                desktopLyrics.Hide();
                uiSymbolButtonShowDesktopLyrics.FillColor = Color.FromArgb(41, 94, 145);
                
            }
            else
            {
                desktopLyrics.Show();
                uiSymbolButtonShowDesktopLyrics.FillColor = Color.FromArgb(80, 160, 255);
            }
            toolStripMenuItemShowDesktopLyric.Checked = desktopLyrics.Visible;
            OxySettings.Default.ShownDesklopLyrics = desktopLyrics.Visible;
            OxySettings.Default.Save();
        }

        private void uiSymbolButtonLockDesktopLyrics_Click(object sender, EventArgs e)
        {
            if (desktopLyrics.LockDesktopLyric)
            {
                desktopLyrics.LockDesktopLyric = false;
                uiSymbolButtonLockDesktopLyrics.FillColor = Color.FromArgb(41, 94, 145);
            }
            else
            {
                desktopLyrics.LockDesktopLyric = true;
                uiSymbolButtonLockDesktopLyrics.FillColor = Color.FromArgb(80, 160, 255);
            }
            toolStripMenuItemLockDesktopLyric.Checked = desktopLyrics.LockDesktopLyric;
            
        }

        private void uiTrackBarTimeTrack_MouseDown(object sender, MouseEventArgs e)
        {
            TimeTrackTimer.Stop();
        }

        private void uiTrackBarTimeTrack_MouseUp(object sender, MouseEventArgs e)
        {
            musicPlayer.Position_Int = uiTrackBarTimeTrack.Value;
            TimeTrackTimer.Start();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
