namespace OxyPlayer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("");
            this.panelPlayControl = new System.Windows.Forms.Panel();
            this.uiSymbolButtonLockDesktopLyrics = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonNext = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonRandomPlay = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonBefore = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonShowDesktopLyrics = new Sunny.UI.UISymbolButton();
            this.uiSymbolButtonPlay = new Sunny.UI.UISymbolButton();
            this.uiScrollingTextLyrics = new Sunny.UI.UIScrollingText();
            this.uiLabelArtist = new Sunny.UI.UILabel();
            this.uiLabelTitle = new Sunny.UI.UILabel();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.panelList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewPlaylist = new System.Windows.Forms.TreeView();
            this.inputSearch = new AntdUI.Input();
            this.buttonSettings = new AntdUI.Button();
            this.buttonRefresh = new AntdUI.Button();
            this.buttonUpdateDB = new AntdUI.Button();
            this.TimeTrackTimer = new System.Windows.Forms.Timer(this.components);
            this.uiTrackBarTimeTrack = new AntdUI.Slider();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.notifyIconKeep = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelPlayControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.panelList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayControl
            // 
            this.panelPlayControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(189)))), ((int)(((byte)(128)))));
            this.panelPlayControl.Controls.Add(this.uiTrackBarTimeTrack);
            this.panelPlayControl.Controls.Add(this.uiSymbolButtonLockDesktopLyrics);
            this.panelPlayControl.Controls.Add(this.uiSymbolButtonNext);
            this.panelPlayControl.Controls.Add(this.uiSymbolButtonRandomPlay);
            this.panelPlayControl.Controls.Add(this.uiSymbolButtonBefore);
            this.panelPlayControl.Controls.Add(this.uiSymbolButtonShowDesktopLyrics);
            this.panelPlayControl.Controls.Add(this.uiSymbolButtonPlay);
            this.panelPlayControl.Controls.Add(this.uiScrollingTextLyrics);
            this.panelPlayControl.Controls.Add(this.uiLabelArtist);
            this.panelPlayControl.Controls.Add(this.uiLabelTitle);
            this.panelPlayControl.Controls.Add(this.pictureBoxCover);
            this.panelPlayControl.Controls.Add(this.uiLabel1);
            this.panelPlayControl.Location = new System.Drawing.Point(-4, 326);
            this.panelPlayControl.Name = "panelPlayControl";
            this.panelPlayControl.Size = new System.Drawing.Size(882, 174);
            this.panelPlayControl.TabIndex = 1;
            // 
            // uiSymbolButtonLockDesktopLyrics
            // 
            this.uiSymbolButtonLockDesktopLyrics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonLockDesktopLyrics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
            this.uiSymbolButtonLockDesktopLyrics.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonLockDesktopLyrics.Location = new System.Drawing.Point(708, 51);
            this.uiSymbolButtonLockDesktopLyrics.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonLockDesktopLyrics.Name = "uiSymbolButtonLockDesktopLyrics";
            this.uiSymbolButtonLockDesktopLyrics.Size = new System.Drawing.Size(32, 32);
            this.uiSymbolButtonLockDesktopLyrics.Symbol = 361475;
            this.uiSymbolButtonLockDesktopLyrics.SymbolOffset = new System.Drawing.Point(-1, 1);
            this.uiSymbolButtonLockDesktopLyrics.TabIndex = 12;
            this.uiSymbolButtonLockDesktopLyrics.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonLockDesktopLyrics.Click += new System.EventHandler(this.uiSymbolButtonLockDesktopLyrics_Click);
            // 
            // uiSymbolButtonNext
            // 
            this.uiSymbolButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonNext.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonNext.Location = new System.Drawing.Point(617, 51);
            this.uiSymbolButtonNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonNext.Name = "uiSymbolButtonNext";
            this.uiSymbolButtonNext.Size = new System.Drawing.Size(32, 32);
            this.uiSymbolButtonNext.Symbol = 361521;
            this.uiSymbolButtonNext.SymbolOffset = new System.Drawing.Point(1, 2);
            this.uiSymbolButtonNext.SymbolSize = 27;
            this.uiSymbolButtonNext.TabIndex = 4;
            this.uiSymbolButtonNext.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonNext.Click += new System.EventHandler(this.uiSymbolButtonNext_Click);
            // 
            // uiSymbolButtonRandomPlay
            // 
            this.uiSymbolButtonRandomPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonRandomPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
            this.uiSymbolButtonRandomPlay.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
            this.uiSymbolButtonRandomPlay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonRandomPlay.Location = new System.Drawing.Point(503, 51);
            this.uiSymbolButtonRandomPlay.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonRandomPlay.Name = "uiSymbolButtonRandomPlay";
            this.uiSymbolButtonRandomPlay.Size = new System.Drawing.Size(32, 32);
            this.uiSymbolButtonRandomPlay.Symbol = 61556;
            this.uiSymbolButtonRandomPlay.SymbolOffset = new System.Drawing.Point(2, 2);
            this.uiSymbolButtonRandomPlay.SymbolSize = 28;
            this.uiSymbolButtonRandomPlay.TabIndex = 3;
            this.uiSymbolButtonRandomPlay.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonRandomPlay.Click += new System.EventHandler(this.uiSymbolButtonRandomPlay_Click);
            // 
            // uiSymbolButtonBefore
            // 
            this.uiSymbolButtonBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonBefore.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonBefore.Location = new System.Drawing.Point(541, 51);
            this.uiSymbolButtonBefore.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonBefore.Name = "uiSymbolButtonBefore";
            this.uiSymbolButtonBefore.Size = new System.Drawing.Size(32, 32);
            this.uiSymbolButtonBefore.Symbol = 361512;
            this.uiSymbolButtonBefore.SymbolOffset = new System.Drawing.Point(1, 2);
            this.uiSymbolButtonBefore.SymbolSize = 27;
            this.uiSymbolButtonBefore.TabIndex = 2;
            this.uiSymbolButtonBefore.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonBefore.Click += new System.EventHandler(this.uiSymbolButtonBefore_Click);
            // 
            // uiSymbolButtonShowDesktopLyrics
            // 
            this.uiSymbolButtonShowDesktopLyrics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonShowDesktopLyrics.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
            this.uiSymbolButtonShowDesktopLyrics.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonShowDesktopLyrics.Location = new System.Drawing.Point(670, 51);
            this.uiSymbolButtonShowDesktopLyrics.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonShowDesktopLyrics.Name = "uiSymbolButtonShowDesktopLyrics";
            this.uiSymbolButtonShowDesktopLyrics.Size = new System.Drawing.Size(32, 32);
            this.uiSymbolButtonShowDesktopLyrics.Symbol = 560427;
            this.uiSymbolButtonShowDesktopLyrics.SymbolOffset = new System.Drawing.Point(1, 2);
            this.uiSymbolButtonShowDesktopLyrics.TabIndex = 1;
            this.uiSymbolButtonShowDesktopLyrics.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonShowDesktopLyrics.Click += new System.EventHandler(this.uiSymbolButtonShowDesktopLyrics_Click);
            // 
            // uiSymbolButtonPlay
            // 
            this.uiSymbolButtonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonPlay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonPlay.Location = new System.Drawing.Point(579, 51);
            this.uiSymbolButtonPlay.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonPlay.Name = "uiSymbolButtonPlay";
            this.uiSymbolButtonPlay.Size = new System.Drawing.Size(32, 32);
            this.uiSymbolButtonPlay.Symbol = 361515;
            this.uiSymbolButtonPlay.SymbolOffset = new System.Drawing.Point(0, 1);
            this.uiSymbolButtonPlay.TabIndex = 0;
            this.uiSymbolButtonPlay.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonPlay.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiScrollingTextLyrics
            // 
            this.uiScrollingTextLyrics.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiScrollingTextLyrics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiScrollingTextLyrics.Location = new System.Drawing.Point(15, 122);
            this.uiScrollingTextLyrics.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiScrollingTextLyrics.Name = "uiScrollingTextLyrics";
            this.uiScrollingTextLyrics.Size = new System.Drawing.Size(853, 43);
            this.uiScrollingTextLyrics.TabIndex = 3;
            // 
            // uiLabelArtist
            // 
            this.uiLabelArtist.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabelArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabelArtist.Location = new System.Drawing.Point(128, 54);
            this.uiLabelArtist.Name = "uiLabelArtist";
            this.uiLabelArtist.Size = new System.Drawing.Size(348, 17);
            this.uiLabelArtist.TabIndex = 11;
            // 
            // uiLabelTitle
            // 
            this.uiLabelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabelTitle.Location = new System.Drawing.Point(127, 30);
            this.uiLabelTitle.Name = "uiLabelTitle";
            this.uiLabelTitle.Size = new System.Drawing.Size(349, 23);
            this.uiLabelTitle.TabIndex = 10;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(16, 17);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(99, 99);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCover.TabIndex = 6;
            this.pictureBoxCover.TabStop = false;
            this.pictureBoxCover.Click += new System.EventHandler(this.pictureBoxCover_Click);
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(244)))), ((int)(((byte)(180)))));
            this.panelDetail.Location = new System.Drawing.Point(637, -1);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(244, 335);
            this.panelDetail.TabIndex = 0;
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            this.panelList.Controls.Add(this.label1);
            this.panelList.Controls.Add(this.treeViewPlaylist);
            this.panelList.Controls.Add(this.inputSearch);
            this.panelList.Controls.Add(this.buttonSettings);
            this.panelList.Controls.Add(this.buttonRefresh);
            this.panelList.Controls.Add(this.buttonUpdateDB);
            this.panelList.Location = new System.Drawing.Point(0, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(643, 337);
            this.panelList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "OxyPlayer";
            // 
            // treeViewPlaylist
            // 
            this.treeViewPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            this.treeViewPlaylist.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewPlaylist.Location = new System.Drawing.Point(12, 37);
            this.treeViewPlaylist.Name = "treeViewPlaylist";
            treeNode1.Name = "NodeZ";
            treeNode1.Text = "";
            this.treeViewPlaylist.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewPlaylist.ShowRootLines = false;
            this.treeViewPlaylist.Size = new System.Drawing.Size(619, 276);
            this.treeViewPlaylist.TabIndex = 0;
            this.treeViewPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // inputSearch
            // 
            this.inputSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputSearch.Location = new System.Drawing.Point(387, 3);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.PrefixFormat = AntdUI.FormatFlags.Left;
            this.inputSearch.PrefixSvg = "SearchOutlined";
            this.inputSearch.Size = new System.Drawing.Size(251, 35);
            this.inputSearch.SuffixFore = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.inputSearch.TabIndex = 1;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BadgeSvg = "";
            this.buttonSettings.IconSvg = "SettingOutlined";
            this.buttonSettings.Location = new System.Drawing.Point(352, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(35, 35);
            this.buttonSettings.TabIndex = 13;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BadgeSvg = "";
            this.buttonRefresh.IconSvg = "ReloadOutlined";
            this.buttonRefresh.Location = new System.Drawing.Point(317, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(35, 35);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonUpdateDB
            // 
            this.buttonUpdateDB.BadgeSvg = "";
            this.buttonUpdateDB.IconSvg = "DatabaseOutlined";
            this.buttonUpdateDB.Location = new System.Drawing.Point(282, 3);
            this.buttonUpdateDB.Name = "buttonUpdateDB";
            this.buttonUpdateDB.Size = new System.Drawing.Size(35, 35);
            this.buttonUpdateDB.TabIndex = 15;
            this.buttonUpdateDB.Click += new System.EventHandler(this.buttonUpdateDB_Click);
            // 
            // TimeTrackTimer
            // 
            this.TimeTrackTimer.Interval = 50;
            this.TimeTrackTimer.Tick += new System.EventHandler(this.TimeTrackTimer_Tick);
            // 
            // uiTrackBarTimeTrack
            // 
            this.uiTrackBarTimeTrack.ColorScheme = AntdUI.TAMode.Light;
            this.uiTrackBarTimeTrack.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.uiTrackBarTimeTrack.Location = new System.Drawing.Point(209, 90);
            this.uiTrackBarTimeTrack.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.uiTrackBarTimeTrack.Name = "uiTrackBarTimeTrack";
            this.uiTrackBarTimeTrack.Size = new System.Drawing.Size(659, 27);
            this.uiTrackBarTimeTrack.TabIndex = 13;
            this.uiTrackBarTimeTrack.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiTrackBarTimeTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uiTrackBarTimeTrack_MouseDown);
            this.uiTrackBarTimeTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uiTrackBarTimeTrack_MouseUp);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(121, 96);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(97, 17);
            this.uiLabel1.TabIndex = 14;
            this.uiLabel1.Text = "00 : 00/00 : 00";
            // 
            // notifyIconKeep
            // 
            this.notifyIconKeep.Text = "notifyIcon1";
            this.notifyIconKeep.Visible = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 496);
            this.Controls.Add(this.panelPlayControl);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.panelPlayControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlayControl;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private Sunny.UI.UISymbolButton uiSymbolButtonNext;
        private Sunny.UI.UISymbolButton uiSymbolButtonRandomPlay;
        private Sunny.UI.UISymbolButton uiSymbolButtonBefore;
        private Sunny.UI.UISymbolButton uiSymbolButtonShowDesktopLyrics;
        private Sunny.UI.UISymbolButton uiSymbolButtonPlay;
        private Sunny.UI.UILabel uiLabelArtist;
        private Sunny.UI.UILabel uiLabelTitle;
        private Sunny.UI.UISymbolButton uiSymbolButtonLockDesktopLyrics;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.TreeView treeViewPlaylist;
        private AntdUI.Input inputSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimeTrackTimer;
        private Sunny.UI.UIScrollingText uiScrollingTextLyrics;
        private AntdUI.Button buttonSettings;
        private AntdUI.Button buttonRefresh;
        private AntdUI.Button buttonUpdateDB;
        private AntdUI.Slider uiTrackBarTimeTrack;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.NotifyIcon notifyIconKeep;
    }
}