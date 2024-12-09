using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);

            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            SolidBrush drawBrush2 = new SolidBrush(Color.Blue);
            Font drawFont = new Font("Arial", 32, FontStyle.Bold);
            SolidBrush drawBrush3 = new SolidBrush(Color.Yellow);

            SolidBrush drawBrush4 = new SolidBrush(Color.Red);
            SolidBrush drawBrush5 = new SolidBrush(Color.Red);
            SolidBrush drawBrush6 = new SolidBrush(Color.Red);


            drawPen.Color = Color.Black;
            drawBrush.Color = Color.Blue;
            drawBrush2.Color = Color.Yellow;
            drawBrush4.Color = Color.Pink;
            drawBrush5.Color = Color.Orange;
            drawBrush6.Color = Color.Red;

            g.DrawPie(drawPen, 465, 5, 100, 100, 30, 300);
            g.FillPie(drawBrush2, 465, 5, 100, 100, 30, 300);
            g.DrawEllipse(drawPen, 5, 5, 100, 100);
            g.FillEllipse(drawBrush, 5, 5, 100, 100);
            g.DrawEllipse(drawPen, 120, 5, 100, 100);
            g.FillEllipse(drawBrush4, 120, 5, 100, 100);
            g.DrawEllipse(drawPen, 235, 5, 100, 100);
            g.FillEllipse(drawBrush5, 235, 5, 100, 100); 
            g.DrawEllipse(drawPen, 350, 5, 100, 100);
            g.FillEllipse(drawBrush5, 235, 5, 100, 100);
            g.DrawEllipse(drawPen, 350, 5, 100, 100);
            g.FillEllipse(drawBrush6, 350, 5, 100, 100);
            g.DrawEllipse(drawPen, 40, 50, 20, 20);  
            g.FillEllipse(drawBrush2, 40, 50, 20, 20);  
            g.DrawEllipse(drawPen, 80, 50, 20, 20);  
            g.FillEllipse(drawBrush2, 80, 50, 20, 20);  
            g.DrawEllipse(drawPen, 200, 50, 20, 20);
            g.DrawEllipse(drawPen, 160, 50, 20, 20);
            g.FillEllipse(drawBrush2, 160, 50, 20, 20);
            g.FillEllipse(drawBrush2, 200, 50, 20, 20);
            g.DrawEllipse(drawPen, 320, 50, 20, 20);
            g.FillEllipse(drawBrush2, 320, 50, 20, 20);
            g.DrawEllipse(drawPen, 280, 50, 20, 20);
            g.FillEllipse(drawBrush2, 280, 50, 20, 20);
            g.DrawEllipse(drawPen, 440, 50, 20, 20);
            g.FillEllipse(drawBrush2, 440, 50, 20, 20);
            g.DrawEllipse(drawPen, 400, 50, 20, 20);
            g.FillEllipse(drawBrush2, 400, 50, 20, 20);
            g.FillPie(drawBrush2, 5, 180, 50, 50, 30, 300);
            g.DrawPie(drawPen, 275, 180, 50, 50, 30, 300);
            g.FillPie(drawBrush2, 275, 180, 50, 50, 30, 300);
            g.FillPie(drawBrush2, 405, 180, 50, 50, 30, 300);
            g.DrawString("Happy", drawFont, drawBrush2, 50, 180);
            g.DrawString("Birthday", drawFont, drawBrush2, 450, 180);
            

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Refresh();
            Thread.Sleep(100);
            g.Clear(Color.White);




            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            SolidBrush drawBrush2 = new SolidBrush(Color.Blue);
            Font drawFont = new Font("Arial", 32, FontStyle.Bold);
            SolidBrush drawBrush3 = new SolidBrush(Color.Yellow);

            SolidBrush drawBrush4 = new SolidBrush(Color.Red);
            SolidBrush drawBrush5 = new SolidBrush(Color.Red);
            SolidBrush drawBrush6 = new SolidBrush(Color.Red);

            
            drawPen.Color = Color.Black;
            drawBrush.Color = Color.Blue;
            drawBrush2.Color = Color.Yellow;
            drawBrush4.Color = Color.Pink;
            drawBrush5.Color = Color.Orange;
            drawBrush6.Color = Color.Red;

            g.DrawPie(drawPen, 465, 5, 100, 100, 30, 300);
            g.FillPie(drawBrush2, 465, 5, 100, 100, 30, 300);
            g.DrawEllipse(drawPen, 5, 5, 100, 100);
            g.FillEllipse(drawBrush, 5, 5, 100, 100);
            g.DrawEllipse(drawPen, 120, 5, 100, 100);
            g.FillEllipse(drawBrush4, 120, 5, 100, 100);
            g.DrawEllipse(drawPen, 235, 5, 100, 100);
            g.FillEllipse(drawBrush5, 235, 5, 100, 100);
            g.DrawEllipse(drawPen, 350, 5, 100, 100);
            g.FillEllipse(drawBrush5, 235, 5, 100, 100);
            g.DrawEllipse(drawPen, 350, 5, 100, 100);
            g.FillEllipse(drawBrush6, 350, 5, 100, 100);
            g.DrawEllipse(drawPen, 40, 50, 20, 20);
            g.FillEllipse(drawBrush2, 40, 50, 20, 20);
            g.DrawEllipse(drawPen, 80, 50, 20, 20);
            g.FillEllipse(drawBrush2, 80, 50, 20, 20);
            g.DrawEllipse(drawPen, 200, 50, 20, 20);
            g.DrawEllipse(drawPen, 160, 50, 20, 20);
            g.FillEllipse(drawBrush2, 160, 50, 20, 20);
            g.FillEllipse(drawBrush2, 200, 50, 20, 20);
            g.DrawEllipse(drawPen, 320, 50, 20, 20);
            g.FillEllipse(drawBrush2, 320, 50, 20, 20);
            g.DrawEllipse(drawPen, 280, 50, 20, 20);
            g.FillEllipse(drawBrush2, 280, 50, 20, 20);
            g.DrawEllipse(drawPen, 440, 50, 20, 20);
            g.FillEllipse(drawBrush2, 440, 50, 20, 20);
            g.DrawEllipse(drawPen, 400, 50, 20, 20);
            g.FillEllipse(drawBrush2, 400, 50, 20, 20);
            g.FillPie(drawBrush2, 5, 180, 50, 50, 30, 300);
            g.DrawPie(drawPen, 275, 180, 50, 50, 30, 300);
            g.FillPie(drawBrush2, 275, 180, 50, 50, 30, 300);
            g.FillPie(drawBrush2, 405, 180, 50, 50, 30, 300);
            g.DrawString("Happy", drawFont, drawBrush2, 50, 180);
            g.DrawString("Birthday", drawFont, drawBrush2, 450, 180);

            


        }
    }
}