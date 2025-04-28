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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("User Music Floder");
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TimeTrackLine = new System.Windows.Forms.TrackBar();
            this.labeltitle = new System.Windows.Forms.Label();
            this.labelartistalbum = new System.Windows.Forms.Label();
            this.TimeTrackTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimeTrackText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackLine)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(44, 354);
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
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode2.Name = "NodeZ";
            treeNode2.Text = "User Music Floder";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(514, 221);
            this.treeView1.TabIndex = 3;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // TimeTrackLine
            // 
            this.TimeTrackLine.Location = new System.Drawing.Point(12, 324);
            this.TimeTrackLine.Name = "TimeTrackLine";
            this.TimeTrackLine.Size = new System.Drawing.Size(514, 45);
            this.TimeTrackLine.TabIndex = 5;
            this.TimeTrackLine.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TimeTrackLine.ValueChanged += new System.EventHandler(this.TimeTrack_ValueChanged);
            this.TimeTrackLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeTrack_MouseDown);
            this.TimeTrackLine.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TimeTrack_MouseUp);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.Location = new System.Drawing.Point(95, 260);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(67, 25);
            this.labeltitle.TabIndex = 6;
            this.labeltitle.Text = "Name";
            // 
            // labelartistalbum
            // 
            this.labelartistalbum.AutoSize = true;
            this.labelartistalbum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelartistalbum.Location = new System.Drawing.Point(98, 290);
            this.labelartistalbum.Name = "labelartistalbum";
            this.labelartistalbum.Size = new System.Drawing.Size(86, 17);
            this.labelartistalbum.TabIndex = 7;
            this.labelartistalbum.Text = "Artist · Album";
            // 
            // TimeTrackTimer
            // 
            this.TimeTrackTimer.Tick += new System.EventHandler(this.TimeTrackTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hyd v0.16.25.03.29";
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
            this.TimeTrackText.Location = new System.Drawing.Point(443, 357);
            this.TimeTrackText.Name = "TimeTrackText";
            this.TimeTrackText.Size = new System.Drawing.Size(83, 17);
            this.TimeTrackText.TabIndex = 9;
            this.TimeTrackText.Text = "00:00 / 00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VolumeTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(384, 377);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TimeTrackText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelartistalbum);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeTrackLine);
            this.Name = "Form1";
            this.Text = "OxyPlayer Hyd";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeTrackLine)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TrackBar TimeTrackLine;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labelartistalbum;
        private System.Windows.Forms.Timer TimeTrackTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label TimeTrackText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

