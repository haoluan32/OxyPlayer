using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace OxyPlayer
{
    public partial class ImageViewer : Form
    {
        Image showImage;
        public ImageViewer(Image inputImage)
        {
            InitializeComponent();
            showImage = inputImage;
        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = showImage;
            pictureBox1.Size = showImage.Size;
            this.Size = showImage.Size;
        }

        private void ImageViewer_SizeChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = this.Size;
            pictureBox1.Location = new Point(0, 0);
        }

        private void 导出图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            Bitmap copy = new Bitmap(showImage);
            copy.Save(saveFileDialog1.FileName);
            copy.Dispose();
            MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
