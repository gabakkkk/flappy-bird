using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybird
{
    public partial class Form1 : Form
    {
        int boruHızı = 8;
        int gravity = 10;
        int score = 0;

        public Form1()

        {
            InitializeComponent();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -10;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Kus.Top += gravity;
            BoruAlt.Left -= boruHızı;
            BoruUst.Left -= boruHızı;
            scoreText.Text = "Score:" + score;
            if(BoruAlt.Left<-150)
            {
                BoruAlt.Left = 800;
            }
            if (BoruUst.Left < -180)
            {
                BoruUst.Left = 900;
                score++;
            }
            if (Kus.Bounds.IntersectsWith(BoruAlt.Bounds) || Kus.Bounds.IntersectsWith(BoruUst.Bounds) || Kus.Bounds.IntersectsWith(Zemin.Bounds))
                {
                endGame();
                }
            if(score>5)
            {
                boruHızı = 15;
            }
            if(Kus.Top<-25)
            {
                endGame();
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game over";
        }
   
    }
}

