namespace OxyPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User Music Floder");
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TimeTrackLine = new System.Windows.Forms.TrackBar();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.TimeTrackTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimeTrackText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackLine)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(44, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "▶";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(12, 36);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeZ";
            treeNode1.Text = "User Music Floder";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(514, 221);
            this.treeView1.TabIndex = 3;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // TimeTrackLine
            // 
            this.TimeTrackLine.Location = new System.Drawing.Point(12, 348);
            this.TimeTrackLine.Name = "TimeTrackLine";
            this.TimeTrackLine.Size = new System.Drawing.Size(514, 45);
            this.TimeTrackLine.TabIndex = 5;
            this.TimeTrackLine.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TimeTrackLine.ValueChanged += new System.EventHandler(this.TimeTrack_ValueChanged);
            this.TimeTrackLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeTrack_MouseDown);
            this.TimeTrackLine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TimeTrack_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(97, 274);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(67, 25);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Name";
            this.labelTitle.Click += new System.EventHandler(this.klabel_Click);
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelArtist.Location = new System.Drawing.Point(99, 299);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(38, 17);
            this.labelArtist.TabIndex = 7;
            this.labelArtist.Text = "Artist";
            this.labelArtist.Click += new System.EventHandler(this.klabel_Click);
            // 
            // TimeTrackTimer
            // 
            this.TimeTrackTimer.Tick += new System.EventHandler(this.TimeTrackTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hyd v0.55.25.06.12";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // TimeTrackText
            // 
            this.TimeTrackText.AutoSize = true;
            this.TimeTrackText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeTrackText.Location = new System.Drawing.Point(443, 381);
            this.TimeTrackText.Name = "TimeTrackText";
            this.TimeTrackText.Size = new System.Drawing.Size(83, 17);
            this.TimeTrackText.TabIndex = 9;
            this.TimeTrackText.Text = "00:00 / 00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VolumeTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(384, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 50);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "音量";
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.Location = new System.Drawing.Point(6, 20);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Size = new System.Drawing.Size(136, 45);
            this.VolumeTrackBar.TabIndex = 11;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeTrackBar.Value = 100;
            this.VolumeTrackBar.ValueChanged += new System.EventHandler(this.VolumeTrackBar_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具TToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(538, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicTagToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.工具TToolStripMenuItem.Text = "工具（&T）";
            // 
            // musicTagToolStripMenuItem
            // 
            this.musicTagToolStripMenuItem.Name = "musicTagToolStripMenuItem";
            this.musicTagToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.musicTagToolStripMenuItem.Text = "&MusicTag";
            this.musicTagToolStripMenuItem.Click += new System.EventHandler(this.musicTagToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 72);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "歌词";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(354, 47);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAlbum.Location = new System.Drawing.Point(98, 316);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(45, 17);
            this.labelAlbum.TabIndex = 14;
            this.labelAlbum.Text = "Album";
            this.labelAlbum.Click += new System.EventHandler(this.klabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TimeTrackText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeTrackLine);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OxyPlayer Hyd";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackLine)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TrackBar TimeTrackLine;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Timer TimeTrackTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label TimeTrackText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicTagToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelAlbum;
    }
}

