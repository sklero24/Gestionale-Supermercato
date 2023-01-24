using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class snakeOptions : Form
    {

        string livello1_txt = "LIVELLO 1: \n FACILE";
        string livello2_txt = "LIVELLO 2: \n 2X";
        string livello3_txt = "LIVELLO 3: \n OSTACOLI";

        public void controlloColori()
        {
            //settaggio volume
            if (Global.volume == true)
            {
                volume_btn.Text = "VOLUME ON";
                volume_btn.BackColor = Color.Lime;
            }
            else
            {
                volume_btn.Text = "VOLUME OFF";
                volume_btn.BackColor = Color.OrangeRed;
            }

            //settaggio livello
            if (Global.livello == 1)
            {
                livello_btn.Text = livello1_txt;
                livello_btn.BackColor = Color.Lime;

            }
            else if (Global.livello == 2)
            {
                livello_btn.Text = livello2_txt;
                livello_btn.BackColor = Color.Orange;
            }
            else
            {
                livello_btn.Text = livello3_txt;
                livello_btn.BackColor = Color.OrangeRed;

            }
        }
        public snakeOptions()
        {
            InitializeComponent();
            //Controlli vari dei colori e testo di impostazione
            controlloColori();

            //if (Global.volume == true) snakeGameLogic.playSoundLoop(@"snakeOptions.wav");
        }

        private void volume_btn_Click(object sender, EventArgs e)
        {
            if (Global.volume == true)
            {
                Global.volume = false;
                volume_btn.Text = "VOLUME OFF";
                volume_btn.BackColor = Color.OrangeRed;
            }
            else
            {
                Global.volume = true;
                volume_btn.Text = "VOLUME ON";
                volume_btn.BackColor = Color.Lime;
            }
        }

        private void livello_btn_Click(object sender, EventArgs e)
        {
            if(Global.livello == 1)
            {
                Global.livello++;
                livello_btn.Text = livello2_txt;
                livello_btn.BackColor = Color.Orange;
            }
            else if(Global.livello == 2)
            {
                Global.livello++;
                livello_btn.Text = livello3_txt;
                livello_btn.BackColor = Color.OrangeRed;
            }
            else
            {
                Global.livello = 1;
                livello_btn.Text = livello1_txt;
                livello_btn.BackColor = Color.Lime;
            }
        }

        private void esci_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
