using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCarGamev1
{
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            overz.Visible = false;
            overImage.Visible = false;
            button1.Visible = false;
            boomBox.Visible = false;
            missle.Visible = false;
            missleBoom.Visible = false;
            scoreText.Visible = false;
            score = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gamespeed);
            enemy(gamespeed);
            showText();
            over();
        }

        void moveLine(int speed)
        {
            if(pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

           

            
        }

        void sendMissle()
        {
            missle.Visible = true;

            if (missle.Top <= 5)
            {
                missle.Visible = false;
                timer2.Enabled = false;
            }
            else
            {
                missle.Top -= 5;
            }

            
            
        }


        int gamespeed=0;
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(batmobile.Left>8)
                batmobile.Left += -10;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(batmobile.Left<333)
                batmobile.Left += 10;
            }

            if(e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }


            }

            if(e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }


            if (e.KeyCode == Keys.Space)
            {
                missle.Location = new Point(batmobile.Location.X + 10,batmobile.Location.Y);
                timer2.Enabled = true;
                sendMissle();
                               
            }

        }

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(0,200);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }
            if (enemy3.Top >= 500)
            {
                x = r.Next(200, 350);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sendMissle();
        }

        void showText()
        {
            this.Text = "Will Batmobile Escape?? Your Score : " + score.ToString(); 
        }

        void over()
        {

            if (missle.Bounds.IntersectsWith(enemy1.Bounds))
            {
                int locX = r.Next(0, 200);
                int midX = Math.Abs(enemy1.Size.Width / 2);
                int midY = Math.Abs(enemy1.Size.Height / 2);

                missleBoom.Visible = true;
                missleBoom.Location = new Point(midX - 26, midY - 26);

                missleBoom.Visible = false;
                enemy1.Location = new Point(locX, 0);

                score++;
                
            }
            if (missle.Bounds.IntersectsWith(enemy2.Bounds))
            {
                int locX = r.Next(0, 200);
                int midX = Math.Abs(enemy2.Size.Width / 2);
                int midY = Math.Abs(enemy2.Size.Height / 2);

                missleBoom.Visible = true;
                missleBoom.Location = new Point(midX - 26, midY - 26);

                missleBoom.Visible = false;
                enemy2.Location = new Point(locX, 0);
                score++;
            }
            if (missle.Bounds.IntersectsWith(enemy3.Bounds))
            {
                int locX = r.Next(0, 200);
                int midX = Math.Abs(enemy3.Size.Width / 2);
                int midY = Math.Abs(enemy3.Size.Height / 2);

                missleBoom.Visible = true;
                missleBoom.Location = new Point(midX - 26, midY - 26);

                missleBoom.Visible = false;
                enemy3.Location = new Point(locX, 0);
                score++;
            }


            if (batmobile.Bounds.IntersectsWith(enemy1.Bounds))
            {
                
                timer1.Enabled = false;
                overz.Visible = true;
                overImage.Visible = true;
                button1.Visible = true;
                int midpointOfX = Math.Abs(batmobile.Bounds.Left + batmobile.Bounds.Right) / 2;
                boomBox.Location = new Point(midpointOfX - 26, batmobile.Bounds.Y - 26);
                boomBox.Visible = true;
                scoreText.Text = "Your Score : " + score.ToString();
                scoreText.Visible = true;
            }

            if (batmobile.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                overz.Visible = true;
                overImage.Visible = true;
                button1.Visible = true;
                int midpointOfX = Math.Abs(batmobile.Bounds.Left + batmobile.Bounds.Right) / 2;
                boomBox.Location = new Point(midpointOfX - 26, batmobile.Bounds.Y - 26);
                boomBox.Visible = true;
                scoreText.Text = "Your Score : " + score.ToString();
                scoreText.Visible = true;
            }

            if (batmobile.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                overz.Visible = true;
                overImage.Visible = true;
                button1.Visible = true;
                int midpointOfX = Math.Abs(batmobile.Bounds.Left + batmobile.Bounds.Right) / 2;
                boomBox.Location = new Point(midpointOfX -26 , batmobile.Bounds.Y - 26);
                boomBox.Visible = true;
                scoreText.Text = "Your Score : " + score.ToString();
                scoreText.Visible = true;
            }
        }


    }
}
