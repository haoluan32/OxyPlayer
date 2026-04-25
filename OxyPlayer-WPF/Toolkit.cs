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
using Microsoft;
using System.Diagnostics;
using LiteDB;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OxyPlayer_WPF
{
    class Toolkit
    {
        [DllImport("kernel32.dll")]
        public static extern uint GetTickCount();
        static public void Delay(uint ms)
        {
            uint start = GetTickCount();
            while (GetTickCount() - start < ms)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
    }
}
