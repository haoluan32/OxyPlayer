using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OxyPlayer
{
    public partial class TextViewer : Form
    {
        string filepath = "";

        public TextViewer(string path)
        {
            InitializeComponent();
            filepath = path;
        }

        private void TextViewer_Load(object sender, EventArgs e)
        {

        }

        private void TextViewer_Shown(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(filepath);
            richTextBox1.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }
    }
}
