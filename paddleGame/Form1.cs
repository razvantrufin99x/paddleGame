using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace paddleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Rectangle paddle = new Rectangle();
        Rectangle ball = new Rectangle();
        int x = 0;
        int y = 0;
        int deltaX = 1;
        int deltaY = 2;
        int score = 0;
        int mousex = 0;
        int mousey = 0;
        int gw;
        int gh;


        public int game()
        {
            GraphicsWindow.g.Clear(Color.White);
            PrintScore(score.ToString());



            x = x + deltaX;
            y = y + deltaY;


            if (x >= gw - 16 || x <= 0)
            {
                deltaX = -deltaX;
            }
            if (y <= 0)
            {
                deltaY = -deltaY;
            }

            int padX = paddle.Left;

            if ((y == gh - 20) && (x >= padX) && (x <= padX + 60))
            {
               
                score = score + 10;
                PrintScore(score.ToString());
                deltaY = -deltaY;
                
            }

            ball.X = x;
            ball.Y = y;


            GraphicsWindow.g.DrawRectangle(GraphicsWindow.p, x, y, 10, 10);
            GraphicsWindow.g.DrawRectangle(GraphicsWindow.p, mousex, GraphicsWindow.Height - 25, 50, 18);


          


            if (y < gh)
            {
                return 1;
            }
            return 0;
        }

        public void PrintScore(string s)
        {
            GraphicsWindow.g.DrawRectangle(GraphicsWindow.p, 10, 10, 200, 20);
            GraphicsWindow.g.DrawString("Score: " + s, GraphicsWindow.f, GraphicsWindow.b, 10, 10);
            GraphicsWindow.g.DrawString(x.ToString() + " : " + y.ToString(), GraphicsWindow.f, GraphicsWindow.b, 260, 10);
            GraphicsWindow.g.DrawString(mousex.ToString() + " : " + mousey.ToString(), GraphicsWindow.f, GraphicsWindow.b, 320, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            gw = GraphicsWindow.Width;
            gh = GraphicsWindow.Height - 20;

        }

        private void GraphicsWindow_MouseMove(object sender, MouseEventArgs e)
        {
            mousex = e.X;
            mousey = e.Y;
            paddle.X = mousex - 15;
            paddle.Y = mousey;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game();
            GraphicsWindow.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
    }
}
