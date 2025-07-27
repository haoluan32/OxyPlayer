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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            comboBox1.Text = "Title";
        }
        public Search(string comboText,string Searchkey)
        {
            InitializeComponent();
            comboBox1.Text = comboText;
            textBox1.Text = Searchkey;
            button1_Click(new object(), new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SongsRow row = SongsRow.Title;
            if (comboBox1.Text == "Title")
            {
                 row = SongsRow.Title;
            }
            if (comboBox1.Text == "Artist")
            {
                row = SongsRow.Artist;
            }
            if (comboBox1.Text == "Album")
            {
                row = SongsRow.Album;
            }
            var songs= Ldbc.searchDB(row, textBox1.Text);
           // DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            dt.Columns.Add("Artist");
            dt.Columns.Add("Album");
            dt.Columns.Add("Address");
            foreach (var esong in songs)
            {
                dt.Rows.Add(esong.Title,esong.Artist,esong.Album,esong.Address);                               
            }
            dataGridView1.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
