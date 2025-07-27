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

namespace OxyPlayer
{
    public class SmoothLabel : Label
    {
        public SmoothLabel()
        {
            this.DoubleBuffered = true; // 启用双缓冲减少闪烁
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 设置高质量文本渲染（禁用抗锯齿）
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

            // 使用纯色绘制文本（避免花边）
            using (SolidBrush brush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, brush, ClientRectangle);
            }
        }
    }
}
