using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//librerie audio
using NAudio.Wave;
using NAudio.Wave.SampleProviders;



namespace snake
{
    public partial class snakeGame : Form
    {
        Rectangle snkHead = new Rectangle(300, 300, 20, 20);
        List<Rectangle> snkTail = new List<Rectangle>();
        Rectangle food = new Rectangle(200, 200, 20, 20);
        Rectangle bigFood = new Rectangle(0, 0, 40, 40);
        int bigFoodTimer = 30;
        int firstTimeBigFood = 0; //variabile che serve per non rieptere una cosa
        string direzione = "destra"; //direzione di partenza
        SoundPlayer backgroundMusic;

        int timerDifficoltaMinimo = 10; //limite della difficoltà di gioco, pause in secondi

        public void startBackgroundMusic()
        {
            backgroundMusic = new SoundPlayer();
            backgroundMusic.LoadAsync();
            backgroundMusic.SoundLocation = @"snakeMusic.wav";
            backgroundMusic.PlayLooping();
        }

        public snakeGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        protected override void OnClosed(EventArgs e)
        {
            snakeMenu menu = new snakeMenu();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LightYellow, food);
            if (Global.eventBigFoodInc >= 5)
            {
                if (Global.eventBigFoodIsWritten == 1) e.Graphics.FillRectangle(Brushes.LightSkyBlue, bigFood);
            }
            e.Graphics.FillRectangle(Brushes.Green, snkHead);
            foreach (Rectangle tail in snkTail)
            {
                e.Graphics.FillRectangle(Brushes.DarkGreen, tail);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 'W': if (direzione != "sotto") direzione = "sopra"; break;
                case 'S': if (direzione != "sopra") direzione = "sotto"; break;
                case 'A': if (direzione != "destra") direzione = "sinistra"; break;
                case 'D': if (direzione != "sinistra") direzione = "destra"; break;
            }
        }

        private void snakeGame_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Global.eventBigFoodInc >= 5)
            {
                bigFoodTimer_lbl.Text = Convert.ToString(bigFoodTimer);

                if(firstTimeBigFood == 0)
                {
                    snakeGameLogic.generateFoodCoord(ref bigFood, this.Width, this.Height);
                    firstTimeBigFood++;
                    Global.eventBigFoodIsWritten = 1; //serve per disegnare il bigFood o avviene un bug grafico
                }
                else
                {
                    bigFoodTimer--;
                }

                if (snkHead.IntersectsWith(bigFood))
                {
                    Global.eventBigFoodInc = 0;
                    snakeGameLogic.addTail(direzione, snkTail);
                    snakeGameLogic.addTail(direzione, snkTail);
                    snakeGameLogic.addTail(direzione, snkTail);
                    snakeGameLogic.addTail(direzione, snkTail);
                    snakeGameLogic.addTail(direzione, snkTail);
                    Global.punti += 5;
                    Global.eventBigFoodIsWritten = 0;


                    if (Global.volume == true)
                    {
                        snakeGameLogic.generateSound(@"snakeBigFood.wav");
                    }
                }
                if (bigFoodTimer <= 0)
                {
                    Global.eventBigFoodInc = 0;
                    bigFoodTimer = 30;
                    bigFoodTimer_lbl.Text = "";
                }
            }
            else
            {
                firstTimeBigFood = 0;
                bigFoodTimer = 30;
                bigFoodTimer_lbl.Text = "";
            }
            
            if (snkHead.IntersectsWith(food))
            {
                snakeGameLogic.generateFoodCoord(ref food, this.Width, this.Height); //genera nuove coordinate per cibo

                Global.eventBigFoodInc++; //quando arriva a 5 concede 5 punti
                if (Global.livello == 1) Global.punti++; //incrementa punti
                else if (Global.livello == 2) Global.punti += 2;
                else if(Global.livello == 3)
                {

                }
                else { _ = "";  }

                if (Global.volume == true)
                {
                    snakeGameLogic.generateSound(@"snakeFood.wav");
                }
                

                if (timer1.Interval > Global.difficoltaMinimaTic)
                {
                    timer1.Interval -= 2; //aumenta la difficoltà
                }

                if(Global.livello == 1)
                {
                    //generaCoda
                    if (snkTail.Count > 0)
                    {
                        snakeGameLogic.addTail(direzione, snkTail);
                    }
                    else
                    {
                        snakeGameLogic.addTailFromHead(direzione, snkTail, snkHead);
                    }
                }
                else if(Global.livello == 2)
                {
                    //generaCoda
                    if (snkTail.Count > 0)
                    {
                        snakeGameLogic.addTail(direzione, snkTail);
                        snakeGameLogic.addTail(direzione, snkTail);
                    }
                    else
                    {
                        snakeGameLogic.addTailFromHead(direzione, snkTail, snkHead);
                    }
                }

                
            }

            if (snkTail.Count > 0) //metodologia di refresh della coda 
            {
                snakeGameLogic.drawTailLogic(snkTail, snkHead);
            }

            //movimento testa per ultimo
            switch (direzione)
            {
                case "sopra": snkHead.Y -= 20; break;
                case "sotto": snkHead.Y += 20; break;
                case "sinistra": snkHead.X -= 20; break;
                case "destra": snkHead.X += 20; break;
            }

            //condizione per perdere:
            if (snkHead.X >= this.Width || snkHead.Y >= this.Height || snkHead.X < 0 || snkHead.Y < 0) //se esce fuori dalla mappa di gioco
            {
                Global.punti = 0;
                Global.eventBigFoodInc = 0;
                if (Global.volume == true) snakeGameLogic.generateSound(@"snakeDead.wav");
                Thread.Sleep(2000);
                this.Dispose();
            }
            foreach (Rectangle coda in snkTail) //se la testa tocca la coda
            {
                if (snkHead.IntersectsWith(coda))
                {
                    Global.punti = 0;
                    Global.eventBigFoodInc = 0;
                    if (Global.volume == true) snakeGameLogic.generateSound(@"snakeDead.wav");
                    Thread.Sleep(2000);
                    this.Dispose();
                }
            }

            //scrittura punti accumulati sopra a sinistra
            punti_lbl.Text = (string)("" + Global.punti);

            this.Invalidate(); //refresh grafico
        }

        private void punti_lbl_Click(object sender, EventArgs e)
        {

        }

    }
}
