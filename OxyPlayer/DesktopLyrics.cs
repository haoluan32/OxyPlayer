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
        Font useFont= new Font("微软雅黑", 18);
        Color useColor = Color.Black;
        bool locked = false;

        public bool LockDesktopLyric
        {
            get { return locked; }
            set
            {
                locked = value;
                this.FormBorderStyle = FormBorderStyle.None;
                if(value)
                {
                    pictureBox4.Image = OxyPlayer.Properties.Resources.LockDesktopLyric;
                }
                else
                {
                    pictureBox4.Image = OxyPlayer.Properties.Resources.UnLockDesktopLyric;
                }
            }
        }

        public DesktopLyrics()
        {
            InitializeComponent();
        }

        private void DesktopLyrics_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            TopLevel = true;
            TopMost = true;
            BackColor = Color.Empty;
            TransparencyKey = BackColor;
            label1.Location = new Point(12, 9);
            this.Controls.Add(label1);
            label1.MouseEnter += Label1_MouseEnter;
            this.Location = OxySettings.Default.DesktopLyricsLocation;
            LockDesktopLyric = OxySettings.Default.LockDesktopLyrics;
            this.FormBorderStyle = FormBorderStyle.None;
            ReadStyle();
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            if (locked) return;
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        public void ReadStyle()
        {
            useFont = OxySettings.Default.DesktopLyricsFont;
            useColor = OxySettings.Default.DesktopLyricsColor;
            label1.ForeColor = useColor;
            label1.Font = useFont;
        }

        public void UpdateLyrics(string lyrics)
        {
            label1.Size=new Size( (int)GetPreciseTextWidth(lyrics+"                              ", useFont)+14,159);
            label1.Text = lyrics;
            this.Opacity = OxySettings.Default.Opacity;
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
            this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
        }

        private void DesktopLyrics_MouseLeave(object sender, EventArgs e)
        {
            if (locked) return;
            this.FormBorderStyle = FormBorderStyle.None;
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
    }
}
