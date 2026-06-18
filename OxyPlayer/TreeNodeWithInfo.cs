using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;
using System.IO;
using System.Runtime;
using Windows;
using Microsoft;
using System.Diagnostics;
using System.Windows.Forms.Integration;
using LiteDB;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Sunny.UI;

namespace OxyPlayer
{
    class TreeNodeWithInfo:TreeNode
    {
        public Song SongInfo { get; set; }
    }
}
