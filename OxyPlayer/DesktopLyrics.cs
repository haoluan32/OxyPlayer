using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OxyPlayer
{
    public partial class DesktopLyrics : Form
    {
        SmoothLabel label1 = new SmoothLabel();
        Font useFont = new Font("微软雅黑", 18);
        Color useColor = Color.Black;
        bool locked = false;
        Graphics graph;
        Pen pen;
        bool mouse_entered = false;

        public bool LockDesktopLyric
        {

            get { return locked; }
            set
            {
                locked = value;
                DesktopLyrics_MouseLeave(new object(), new EventArgs());
            }
        }

        public DesktopLyrics()
        {
            InitializeComponent();
            graph = this.CreateGraphics();

        }

        private void DesktopLyrics_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            TopLevel = true;
            TopMost = true;
            BackColor = Color.Empty;
            TransparencyKey = BackColor;
            label1.Location = new Point(12, 40);
            this.Controls.Add(label1);
            label1.MouseEnter += Label1_MouseEnter;
            this.Location = OxySettings.Default.DesktopLyricsLocation;
            LockDesktopLyric = OxySettings.Default.LockDesktopLyrics;
            ReadStyle();
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            if (locked) return;
        }

        public void ReadStyle()
        {
            useFont = OxySettings.Default.DesktopLyricsFont;
            useColor = OxySettings.Default.DesktopLyricsColor;
            label1.ForeColor = useColor;
            label1.Font = useFont;
            pen = new Pen(useColor);
            //label1.Visible = false;
        }

        public void UpdateLyrics(string lyrics)
        {
            label1.Size = new Size((int)GetPreciseTextWidth(lyrics + "                              ", useFont) + 14, 159);
            label1.Text = lyrics;
            //graph.DrawString(lyrics, useFont, pen.Brush, 0, 0);
            //this.Opacity = OxySettings.Default.Opacity;
            timer1.Enabled = this.Visible;
        }

        public void UpdateSong(Song song)
        {
            pageHeader1.Text = $"{song.Title} - {song.Artist}";
        }

        public float GetPreciseTextWidth(string text, Font font)
        {
            using (Bitmap bmp = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(bmp))
            using (StringFormat format = new StringFormat(StringFormat.GenericTypographic))
            {
                format.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
                return g.MeasureString(text, font, int.MaxValue, format).Width;
            }
        }

        private void DesktopLyrics_MouseEnter(object sender, EventArgs e)
        {
            if (locked) return;
            pageHeader1.Visible = true;
        }

        private void DesktopLyrics_MouseLeave(object sender, EventArgs e)
        {
            pageHeader1.Visible = false;
            if (locked) return;
            OxySettings.Default.DesktopLyricsLocation = this.Location;
            OxySettings.Default.LockDesktopLyrics = locked;
            OxySettings.Default.Save();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mousePosition = Cursor.Position;
            if ((this.Location.X < mousePosition.X) && (this.Location.X + this.Size.Width > mousePosition.X))
            {
                if ((this.Location.Y < mousePosition.Y) && (this.Location.Y + this.Size.Height > mousePosition.Y))
                {
                    if(!pageHeader1.Visible)
                        DesktopLyrics_MouseEnter(sender, e);
                    return;
                }
            }
           if(pageHeader1.Visible)
                DesktopLyrics_MouseLeave(sender, e);
        }
    }
}
