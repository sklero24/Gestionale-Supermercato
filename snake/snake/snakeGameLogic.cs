using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public static class snakeGameLogic
    {
        public static SoundPlayer foodSound;
        public static void generaCoordinateRand(ref int x, ref int y, int Width, int Height)
        {
            Random r = new Random();
            x = r.Next(100, Width - 100);
            y = r.Next(100, Height - 100);
        }

        public static void generateFoodCoord(ref Rectangle food, int Width, int Height)
        {
            int x = 0, y = 0;
            generaCoordinateRand(ref x, ref y, Width, Height);
            food.X = x;
            food.Y = y;
        }

        public static void generateSound(string path)
        {
            try
            {
                foodSound = new SoundPlayer();
                foodSound.LoadAsync();
                foodSound.SoundLocation = path;
                foodSound.Play();

                foodSound.Dispose();
            }
            catch (Exception ex)
            {
                _ = "";
            }
        }

        public static void playSoundLoop(string path)
        {
            try
            {
                foodSound = new SoundPlayer();
                foodSound.LoadAsync();
                foodSound.SoundLocation = path;
                foodSound.PlayLooping();
            }
            catch (Exception ex)
            {
                _ = "";
            }
        }

        public static void stopSound()
        {
            foodSound.Stop();
            foodSound.Dispose();
        }

        public static void addTail (string direzione, List<Rectangle> snkTail)
        {
            switch (direzione)
            {
                case "sopra": snkTail.Add(new Rectangle(snkTail[snkTail.Count - 1].X, snkTail[snkTail.Count - 1].Y - 20, 20, 20)); break;
                case "sotto": snkTail.Add(new Rectangle(snkTail[snkTail.Count - 1].X, snkTail[snkTail.Count - 1].Y + 20, 20, 20)); break;
                case "sinistra": snkTail.Add(new Rectangle(snkTail[snkTail.Count - 1].X - 20, snkTail[snkTail.Count - 1].Y, 20, 20)); break;
                case "destra": snkTail.Add(new Rectangle(snkTail[snkTail.Count - 1].X + 20, snkTail[snkTail.Count - 1].Y, 20, 20)); break;
            }
        }

        public static void addTailFromHead(string direzione, List<Rectangle> snkTail, Rectangle snkHead) //per il primo pezzo della coda
        {
            switch (direzione)
            {
                case "sopra": snkTail.Add(new Rectangle(snkHead.X, snkHead.Y - 20, 20, 20)); break;
                case "sotto": snkTail.Add(new Rectangle(snkHead.X, snkHead.Y + 20, 20, 20)); break;
                case "sinistra": snkTail.Add(new Rectangle(snkHead.X - 20, snkHead.Y, 20, 20)); break;
                case "destra": snkTail.Add(new Rectangle(snkHead.X + 20, snkHead.Y, 20, 20)); break;
            }
        }

        public static void drawTailLogic(List<Rectangle> snkTail, Rectangle snkHead)
        {
            for (int i = snkTail.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Rectangle tempP = snkHead;
                    Rectangle tempP2 = snkTail[i];

                    tempP2.X = tempP.X;
                    tempP2.Y = tempP.Y;

                    snkTail[i] = tempP2;

                    break;
                }

                Rectangle temp = snkTail[i];
                Rectangle temp2 = snkTail[i - 1];
                temp.X = temp2.X;
                temp.Y = temp2.Y;

                snkTail[i] = temp;
            }
        }
    }
}