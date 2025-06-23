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
    public partial class DoingSth : Form
    {
        public DoingSth(string title,string info)
        {
            InitializeComponent();
            this.Text = title;
            label1.Text = info;
        }
    }
}
