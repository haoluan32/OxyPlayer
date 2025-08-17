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
        public delegate void ClickResultHandler(Song a);
        public event ClickResultHandler ClickResult;

        string searchkey="";

        DataTable dt = new DataTable();
        public Search()
        {
            InitializeComponent();
            comboBox1.Text = "Title";
        }
        public Search(string comboText,string iSearchkey)
        {
            InitializeComponent();
            comboBox1.Text = comboText;
            textBox1.Text = iSearchkey;
            searchkey = iSearchkey;
            
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
            dt.Clear();            
            foreach (var esong in songs)
            {
                dt.Rows.Add(esong.Id,esong.Title,esong.Artist,esong.Album,esong.Address);
            }
            dataGridView1.DataSource = dt;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Id");
            dt.Columns.Add("Title");
            dt.Columns.Add("Artist");
            dt.Columns.Add("Album");
            dt.Columns.Add("Address");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int selrowindex = 0;
            DataRow selrow = null;
            try
            {
                selrowindex = dataGridView1.SelectedCells[0].RowIndex;
                selrow = dt.Rows[selrowindex];

            } 
            catch { }
            var song = Ldbc.searchDB(SongsRow.Id,(string)selrow[0])[0];
            ClickResult(song);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='\r')
            {
                button1_Click(new object(), new EventArgs());
            }
        }

        private void Search_Shown(object sender, EventArgs e)
        {
            if(searchkey!="")
            {
                button1_Click(new object(), new EventArgs());
            }
        }
    }
}
