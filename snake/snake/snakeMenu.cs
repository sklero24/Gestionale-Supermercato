using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class snakeMenu : Form
    {
        Rectangle snake = new Rectangle(40, 40, 20, 20);
        Rectangle snake2 = new Rectangle(200, 90, 20, 20);
        Rectangle snake3 = new Rectangle(20, 50, 20, 20);
        Rectangle snake4 = new Rectangle(400, 80, 20, 20);
        Rectangle snake5 = new Rectangle(200, 80, 20, 20);
        snakeGame game; 
        snakeOptions options;
        int opt = 0; //stato finestra opzioni 0 -> chiuso, 1 -> aperto
        int gm = 0; //stato finestra gioco 0 -> chiuso, 1 -> aperto
        public snakeMenu()
        {
            InitializeComponent();
            //if (Global.volume == true) snakeGameLogic.playSoundLoop(@"snakeMenu.wav");
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Lime, snake);
            e.Graphics.FillRectangle(Brushes.Lime, snake2);
            e.Graphics.FillRectangle(Brushes.Lime, snake3);
            e.Graphics.FillRectangle(Brushes.Lime, snake4);
            e.Graphics.FillRectangle(Brushes.Lime, snake5);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void gioca_btn_Click(object sender, EventArgs e)
        {
            gm = 1;
            //if (Global.volume == true) snakeGameLogic.stopSound();
            
            game = new snakeGame();
            game.Visible = true;
            game.Enabled = true;
        }

        private void opzioni_btn_Click(object sender, EventArgs e)
        {
            //if (Global.volume == true) snakeGameLogic.stopSound();

            opt = 1;
            options = new snakeOptions();
            options.Visible = true;
            options.Enabled = true;
        }

        private void esci_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void snakeMenu_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //controlla se sono state chiuse la finestra di opzioni o quella di gioco
            if(opt == 1)
            {
                if (options.IsDisposed == true)
                {
                    opt = 0;
                    //if (Global.volume == true) snakeGameLogic.playSoundLoop(@"snakeMenu.wav");
                }
            }
            if(gm == 1)
            {
                if (game.IsDisposed == true)
                {
                    gm = 0;
                    //if (Global.volume == true) snakeGameLogic.playSoundLoop(@"snakeMenu.wav");
                }
            }

            if(gm != 1 && opt != 1)
            {
                //animazione snake che si muovono
                snake.X += 10;
                if (this.Width < snake.X) snake.X = 0;
                snake2.X -= 20;
                if (0 == snake2.X) snake2.X = this.Width;
                snake3.Y += 5;
                if (this.Height < snake3.Y) snake3.Y = 0;
                snake4.Y -= 10;
                if (0 == snake4.Y) snake4.Y = this.Height;
            }
            

            this.Invalidate();
        }
    }
}
