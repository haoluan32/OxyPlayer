namespace OxyPlayer
{
    partial class Setting
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
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.lblDesktopLyricsColor = new System.Windows.Forms.Label();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.btnDesktopLyricsColor = new System.Windows.Forms.Button();
            this.lblDesktopLyricsFont = new System.Windows.Forms.Label();
            this.btnDesktopLyricsFont = new System.Windows.Forms.Button();
            this.gbDesktopLyricsSettings = new System.Windows.Forms.GroupBox();
            this.rtbDesktopLyricsPreview = new System.Windows.Forms.RichTextBox();
            this.lblDesktopLyricsOpacity = new System.Windows.Forms.Label();
            this.nudDesktopLyricsOpacity = new System.Windows.Forms.NumericUpDown();
            this.lblOpacityPercent = new System.Windows.Forms.Label();
            this.gbMainWindowLyricsSettings = new System.Windows.Forms.GroupBox();
            this.chkShowStartupScreen = new System.Windows.Forms.CheckBox();
            this.chkExitOnClose = new System.Windows.Forms.CheckBox();
            this.gbMainWindowLyricsPreview = new System.Windows.Forms.GroupBox();
            this.btnMainWindowLyricsColor = new System.Windows.Forms.Button();
            this.btnMainWindowLyricsFont = new System.Windows.Forms.Button();
            this.lblMainWindowLyricsColor = new System.Windows.Forms.Label();
            this.lblMainWindowLyricsFont = new System.Windows.Forms.Label();
            this.tabsMain = new AntdUI.Tabs();
            this.tpBasicSettings = new AntdUI.TabPage();
            this.chkUpdateOnStartup = new System.Windows.Forms.CheckBox();
            this.tpPersonalization = new AntdUI.TabPage();
            this.tpMusicFolderManagement = new AntdUI.TabPage();
            this.chkEnableSelectedFolder = new System.Windows.Forms.CheckBox();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.tvMusicFolders = new System.Windows.Forms.TreeView();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.tpDatabaseStatus = new AntdUI.TabPage();
            this.btnRefreshDBStatus = new System.Windows.Forms.Button();
            this.btnRebuildSongTable = new System.Windows.Forms.Button();
            this.btnStartLiteDBStudio = new System.Windows.Forms.Button();
            this.btnDeleteDatabase = new System.Windows.Forms.Button();
            this.rtbDBStatus = new System.Windows.Forms.RichTextBox();
            this.lblRebuildNote = new System.Windows.Forms.Label();
            this.lblLiteDBStudioNote = new System.Windows.Forms.Label();
            this.lblDeleteDBNote = new System.Windows.Forms.Label();
            this.tpAbout = new AntdUI.TabPage();
            this.rtbNotice = new System.Windows.Forms.RichTextBox();
            this.rtbLinks = new System.Windows.Forms.RichTextBox();
            this.lblReleaseChannel = new System.Windows.Forms.Label();
            this.btnViewNotice = new System.Windows.Forms.Button();
            this.btnViewLicense = new System.Windows.Forms.Button();
            this.rtbLicense = new System.Windows.Forms.RichTextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pbAppLogo = new System.Windows.Forms.PictureBox();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgFolderBrowser = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();
            this.gbDesktopLyricsPreview = new System.Windows.Forms.GroupBox();
            this.rtbMainWindowLyricsPreview = new System.Windows.Forms.RichTextBox();
            this.gbDesktopLyricsPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesktopLyricsOpacity)).BeginInit();
            this.gbDesktopLyricsSettings.SuspendLayout();
            this.gbMainWindowLyricsSettings.SuspendLayout();
            this.gbMainWindowLyricsPreview.SuspendLayout();
            this.tabsMain.SuspendLayout();
            this.tpBasicSettings.SuspendLayout();
            this.tpPersonalization.SuspendLayout();
            this.tpMusicFolderManagement.SuspendLayout();
            this.tpDatabaseStatus.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesktopLyricsColor
            // 
            this.lblDesktopLyricsColor.AutoSize = true;
            this.lblDesktopLyricsColor.Location = new System.Drawing.Point(6, 19);
            this.lblDesktopLyricsColor.Name = "lblDesktopLyricsColor";
            this.lblDesktopLyricsColor.Size = new System.Drawing.Size(92, 17);
            this.lblDesktopLyricsColor.TabIndex = 0;
            this.lblDesktopLyricsColor.Text = "桌面歌词颜色：";
            this.lblDesktopLyricsColor.Click += new System.EventHandler(this.lblDesktopLyricsColor_Click);
            // 
            // btnDesktopLyricsColor
            // 
            this.btnDesktopLyricsColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesktopLyricsColor.Location = new System.Drawing.Point(94, 16);
            this.btnDesktopLyricsColor.Name = "btnDesktopLyricsColor";
            this.btnDesktopLyricsColor.Size = new System.Drawing.Size(198, 23);
            this.btnDesktopLyricsColor.TabIndex = 1;
            this.btnDesktopLyricsColor.UseVisualStyleBackColor = false;
            this.btnDesktopLyricsColor.Click += new System.EventHandler(this.btnDesktopLyricsColor_Click);
            // 
            // lblDesktopLyricsFont
            // 
            this.lblDesktopLyricsFont.AutoSize = true;
            this.lblDesktopLyricsFont.Location = new System.Drawing.Point(6, 57);
            this.lblDesktopLyricsFont.Name = "lblDesktopLyricsFont";
            this.lblDesktopLyricsFont.Size = new System.Drawing.Size(92, 17);
            this.lblDesktopLyricsFont.TabIndex = 2;
            this.lblDesktopLyricsFont.Text = "桌面歌词字体：";
            this.lblDesktopLyricsFont.Click += new System.EventHandler(this.lblDesktopLyricsFont_Click);
            // 
            // btnDesktopLyricsFont
            // 
            this.btnDesktopLyricsFont.Location = new System.Drawing.Point(94, 54);
            this.btnDesktopLyricsFont.Name = "btnDesktopLyricsFont";
            this.btnDesktopLyricsFont.Size = new System.Drawing.Size(198, 23);
            this.btnDesktopLyricsFont.TabIndex = 3;
            this.btnDesktopLyricsFont.Text = "btnDesktopLyricsFont";
            this.btnDesktopLyricsFont.UseVisualStyleBackColor = true;
            this.btnDesktopLyricsFont.Click += new System.EventHandler(this.btnDesktopLyricsFont_Click);
            // 
            // gbDesktopLyricsPreview
            // 
            this.gbDesktopLyricsPreview.Controls.Add(this.rtbDesktopLyricsPreview);
            this.gbDesktopLyricsPreview.Location = new System.Drawing.Point(6, 114);
            this.gbDesktopLyricsPreview.Name = "gbDesktopLyricsPreview";
            this.gbDesktopLyricsPreview.Size = new System.Drawing.Size(286, 144);
            this.gbDesktopLyricsPreview.TabIndex = 4;
            this.gbDesktopLyricsPreview.TabStop = false;
            this.gbDesktopLyricsPreview.Text = "预览";
            this.gbDesktopLyricsPreview.Enter += new System.EventHandler(this.gbDesktopLyricsPreview_Enter);
            // 
            // rtbDesktopLyricsPreview
            // 
            this.rtbDesktopLyricsPreview.Location = new System.Drawing.Point(6, 22);
            this.rtbDesktopLyricsPreview.Name = "rtbDesktopLyricsPreview";
            this.rtbDesktopLyricsPreview.Size = new System.Drawing.Size(274, 116);
            this.rtbDesktopLyricsPreview.TabIndex = 1;
            this.rtbDesktopLyricsPreview.Text = "演示 演示 Demo デモ\n歌词 歌詞 Lyric 歌詞\n这是一句预览歌词\n這是一句預覽歌词\nThis is a preview lyric\nこれはプレビューの歌" +
    "詞です";
            // 
            // lblDesktopLyricsOpacity
            // 
            this.lblDesktopLyricsOpacity.AutoSize = true;
            this.lblDesktopLyricsOpacity.Location = new System.Drawing.Point(6, 94);
            this.lblDesktopLyricsOpacity.Name = "lblDesktopLyricsOpacity";
            this.lblDesktopLyricsOpacity.Size = new System.Drawing.Size(116, 17);
            this.lblDesktopLyricsOpacity.TabIndex = 5;
            this.lblDesktopLyricsOpacity.Text = "桌面歌词不透明度：";
            // 
            // nudDesktopLyricsOpacity
            // 
            this.nudDesktopLyricsOpacity.Location = new System.Drawing.Point(120, 91);
            this.nudDesktopLyricsOpacity.Name = "nudDesktopLyricsOpacity";
            this.nudDesktopLyricsOpacity.Size = new System.Drawing.Size(143, 23);
            this.nudDesktopLyricsOpacity.TabIndex = 6;
            this.nudDesktopLyricsOpacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblOpacityPercent
            // 
            this.lblOpacityPercent.AutoSize = true;
            this.lblOpacityPercent.Location = new System.Drawing.Point(269, 94);
            this.lblOpacityPercent.Name = "lblOpacityPercent";
            this.lblOpacityPercent.Size = new System.Drawing.Size(19, 17);
            this.lblOpacityPercent.TabIndex = 7;
            this.lblOpacityPercent.Text = "%";
            // 
            // gbDesktopLyricsSettings
            // 
            this.gbDesktopLyricsSettings.Controls.Add(this.btnDesktopLyricsColor);
            this.gbDesktopLyricsSettings.Controls.Add(this.btnDesktopLyricsFont);
            this.gbDesktopLyricsSettings.Controls.Add(this.lblOpacityPercent);
            this.gbDesktopLyricsSettings.Controls.Add(this.gbDesktopLyricsPreview);
            this.gbDesktopLyricsSettings.Controls.Add(this.nudDesktopLyricsOpacity);
            this.gbDesktopLyricsSettings.Controls.Add(this.lblDesktopLyricsOpacity);
            this.gbDesktopLyricsSettings.Controls.Add(this.lblDesktopLyricsColor);
            this.gbDesktopLyricsSettings.Controls.Add(this.lblDesktopLyricsFont);
            this.gbDesktopLyricsSettings.Location = new System.Drawing.Point(314, 3);
            this.gbDesktopLyricsSettings.Name = "gbDesktopLyricsSettings";
            this.gbDesktopLyricsSettings.Size = new System.Drawing.Size(300, 264);
            this.gbDesktopLyricsSettings.TabIndex = 11;
            this.gbDesktopLyricsSettings.TabStop = false;
            this.gbDesktopLyricsSettings.Text = "桌面歌词设定";
            // 
            // chkShowStartupScreen
            // 
            this.chkShowStartupScreen.AutoSize = true;
            this.chkShowStartupScreen.Location = new System.Drawing.Point(17, 15);
            this.chkShowStartupScreen.Name = "chkShowStartupScreen";
            this.chkShowStartupScreen.Size = new System.Drawing.Size(135, 21);
            this.chkShowStartupScreen.TabIndex = 12;
            this.chkShowStartupScreen.Text = "启动时显示加载界面";
            this.chkShowStartupScreen.UseVisualStyleBackColor = true;
            // 
            // chkExitOnClose
            // 
            this.chkExitOnClose.AutoSize = true;
            this.chkExitOnClose.Location = new System.Drawing.Point(17, 42);
            this.chkExitOnClose.Name = "chkExitOnClose";
            this.chkExitOnClose.Size = new System.Drawing.Size(111, 21);
            this.chkExitOnClose.TabIndex = 13;
            this.chkExitOnClose.Text = "关闭时直接退出";
            this.chkExitOnClose.UseVisualStyleBackColor = true;
            // 
            // gbMainWindowLyricsSettings
            // 
            this.gbMainWindowLyricsSettings.Controls.Add(this.btnMainWindowLyricsColor);
            this.gbMainWindowLyricsSettings.Controls.Add(this.btnMainWindowLyricsFont);
            this.gbMainWindowLyricsSettings.Controls.Add(this.gbMainWindowLyricsPreview);
            this.gbMainWindowLyricsSettings.Controls.Add(this.lblMainWindowLyricsColor);
            this.gbMainWindowLyricsSettings.Controls.Add(this.lblMainWindowLyricsFont);
            this.gbMainWindowLyricsSettings.Location = new System.Drawing.Point(10, 3);
            this.gbMainWindowLyricsSettings.Name = "gbMainWindowLyricsSettings";
            this.gbMainWindowLyricsSettings.Size = new System.Drawing.Size(298, 237);
            this.gbMainWindowLyricsSettings.TabIndex = 14;
            this.gbMainWindowLyricsSettings.TabStop = false;
            this.gbMainWindowLyricsSettings.Text = "应用主界面歌词";
            // 
            // btnMainWindowLyricsColor
            // 
            this.btnMainWindowLyricsColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMainWindowLyricsColor.Location = new System.Drawing.Point(94, 16);
            this.btnMainWindowLyricsColor.Name = "btnMainWindowLyricsColor";
            this.btnMainWindowLyricsColor.Size = new System.Drawing.Size(198, 23);
            this.btnMainWindowLyricsColor.TabIndex = 6;
            this.btnMainWindowLyricsColor.UseVisualStyleBackColor = false;
            this.btnMainWindowLyricsColor.Click += new System.EventHandler(this.btnMainWindowLyricsColor_Click);
            // 
            // btnMainWindowLyricsFont
            // 
            this.btnMainWindowLyricsFont.Location = new System.Drawing.Point(94, 54);
            this.btnMainWindowLyricsFont.Name = "btnMainWindowLyricsFont";
            this.btnMainWindowLyricsFont.Size = new System.Drawing.Size(198, 23);
            this.btnMainWindowLyricsFont.TabIndex = 8;
            this.btnMainWindowLyricsFont.Text = "btnMainWindowLyricsFont";
            this.btnMainWindowLyricsFont.UseVisualStyleBackColor = true;
            this.btnMainWindowLyricsFont.Click += new System.EventHandler(this.btnMainWindowLyricsFont_Click);
            // 
            // gbMainWindowLyricsPreview
            // 
            this.gbMainWindowLyricsPreview.Controls.Add(this.rtbMainWindowLyricsPreview);
            this.gbMainWindowLyricsPreview.Location = new System.Drawing.Point(6, 83);
            this.gbMainWindowLyricsPreview.Name = "gbMainWindowLyricsPreview";
            this.gbMainWindowLyricsPreview.Size = new System.Drawing.Size(286, 144);
            this.gbMainWindowLyricsPreview.TabIndex = 9;
            this.gbMainWindowLyricsPreview.TabStop = false;
            this.gbMainWindowLyricsPreview.Text = "预览";
            // 
            // rtbMainWindowLyricsPreview
            // 
            this.rtbMainWindowLyricsPreview.Location = new System.Drawing.Point(6, 22);
            this.rtbMainWindowLyricsPreview.Name = "rtbMainWindowLyricsPreview";
            this.rtbMainWindowLyricsPreview.Size = new System.Drawing.Size(274, 116);
            this.rtbMainWindowLyricsPreview.TabIndex = 1;
            this.rtbMainWindowLyricsPreview.Text = "演示 演示 Demo デモ\n歌词 歌詞 Lyric 歌詞\n这是一句预览歌词\n這是一句預覽歌词\nThis is a preview lyric\n这是プレビューの歌" +
    "詞です";
            // 
            // lblMainWindowLyricsColor
            // 
            this.lblMainWindowLyricsColor.AutoSize = true;
            this.lblMainWindowLyricsColor.Location = new System.Drawing.Point(6, 19);
            this.lblMainWindowLyricsColor.Name = "lblMainWindowLyricsColor";
            this.lblMainWindowLyricsColor.Size = new System.Drawing.Size(92, 17);
            this.lblMainWindowLyricsColor.TabIndex = 5;
            this.lblMainWindowLyricsColor.Text = "界面歌词颜色：";
            // 
            // lblMainWindowLyricsFont
            // 
            this.lblMainWindowLyricsFont.AutoSize = true;
            this.lblMainWindowLyricsFont.Location = new System.Drawing.Point(6, 57);
            this.lblMainWindowLyricsFont.Name = "lblMainWindowLyricsFont";
            this.lblMainWindowLyricsFont.Size = new System.Drawing.Size(92, 17);
            this.lblMainWindowLyricsFont.TabIndex = 7;
            this.lblMainWindowLyricsFont.Text = "界面歌词字体：";
            // 
            // tabsMain
            // 
            this.tabsMain.Controls.Add(this.tpBasicSettings);
            this.tabsMain.Controls.Add(this.tpPersonalization);
            this.tabsMain.Controls.Add(this.tpMusicFolderManagement);
            this.tabsMain.Controls.Add(this.tpDatabaseStatus);
            this.tabsMain.Controls.Add(this.tpAbout);
            this.tabsMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabsMain.Location = new System.Drawing.Point(0, 0);
            this.tabsMain.Name = "tabsMain";
            this.tabsMain.Pages.Add(this.tpBasicSettings);
            this.tabsMain.Pages.Add(this.tpPersonalization);
            this.tabsMain.Pages.Add(this.tpMusicFolderManagement);
            this.tabsMain.Pages.Add(this.tpDatabaseStatus);
            this.tabsMain.Pages.Add(this.tpAbout);
            this.tabsMain.Size = new System.Drawing.Size(622, 402);
            this.tabsMain.Style = styleLine1;
            this.tabsMain.TabIndex = 15;
            this.tabsMain.Text = "tabsMain";
            // 
            // tpBasicSettings
            // 
            this.tpBasicSettings.BackColor = System.Drawing.Color.White;
            this.tpBasicSettings.Controls.Add(this.chkUpdateOnStartup);
            this.tpBasicSettings.Controls.Add(this.chkShowStartupScreen);
            this.tpBasicSettings.Controls.Add(this.chkExitOnClose);
            this.tpBasicSettings.Location = new System.Drawing.Point(0, 30);
            this.tpBasicSettings.Name = "tpBasicSettings";
            this.tpBasicSettings.Size = new System.Drawing.Size(622, 372);
            this.tpBasicSettings.TabIndex = 0;
            this.tpBasicSettings.Text = "基本设置";
            // 
            // chkUpdateOnStartup
            // 
            this.chkUpdateOnStartup.AutoSize = true;
            this.chkUpdateOnStartup.Location = new System.Drawing.Point(17, 69);
            this.chkUpdateOnStartup.Name = "chkUpdateOnStartup";
            this.chkUpdateOnStartup.Size = new System.Drawing.Size(147, 21);
            this.chkUpdateOnStartup.TabIndex = 14;
            this.chkUpdateOnStartup.Text = "启动时强制更新数据库";
            this.chkUpdateOnStartup.UseVisualStyleBackColor = true;
            // 
            // tpPersonalization
            // 
            this.tpPersonalization.Controls.Add(this.gbMainWindowLyricsSettings);
            this.tpPersonalization.Controls.Add(this.gbDesktopLyricsSettings);
            this.tpPersonalization.Location = new System.Drawing.Point(-1244, -744);
            this.tpPersonalization.Name = "tpPersonalization";
            this.tpPersonalization.Size = new System.Drawing.Size(622, 372);
            this.tpPersonalization.TabIndex = 1;
            this.tpPersonalization.Text = "个性化";
            // 
            // tpMusicFolderManagement
            // 
            this.tpMusicFolderManagement.Controls.Add(this.chkEnableSelectedFolder);
            this.tpMusicFolderManagement.Controls.Add(this.btnDeleteFolder);
            this.tpMusicFolderManagement.Controls.Add(this.btnAddFolder);
            this.tpMusicFolderManagement.Controls.Add(this.btnBrowseFolder);
            this.tpMusicFolderManagement.Controls.Add(this.txtFolderPath);
            this.tpMusicFolderManagement.Controls.Add(this.tvMusicFolders);
            this.tpMusicFolderManagement.Controls.Add(this.lblFolderPath);
            this.tpMusicFolderManagement.Location = new System.Drawing.Point(-1244, -744);
            this.tpMusicFolderManagement.Name = "tpMusicFolderManagement";
            this.tpMusicFolderManagement.Size = new System.Drawing.Size(622, 372);
            this.tpMusicFolderManagement.TabIndex = 2;
            this.tpMusicFolderManagement.Text = "音乐文件夹管理";
            // 
            // chkEnableSelectedFolder
            // 
            this.chkEnableSelectedFolder.AutoSize = true;
            this.chkEnableSelectedFolder.Location = new System.Drawing.Point(517, 343);
            this.chkEnableSelectedFolder.Name = "chkEnableSelectedFolder";
            this.chkEnableSelectedFolder.Size = new System.Drawing.Size(87, 21);
            this.chkEnableSelectedFolder.TabIndex = 5;
            this.chkEnableSelectedFolder.Text = "启用选中的";
            this.chkEnableSelectedFolder.UseVisualStyleBackColor = true;
            this.chkEnableSelectedFolder.CheckedChanged += new System.EventHandler(this.chkEnableSelectedFolder_CheckedChanged);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Location = new System.Drawing.Point(435, 341);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(76, 23);
            this.btnDeleteFolder.TabIndex = 4;
            this.btnDeleteFolder.Text = "删除(&D)";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(353, 340);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(76, 23);
            this.btnAddFolder.TabIndex = 3;
            this.btnAddFolder.Text = "添加(&A)";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(324, 340);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(23, 23);
            this.btnBrowseFolder.TabIndex = 2;
            this.btnBrowseFolder.Text = "..";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(48, 340);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(270, 23);
            this.txtFolderPath.TabIndex = 1;
            // 
            // tvMusicFolders
            // 
            this.tvMusicFolders.Location = new System.Drawing.Point(10, 3);
            this.tvMusicFolders.Name = "tvMusicFolders";
            this.tvMusicFolders.Size = new System.Drawing.Size(599, 331);
            this.tvMusicFolders.TabIndex = 0;
            this.tvMusicFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMusicFolders_AfterSelect);
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(7, 343);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(44, 17);
            this.lblFolderPath.TabIndex = 6;
            this.lblFolderPath.Text = "路径：";
            // 
            // tpDatabaseStatus
            // 
            this.tpDatabaseStatus.Controls.Add(this.btnRefreshDBStatus);
            this.tpDatabaseStatus.Controls.Add(this.btnRebuildSongTable);
            this.tpDatabaseStatus.Controls.Add(this.btnStartLiteDBStudio);
            this.tpDatabaseStatus.Controls.Add(this.btnDeleteDatabase);
            this.tpDatabaseStatus.Controls.Add(this.rtbDBStatus);
            this.tpDatabaseStatus.Controls.Add(this.lblRebuildNote);
            this.tpDatabaseStatus.Controls.Add(this.lblLiteDBStudioNote);
            this.tpDatabaseStatus.Controls.Add(this.lblDeleteDBNote);
            this.tpDatabaseStatus.Location = new System.Drawing.Point(-1244, -744);
            this.tpDatabaseStatus.Name = "tpDatabaseStatus";
            this.tpDatabaseStatus.Size = new System.Drawing.Size(622, 372);
            this.tpDatabaseStatus.TabIndex = 4;
            this.tpDatabaseStatus.Text = "数据库状态";
            // 
            // btnRefreshDBStatus
            // 
            this.btnRefreshDBStatus.Location = new System.Drawing.Point(12, 105);
            this.btnRefreshDBStatus.Name = "btnRefreshDBStatus";
            this.btnRefreshDBStatus.Size = new System.Drawing.Size(127, 23);
            this.btnRefreshDBStatus.TabIndex = 11;
            this.btnRefreshDBStatus.Text = "刷新数据库状态";
            this.btnRefreshDBStatus.UseVisualStyleBackColor = true;
            this.btnRefreshDBStatus.Click += new System.EventHandler(this.btnRefreshDBStatus_Click);
            // 
            // btnRebuildSongTable
            // 
            this.btnRebuildSongTable.Location = new System.Drawing.Point(12, 134);
            this.btnRebuildSongTable.Name = "btnRebuildSongTable";
            this.btnRebuildSongTable.Size = new System.Drawing.Size(127, 23);
            this.btnRebuildSongTable.TabIndex = 7;
            this.btnRebuildSongTable.Text = "重建音乐数据表";
            this.btnRebuildSongTable.UseVisualStyleBackColor = true;
            this.btnRebuildSongTable.Click += new System.EventHandler(this.btnRebuildSongTable_Click);
            // 
            // btnStartLiteDBStudio
            // 
            this.btnStartLiteDBStudio.Location = new System.Drawing.Point(12, 192);
            this.btnStartLiteDBStudio.Name = "btnStartLiteDBStudio";
            this.btnStartLiteDBStudio.Size = new System.Drawing.Size(127, 23);
            this.btnStartLiteDBStudio.TabIndex = 6;
            this.btnStartLiteDBStudio.Text = "启动LiteDB.Studio";
            this.btnStartLiteDBStudio.UseVisualStyleBackColor = true;
            this.btnStartLiteDBStudio.Click += new System.EventHandler(this.btnStartLiteDBStudio_Click);
            // 
            // btnDeleteDatabase
            // 
            this.btnDeleteDatabase.Location = new System.Drawing.Point(12, 163);
            this.btnDeleteDatabase.Name = "btnDeleteDatabase";
            this.btnDeleteDatabase.Size = new System.Drawing.Size(127, 23);
            this.btnDeleteDatabase.TabIndex = 5;
            this.btnDeleteDatabase.Text = "删除数据库";
            this.btnDeleteDatabase.UseVisualStyleBackColor = true;
            this.btnDeleteDatabase.Click += new System.EventHandler(this.btnDeleteDatabase_Click);
            // 
            // rtbDBStatus
            // 
            this.rtbDBStatus.BackColor = System.Drawing.Color.White;
            this.rtbDBStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDBStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbDBStatus.Location = new System.Drawing.Point(12, 26);
            this.rtbDBStatus.Name = "rtbDBStatus";
            this.rtbDBStatus.ReadOnly = true;
            this.rtbDBStatus.Size = new System.Drawing.Size(344, 54);
            this.rtbDBStatus.TabIndex = 4;
            this.rtbDBStatus.Text = "音乐数据表条目数：\n文件夹数据表条目数：";
            // 
            // lblRebuildNote
            // 
            this.lblRebuildNote.AutoSize = true;
            this.lblRebuildNote.Location = new System.Drawing.Point(137, 137);
            this.lblRebuildNote.Name = "lblRebuildNote";
            this.lblRebuildNote.Size = new System.Drawing.Size(248, 17);
            this.lblRebuildNote.TabIndex = 8;
            this.lblRebuildNote.Text = "（期间程序会卡死，完成后请点击刷新按钮）";
            // 
            // lblLiteDBStudioNote
            // 
            this.lblLiteDBStudioNote.AutoSize = true;
            this.lblLiteDBStudioNote.Location = new System.Drawing.Point(137, 195);
            this.lblLiteDBStudioNote.Name = "lblLiteDBStudioNote";
            this.lblLiteDBStudioNote.Size = new System.Drawing.Size(373, 17);
            this.lblLiteDBStudioNote.TabIndex = 10;
            this.lblLiteDBStudioNote.Text = "（仅供调试使用，LiteDB.Studio连接后程序数据库功能会出现问题）";
            // 
            // lblDeleteDBNote
            // 
            this.lblDeleteDBNote.AutoSize = true;
            this.lblDeleteDBNote.Location = new System.Drawing.Point(137, 166);
            this.lblDeleteDBNote.Name = "lblDeleteDBNote";
            this.lblDeleteDBNote.Size = new System.Drawing.Size(284, 17);
            this.lblDeleteDBNote.TabIndex = 9;
            this.lblDeleteDBNote.Text = "（会丢失音乐文件夹相关数据，使用后请重启程序）";
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.rtbNotice);
            this.tpAbout.Controls.Add(this.rtbLinks);
            this.tpAbout.Controls.Add(this.lblReleaseChannel);
            this.tpAbout.Controls.Add(this.btnViewNotice);
            this.tpAbout.Controls.Add(this.btnViewLicense);
            this.tpAbout.Controls.Add(this.rtbLicense);
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.Controls.Add(this.lblAppName);
            this.tpAbout.Controls.Add(this.pbAppLogo);
            this.tpAbout.Location = new System.Drawing.Point(-1244, -744);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(622, 372);
            this.tpAbout.TabIndex = 3;
            this.tpAbout.Text = "关于";
            // 
            // rtbNotice
            // 
            this.rtbNotice.BackColor = System.Drawing.Color.White;
            this.rtbNotice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNotice.Location = new System.Drawing.Point(12, 80);
            this.rtbNotice.Name = "rtbNotice";
            this.rtbNotice.ReadOnly = true;
            this.rtbNotice.Size = new System.Drawing.Size(599, 212);
            this.rtbNotice.TabIndex = 8;
            this.rtbNotice.Text = resources.GetString("richTextBox5.Text");
            // 
            // rtbLinks
            // 
            this.rtbLinks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLinks.Location = new System.Drawing.Point(189, 55);
            this.rtbLinks.Name = "rtbLinks";
            this.rtbLinks.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbLinks.Size = new System.Drawing.Size(407, 45);
            this.rtbLinks.TabIndex = 7;
            this.rtbLinks.Text = "https://github.com/haoluan32/OxyPlayer\nhttps://gitee.com/haoluan_bilibili/oxy-pla" +
    "yer";
            // 
            // lblReleaseChannel
            // 
            this.lblReleaseChannel.AutoSize = true;
            this.lblReleaseChannel.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReleaseChannel.Location = new System.Drawing.Point(327, 11);
            this.lblReleaseChannel.Name = "lblReleaseChannel";
            this.lblReleaseChannel.Size = new System.Drawing.Size(74, 21);
            this.lblReleaseChannel.TabIndex = 6;
            this.lblReleaseChannel.Text = "发布通道";
            // 
            // btnViewNotice
            // 
            this.btnViewNotice.Location = new System.Drawing.Point(312, 324);
            this.btnViewNotice.Name = "btnViewNotice";
            this.btnViewNotice.Size = new System.Drawing.Size(299, 33);
            this.btnViewNotice.TabIndex = 5;
            this.btnViewNotice.Text = "查看NOTICE";
            this.btnViewNotice.UseVisualStyleBackColor = true;
            this.btnViewNotice.Click += new System.EventHandler(this.btnViewNotice_Click);
            // 
            // btnViewLicense
            // 
            this.btnViewLicense.Location = new System.Drawing.Point(13, 324);
            this.btnViewLicense.Name = "btnViewLicense";
            this.btnViewLicense.Size = new System.Drawing.Size(293, 33);
            this.btnViewLicense.TabIndex = 4;
            this.btnViewLicense.Text = "查看LICENSE";
            this.btnViewLicense.UseVisualStyleBackColor = true;
            this.btnViewLicense.Click += new System.EventHandler(this.btnViewLicense_Click);
            // 
            // rtbLicense
            // 
            this.rtbLicense.BackColor = System.Drawing.Color.White;
            this.rtbLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLicense.Location = new System.Drawing.Point(12, 106);
            this.rtbLicense.Name = "rtbLicense";
            this.rtbLicense.ReadOnly = true;
            this.rtbLicense.Size = new System.Drawing.Size(599, 212);
            this.rtbLicense.TabIndex = 3;
            this.rtbLicense.Text = resources.GetString("richTextBox3.Text");
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("微软雅黑 Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVersion.Location = new System.Drawing.Point(327, 31);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(58, 21);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "版本号";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("微软雅黑 Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAppName.Location = new System.Drawing.Point(182, 11);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(146, 38);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "OxyPlayer";
            // 
            // pbAppLogo
            // 
            this.pbAppLogo.Image = global::OxyPlayer.Properties.Resources.Logo_L;
            this.pbAppLogo.Location = new System.Drawing.Point(10, 3);
            this.pbAppLogo.Name = "pbAppLogo";
            this.pbAppLogo.Size = new System.Drawing.Size(158, 97);
            this.pbAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAppLogo.TabIndex = 0;
            this.pbAppLogo.TabStop = false;
            // 
            // dlgFont
            // 
            this.dlgFont.Apply += new System.EventHandler(this.dlgFont_Apply);
            // 
            // dlgFolderBrowser
            // 
            this.dlgFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 399);
            this.Controls.Add(this.tabsMain);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Setting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.gbDesktopLyricsPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDesktopLyricsOpacity)).EndInit();
            this.gbDesktopLyricsSettings.ResumeLayout(false);
            this.gbDesktopLyricsSettings.PerformLayout();
            this.gbMainWindowLyricsSettings.ResumeLayout(false);
            this.gbMainWindowLyricsSettings.PerformLayout();
            this.gbMainWindowLyricsPreview.ResumeLayout(false);
            this.tabsMain.ResumeLayout(false);
            this.tpBasicSettings.ResumeLayout(false);
            this.tpBasicSettings.PerformLayout();
            this.tpPersonalization.ResumeLayout(false);
            this.tpMusicFolderManagement.ResumeLayout(false);
            this.tpMusicFolderManagement.PerformLayout();
            this.tpDatabaseStatus.ResumeLayout(false);
            this.tpDatabaseStatus.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDesktopLyricsColor;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.Button btnDesktopLyricsColor;
        private System.Windows.Forms.Label lblDesktopLyricsFont;
        private System.Windows.Forms.Button btnDesktopLyricsFont;
        private System.Windows.Forms.GroupBox gbDesktopLyricsPreview;
        private System.Windows.Forms.RichTextBox rtbDesktopLyricsPreview;
        private System.Windows.Forms.Label lblDesktopLyricsOpacity;
        private System.Windows.Forms.NumericUpDown nudDesktopLyricsOpacity;
        private System.Windows.Forms.Label lblOpacityPercent;
        private System.Windows.Forms.GroupBox gbDesktopLyricsSettings;
        private System.Windows.Forms.CheckBox chkShowStartupScreen;
        private System.Windows.Forms.CheckBox chkExitOnClose;
        private System.Windows.Forms.GroupBox gbMainWindowLyricsSettings;
        private System.Windows.Forms.Button btnMainWindowLyricsColor;
        private System.Windows.Forms.Button btnMainWindowLyricsFont;
        private System.Windows.Forms.GroupBox gbMainWindowLyricsPreview;
        private System.Windows.Forms.RichTextBox rtbMainWindowLyricsPreview;
        private System.Windows.Forms.Label lblMainWindowLyricsColor;
        private System.Windows.Forms.Label lblMainWindowLyricsFont;
        private AntdUI.Tabs tabsMain;
        private AntdUI.TabPage tpBasicSettings;
        private AntdUI.TabPage tpMusicFolderManagement;
        private AntdUI.TabPage tpPersonalization;
        private System.Windows.Forms.CheckBox chkEnableSelectedFolder;
        private System.Windows.Forms.Button btnDeleteFolder;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.TreeView tvMusicFolders;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.FontDialog dlgFont;
        private Ookii.Dialogs.WinForms.VistaFolderBrowserDialog dlgFolderBrowser;
        private AntdUI.TabPage tpAbout;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox pbAppLogo;
        private System.Windows.Forms.RichTextBox rtbLicense;
        private System.Windows.Forms.Button btnViewLicense;
        private System.Windows.Forms.Button btnViewNotice;
        private System.Windows.Forms.Label lblReleaseChannel;
        private System.Windows.Forms.RichTextBox rtbLinks;
        private System.Windows.Forms.CheckBox chkUpdateOnStartup;
        private AntdUI.TabPage tpDatabaseStatus;
        private System.Windows.Forms.RichTextBox rtbDBStatus;
        private System.Windows.Forms.RichTextBox rtbNotice;
        private System.Windows.Forms.Button btnStartLiteDBStudio;
        private System.Windows.Forms.Button btnDeleteDatabase;
        private System.Windows.Forms.Button btnRebuildSongTable;
        private System.Windows.Forms.Label lblRebuildNote;
        private System.Windows.Forms.Label lblLiteDBStudioNote;
        private System.Windows.Forms.Label lblDeleteDBNote;
        private System.Windows.Forms.Button btnRefreshDBStatus;
    }
}