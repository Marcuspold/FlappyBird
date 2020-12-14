using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int PipeSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void timer1_tick(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeTop.Left -= PipeSpeed;
            PipeTop2.Left -= PipeSpeed;
            ScoreLabel.Text = $"score:{score}";

            if(PipeTop.Left < -100)
            {
                PipeTop.Left = 500;
                score++;
            }

            if(PipeTop2.Right < -100)
            {
                PipeTop2.Left = 600;
                score++;
            }

            if(Bird.Top < -25)
            {
                GameOver();
            }

            if (Bird.Bounds.IntersectsWith(PipeTop.Bounds) || Bird.Bounds.IntersectsWith(PipeTop2.Bounds) ||
                Bird.Bounds.IntersectsWith(Grounds.Bounds))
            {
                GameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void GameOver()
        {
            timer1.Stop();
            ScoreLabel.Text = $"Game Over You Lose ";
            PlayAgain.Visible = true;
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Form1 NewFore = new Form1();
            NewFore.Show();
            this.Dispose(false);
        }
    }
}
