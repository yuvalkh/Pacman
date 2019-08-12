using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        private int gr = 0;
        private int gb = 0;
        private int gp = 0;
        private int go = 0;
        private int counter = 0;
        private Point playerspot = new Point(14, 22);
        private Point OrangeGhost = new Point(11, 12);
        private Point PinkGhost = new Point(11, 14);
        private Point RedGhost = new Point(16, 12);
        private Point BlueGhost = new Point(16, 14);
        private Random rnd = new Random();
        private Image orangeprevimg = Image.FromFile(@"Pic/Dot.jpg");
        private Image blueprevimg = Image.FromFile(@"Pic/Dot.jpg");
        private Image redprevimg = Image.FromFile(@"Pic/Dot.jpg");
        private Image pinkprevimg = Image.FromFile(@"Pic/Dot.jpg");
        private int score = 0;
        private string key = "";
        private PictureBox[,] maze = new PictureBox[28, 30];
        private int top = 30;
        private int left = 0;
        public Form1()
        {
            this.BackColor = Color.Black;
            InitializeComponent();
            Print();
            colors();
            maze[14, 22].Image = Image.FromFile(@"Pic/PacmanStand.jpg");
            maze[11, 12].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
            maze[11, 14].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
            maze[16, 12].Image = Image.FromFile(@"Pic/RedGhost.jpg");
            maze[16, 14].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
            maze[0, 13].Image = null;
            maze[1, 13].Image = null;
            maze[2, 13].Image = null;
            maze[13, 11].Image = null;
            maze[14, 11].Image = null;
            maze[25, 13].Image = null;
            maze[26, 13].Image = null;
            maze[27, 13].Image = null;
        }
        public bool GameOver(Point playerspot, Point name, PictureBox[,] maze)
        {
            if (playerspot.X == name.X && playerspot.Y == name.Y)
            {
                score -= 5;
                return true;
            }
            if (score == 1415)
            {
                return true;
            }
            return false;
        }
        public void MoveOrange()
        {
            go = rnd.Next(1, 5);
            if (go == 1)//up
            {
                if (maze[OrangeGhost.X, OrangeGhost.Y - 1].BackColor == Color.Black && maze[OrangeGhost.X, OrangeGhost.Y - 1] != maze[BlueGhost.X, BlueGhost.Y] && maze[OrangeGhost.X, OrangeGhost.Y - 1] != maze[RedGhost.X, RedGhost.Y] && maze[OrangeGhost.X, OrangeGhost.Y - 1] != maze[PinkGhost.X, PinkGhost.Y])
                {
                    orangeprevimg = maze[OrangeGhost.X, OrangeGhost.Y - 1].Image;
                    maze[OrangeGhost.X, OrangeGhost.Y].Image = orangeprevimg;
                    OrangeGhost.Y--;
                    maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
                }
            }
            if (go == 2)//right
            {
                if (OrangeGhost.X < 27)
                {
                    if (maze[OrangeGhost.X + 1, OrangeGhost.Y].BackColor == Color.Black && maze[OrangeGhost.X + 1, OrangeGhost.Y] != maze[BlueGhost.X, BlueGhost.Y] && maze[OrangeGhost.X + 1, OrangeGhost.Y] != maze[RedGhost.X, RedGhost.Y] && maze[OrangeGhost.X + 1, OrangeGhost.Y] != maze[PinkGhost.X, PinkGhost.Y])
                    {
                        orangeprevimg = maze[OrangeGhost.X + 1, OrangeGhost.Y].Image;
                        maze[OrangeGhost.X, OrangeGhost.Y].Image = orangeprevimg;
                        OrangeGhost.X++;
                        maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
                    }
                }
                else
                {
                    maze[27, OrangeGhost.Y].Image = null;
                    OrangeGhost.X = 0;
                    maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
                }
            }
            if (go == 3)//down
            {
                if (maze[OrangeGhost.X, OrangeGhost.Y + 1].BackColor == Color.Black && maze[OrangeGhost.X, OrangeGhost.Y + 1] != maze[BlueGhost.X, BlueGhost.Y] && maze[OrangeGhost.X, OrangeGhost.Y + 1] != maze[RedGhost.X, RedGhost.Y] && maze[OrangeGhost.X, OrangeGhost.Y + 1] != maze[PinkGhost.X, PinkGhost.Y])
                {

                    orangeprevimg = maze[OrangeGhost.X, OrangeGhost.Y + 1].Image;
                    maze[OrangeGhost.X, OrangeGhost.Y].Image = orangeprevimg;
                    OrangeGhost.Y++;
                    maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
                }
            }
            if (go == 4)//left
            {
                if (OrangeGhost.X > 0)
                {
                    if (maze[OrangeGhost.X - 1, OrangeGhost.Y].BackColor == Color.Black && maze[OrangeGhost.X - 1, OrangeGhost.Y] != maze[BlueGhost.X, BlueGhost.Y] && maze[OrangeGhost.X - 1, OrangeGhost.Y] != maze[RedGhost.X, RedGhost.Y] && maze[OrangeGhost.X - 1, OrangeGhost.Y] != maze[PinkGhost.X, PinkGhost.Y])
                    {

                        orangeprevimg = maze[OrangeGhost.X - 1, OrangeGhost.Y].Image;
                        maze[OrangeGhost.X, OrangeGhost.Y].Image = orangeprevimg;
                        OrangeGhost.X--;
                        maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
                    }
                }
                else
                {
                    maze[0, OrangeGhost.Y].Image = null;
                    OrangeGhost.X = 27;
                    maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
                }
            }
            if (GameOver(playerspot, OrangeGhost, maze))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Gameover!! Your score is: " + score);
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Restart", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        public void MoveRed()
        {
            gr = rnd.Next(1, 5);
            if (gr == 1)//up
            {
                if (maze[RedGhost.X, RedGhost.Y - 1].BackColor == Color.Black && maze[RedGhost.X, RedGhost.Y - 1] != maze[BlueGhost.X, BlueGhost.Y] && maze[RedGhost.X, RedGhost.Y - 1] != maze[PinkGhost.X, PinkGhost.Y] && maze[RedGhost.X, RedGhost.Y - 1] != maze[OrangeGhost.X, OrangeGhost.Y])
                {
                    redprevimg = maze[RedGhost.X, RedGhost.Y - 1].Image;
                    maze[RedGhost.X, RedGhost.Y].Image = redprevimg;
                    RedGhost.Y--;
                    maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/RedGhost.jpg");
                }
            }
            if (gr == 2)//right
            {
                if (RedGhost.X < 27)
                {
                    if (maze[RedGhost.X + 1, RedGhost.Y].BackColor == Color.Black && maze[RedGhost.X + 1, RedGhost.Y] != maze[BlueGhost.X, BlueGhost.Y] && maze[RedGhost.X + 1, RedGhost.Y] != maze[PinkGhost.X, PinkGhost.Y] && maze[RedGhost.X + 1, RedGhost.Y] != maze[OrangeGhost.X, OrangeGhost.Y])
                    {
                        redprevimg = maze[RedGhost.X + 1, RedGhost.Y].Image;
                        maze[RedGhost.X, RedGhost.Y].Image = redprevimg;
                        RedGhost.X++;
                        maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/RedGhost.jpg");
                    }
                }
                else
                {
                    maze[27, RedGhost.Y].Image = null;
                    RedGhost.X = 0;
                    maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/RedGhost.jpg");
                }
            }
            if (gr == 3)//down
            {
                if (maze[RedGhost.X, RedGhost.Y + 1].BackColor == Color.Black && maze[RedGhost.X, RedGhost.Y + 1] != maze[BlueGhost.X, BlueGhost.Y] && maze[RedGhost.X, RedGhost.Y + 1] != maze[PinkGhost.X, PinkGhost.Y] && maze[RedGhost.X, RedGhost.Y + 1] != maze[OrangeGhost.X, OrangeGhost.Y])
                {
                    redprevimg = maze[RedGhost.X, RedGhost.Y + 1].Image;
                    maze[RedGhost.X, RedGhost.Y].Image = redprevimg;
                    RedGhost.Y++;
                    maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/RedGhost.jpg");
                }
            }
            if (gr == 4)//left
            {
                if (RedGhost.X > 0)
                {
                    if (maze[RedGhost.X - 1, RedGhost.Y].BackColor == Color.Black && maze[RedGhost.X - 1, RedGhost.Y] != maze[BlueGhost.X, BlueGhost.Y] && maze[RedGhost.X - 1, RedGhost.Y] != maze[PinkGhost.X, PinkGhost.Y] && maze[RedGhost.X - 1, RedGhost.Y] != maze[OrangeGhost.X, OrangeGhost.Y])
                    {
                        redprevimg = maze[RedGhost.X - 1, RedGhost.Y].Image;
                        maze[RedGhost.X, RedGhost.Y].Image = redprevimg;
                        RedGhost.X--;
                        maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/RedGhost.jpg");
                    }
                }
                else
                {
                    maze[0, RedGhost.Y].Image = null;
                    RedGhost.X = 27;
                    maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/RedGhost.jpg");
                }
            }
            if (GameOver(playerspot, RedGhost, maze))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Gameover!! Your score is: " + score);
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Restart", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        public void MovePink()
        {
            gp = rnd.Next(1, 5);
            if (gp == 1)//up
            {
                if (maze[PinkGhost.X, PinkGhost.Y - 1].BackColor == Color.Black && maze[PinkGhost.X, PinkGhost.Y - 1] != maze[BlueGhost.X, BlueGhost.Y] && maze[PinkGhost.X, PinkGhost.Y - 1] != maze[RedGhost.X, RedGhost.Y] && maze[PinkGhost.X, PinkGhost.Y - 1] != maze[OrangeGhost.X, OrangeGhost.Y])
                {
                    pinkprevimg = maze[PinkGhost.X, PinkGhost.Y - 1].Image;
                    maze[PinkGhost.X, PinkGhost.Y].Image = pinkprevimg;
                    PinkGhost.Y--;
                    maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
                }
            }
            if (gp == 2)//right
            {
                if (PinkGhost.X < 27)
                {
                    if (maze[PinkGhost.X + 1, PinkGhost.Y].BackColor == Color.Black && maze[PinkGhost.X + 1, PinkGhost.Y] != maze[BlueGhost.X, BlueGhost.Y] && maze[PinkGhost.X + 1, PinkGhost.Y] != maze[RedGhost.X, RedGhost.Y] && maze[PinkGhost.X + 1, PinkGhost.Y] != maze[OrangeGhost.X, OrangeGhost.Y])
                    {
                        pinkprevimg = maze[PinkGhost.X + 1, PinkGhost.Y].Image;
                        maze[PinkGhost.X, PinkGhost.Y].Image = pinkprevimg;
                        PinkGhost.X++;
                        maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
                    }
                }
                else
                {
                    maze[27, PinkGhost.Y].Image = null;
                    PinkGhost.X = 0;
                    maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
                }
            }
            if (gp == 3)//down
            {
                if (maze[PinkGhost.X, PinkGhost.Y + 1].BackColor == Color.Black && maze[PinkGhost.X, PinkGhost.Y + 1] != maze[BlueGhost.X, BlueGhost.Y] && maze[PinkGhost.X, PinkGhost.Y + 1] != maze[RedGhost.X, RedGhost.Y] && maze[PinkGhost.X, PinkGhost.Y + 1] != maze[OrangeGhost.X, OrangeGhost.Y])
                {
                    pinkprevimg = maze[PinkGhost.X, PinkGhost.Y + 1].Image;
                    maze[PinkGhost.X, PinkGhost.Y].Image = pinkprevimg;
                    PinkGhost.Y++;
                    maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
                }
            }
            if (gp == 4)//left
            {
                if (PinkGhost.X > 0)
                {
                    if (maze[PinkGhost.X - 1, PinkGhost.Y].BackColor == Color.Black && maze[PinkGhost.X - 1, PinkGhost.Y] != maze[BlueGhost.X, BlueGhost.Y] && maze[PinkGhost.X - 1, PinkGhost.Y] != maze[RedGhost.X, RedGhost.Y] && maze[PinkGhost.X - 1, PinkGhost.Y] != maze[OrangeGhost.X, OrangeGhost.Y])
                    {
                        pinkprevimg = maze[PinkGhost.X - 1, PinkGhost.Y].Image;
                        maze[PinkGhost.X, PinkGhost.Y].Image = pinkprevimg;
                        PinkGhost.X--;
                        maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
                    }
                }
                else
                {
                    maze[0, PinkGhost.Y].Image = null;
                    PinkGhost.X = 27;
                    maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
                }
            }
            if (GameOver(playerspot, PinkGhost, maze))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Gameover!! Your score is: " + score);
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Restart", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        public void MoveBlue()
        {
            gb = rnd.Next(1, 5);
            if (gb == 1)//up
            {
                if (maze[BlueGhost.X, BlueGhost.Y - 1].BackColor == Color.Black && maze[BlueGhost.X, BlueGhost.Y - 1] != maze[PinkGhost.X, PinkGhost.Y] && maze[BlueGhost.X, BlueGhost.Y - 1] != maze[RedGhost.X, RedGhost.Y] && maze[BlueGhost.X, BlueGhost.Y - 1] != maze[OrangeGhost.X, OrangeGhost.Y])
                {
                    blueprevimg = maze[BlueGhost.X, BlueGhost.Y - 1].Image;
                    maze[BlueGhost.X, BlueGhost.Y].Image = blueprevimg;
                    BlueGhost.Y--;
                    maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
                }
            }
            if (gb == 2)//right
            {
                if (BlueGhost.X < 27)
                {
                    if (maze[BlueGhost.X + 1, BlueGhost.Y].BackColor == Color.Black && maze[BlueGhost.X + 1, BlueGhost.Y] != maze[PinkGhost.X, PinkGhost.Y] && maze[BlueGhost.X + 1, BlueGhost.Y] != maze[RedGhost.X, RedGhost.Y] && maze[BlueGhost.X + 1, BlueGhost.Y] != maze[OrangeGhost.X, OrangeGhost.Y])
                    {
                        blueprevimg = maze[BlueGhost.X + 1, BlueGhost.Y].Image;
                        maze[BlueGhost.X, BlueGhost.Y].Image = blueprevimg;
                        BlueGhost.X++;
                        maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
                    }
                }
                else
                {
                    maze[27, BlueGhost.Y].Image = null;
                    BlueGhost.X = 0;
                    maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
                }
            }
            if (gb == 3)//down
            {
                if (maze[BlueGhost.X, BlueGhost.Y + 1].BackColor == Color.Black && maze[BlueGhost.X, BlueGhost.Y + 1] != maze[PinkGhost.X, PinkGhost.Y] && maze[BlueGhost.X, BlueGhost.Y + 1] != maze[RedGhost.X, RedGhost.Y] && maze[BlueGhost.X, BlueGhost.Y + 1] != maze[OrangeGhost.X, OrangeGhost.Y])
                {
                    blueprevimg = maze[BlueGhost.X, BlueGhost.Y + 1].Image;
                    maze[BlueGhost.X, BlueGhost.Y].Image = blueprevimg;
                    BlueGhost.Y++;
                    maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
                }
            }
            if (gb == 4)//left
            {
                if (BlueGhost.X > 0)
                {
                    if (maze[BlueGhost.X - 1, BlueGhost.Y].BackColor == Color.Black && maze[BlueGhost.X - 1, BlueGhost.Y] != maze[PinkGhost.X, PinkGhost.Y] && maze[BlueGhost.X - 1, BlueGhost.Y] != maze[RedGhost.X, RedGhost.Y] && maze[BlueGhost.X - 1, BlueGhost.Y] != maze[OrangeGhost.X, OrangeGhost.Y])
                    {
                        blueprevimg = maze[BlueGhost.X - 1, BlueGhost.Y].Image;
                        maze[BlueGhost.X, BlueGhost.Y].Image = blueprevimg;
                        BlueGhost.X--;
                        maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
                    }
                }
                else
                {
                    maze[0, BlueGhost.Y].Image = null;
                    BlueGhost.X = 27;
                    maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
                }
            }
            if (GameOver(playerspot, BlueGhost, maze))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Gameover!! Your score is: " + score);
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Restart", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        public void colors()
        {
            for (int i = 0; i < 28; i++)
            {
                maze[i, 0].BackColor = Color.Blue;
                maze[i, 29].BackColor = Color.Blue;
                maze[i, 0].Image = null;
                maze[i, 29].Image = null;
            }
            for (int i = 0; i < 30; i++)
            {
                if (i != 13)
                {
                    maze[0, i].BackColor = Color.Blue;
                    maze[27, i].BackColor = Color.Blue;
                    maze[0, i].Image = null;
                    maze[27, i].Image = null;
                }
            }

            for (int i = 0; i < 27; i++)//1
            {
                if (i == 13 || i == 14)
                {
                    maze[i, 1].BackColor = Color.Blue;
                    maze[i, 1].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//2 3
            {
                if (i != 1 && i != 6 && i != 12 && i != 15 && i != 21 && i != 26)
                {
                    maze[i, 2].BackColor = Color.Blue;
                    maze[i, 3].BackColor = Color.Blue;
                    maze[i, 2].Image = null;
                    maze[i, 3].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)// 5 6
            {
                if (i != 1 && i != 6 && i != 9 && i != 18 && i != 21 && i != 26)
                {
                    maze[i, 5].BackColor = Color.Blue;
                    maze[i, 6].BackColor = Color.Blue;
                    maze[i, 5].Image = null;
                    maze[i, 6].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//7
            {
                if (i == 7 || i == 8 || i == 13 || i == 14 || i == 19 || i == 20)
                {
                    maze[i, 7].BackColor = Color.Blue;
                    maze[i, 7].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//8 9
            {
                if (i != 6 && i != 12 && i != 15 && i != 21)
                {
                    maze[i, 8].BackColor = Color.Blue;
                    maze[i, 9].BackColor = Color.Blue;
                    maze[i, 8].Image = null;
                    maze[i, 9].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//10
            {
                if (i != 6 && i != 9 && i != 10 && i != 11 && i != 12 && i != 13 && i != 14 && i != 15 && i != 16 && i != 17 && i != 18 && i != 21)
                {
                    maze[i, 10].BackColor = Color.Blue;
                    maze[i, 10].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//11
            {
                if (i != 6 && i != 9 && i != 13 && i != 14 && i != 18 && i != 21)
                {
                    maze[i, 11].BackColor = Color.Blue;
                    maze[i, 11].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//12
            {
                if (i != 6 && i != 9 && i != 11 && i != 12 && i != 13 && i != 14 && i != 15 && i != 16 && i != 18 && i != 21)
                {
                    maze[i, 12].BackColor = Color.Blue;
                    maze[i, 12].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//13
            {
                if (i == 10 || i == 17)
                {
                    maze[i, 13].BackColor = Color.Blue;
                    maze[i, 13].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//14
            {
                if (i != 6 && i != 9 && i != 11 && i != 12 && i != 13 && i != 14 && i != 15 && i != 16 && i != 18 && i != 21)
                {
                    maze[i, 14].BackColor = Color.Blue;
                    maze[i, 14].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//15
            {
                if (i != 6 && i != 9 && i != 18 && i != 21)
                {
                    maze[i, 15].BackColor = Color.Blue;
                    maze[i, 15].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//16
            {
                if (i != 6 && i != 9 && i != 10 && i != 11 && i != 12 && i != 13 && i != 14 && i != 15 && i != 16 && i != 17 && i != 18 && i != 21)
                {
                    maze[i, 16].BackColor = Color.Blue;
                    maze[i, 16].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//17 18
            {
                if (i != 6 && i != 9 && i != 18 && i != 21)
                {
                    maze[i, 17].BackColor = Color.Blue;
                    maze[i, 18].BackColor = Color.Blue;
                    maze[i, 17].Image = null;
                    maze[i, 18].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//19
            {
                if (i == 13 || i == 14)
                {
                    maze[i, 19].BackColor = Color.Blue;
                    maze[i, 19].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//20 21
            {
                if (i != 1 && i != 6 && i != 12 && i != 15 && i != 21 && i != 26)
                {
                    maze[i, 20].BackColor = Color.Blue;
                    maze[i, 21].BackColor = Color.Blue;
                    maze[i, 20].Image = null;
                    maze[i, 21].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//22
            {
                if (i == 4 || i == 5 || i == 22 || i == 23)
                {
                    maze[i, 22].BackColor = Color.Blue;
                    maze[i, 22].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//23 24
            {
                if (i != 3 && i != 6 && i != 9 && i != 18 && i != 21 && i != 24)
                {
                    maze[i, 23].BackColor = Color.Blue;
                    maze[i, 24].BackColor = Color.Blue;
                    maze[i, 23].Image = null;
                    maze[i, 24].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//25
            {
                if (i == 7 || i == 8 || i == 13 || i == 14 || i == 19 || i == 20)
                {
                    maze[i, 25].BackColor = Color.Blue;
                    maze[i, 25].Image = null;
                }
            }
            for (int i = 0; i < 27; i++)//26 27
            {
                if (i != 1 && i != 12 && i != 15 && i != 26)
                {
                    maze[i, 26].BackColor = Color.Blue;
                    maze[i, 27].BackColor = Color.Blue;
                    maze[i, 26].Image = null;
                    maze[i, 27].Image = null;
                }
            }
            for (int i = 11; i < 17; i++)
            {
                maze[i, 12].Image = null;
                maze[i, 13].Image = null;
                maze[i, 14].Image = null;
            }
        }
        public void Print()
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    maze[i, j] = new PictureBox();
                    maze[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    maze[i, j].Width = 25;
                    maze[i, j].Height = 25;
                    maze[i, j].Top = top;
                    maze[i, j].Left = left;
                    //maze[i, j].BorderStyle = BorderStyle.Fixed3D;
                    maze[i, j].Image = Image.FromFile(@"Pic/Dot.jpg");
                    this.Controls.Add(maze[i, j]);
                    top += 25;
                }
                top = 30;
                left += 25;
            }
        }
        private void eZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer3.Interval = 700;
        }
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer3.Interval = 300;
        }
        private void hard4MeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer3.Interval = 100;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Your score is: " + score.ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (key)
            {

                case "Right":
                    {
                        if (playerspot.X < 27)
                        {
                            maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanRight.jpg");
                            if (maze[playerspot.X + 1, playerspot.Y].BackColor != Color.Blue)
                            {
                                if (maze[playerspot.X + 1, playerspot.Y].Image != null)
                                {
                                    score += 5;
                                }
                                maze[playerspot.X, playerspot.Y].Image = null;
                                playerspot.X++;
                                maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanRight.jpg");
                            }
                        }
                        else
                        {
                            maze[27, playerspot.Y].Image = null;
                            playerspot.X = 0;
                            maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanRight.jpg");
                        }
                        break;
                    }
                case "Left":
                    {
                        if (playerspot.X > 0)
                        {
                            maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanLeft.jpg");
                            if (maze[playerspot.X - 1, playerspot.Y].BackColor != Color.Blue)
                            {
                                if (maze[playerspot.X - 1, playerspot.Y].Image != null)
                                {
                                    score += 5;
                                }
                                maze[playerspot.X, playerspot.Y].Image = null;
                                playerspot.X--;
                                maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanLeft.jpg");
                            }
                        }
                        else
                        {
                            maze[0, playerspot.Y].Image = null;
                            playerspot.X = 27;
                            maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanLeft.jpg");
                        }
                        break;
                    }
                case "Up":
                    {
                        if (playerspot.Y > 0)
                        {
                            maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanUp.jpg");
                            if (maze[playerspot.X, playerspot.Y - 1].BackColor != Color.Blue)
                            {
                                if (maze[playerspot.X, playerspot.Y - 1].Image != null)
                                {
                                    score += 5;
                                }
                                maze[playerspot.X, playerspot.Y].Image = null;
                                playerspot.Y--;
                                maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanUp.jpg");
                            }
                        }
                        break;
                    }
                case "Down":
                    {
                        if (playerspot.Y < 29)
                        {
                            maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanDown.jpg");
                            if (maze[playerspot.X, playerspot.Y + 1].BackColor != Color.Blue)
                            {
                                if (maze[playerspot.X, playerspot.Y + 1].Image != null)
                                {
                                    score += 5;
                                }
                                maze[playerspot.X, playerspot.Y].Image = null;
                                playerspot.Y++;
                                maze[playerspot.X, playerspot.Y].Image = Image.FromFile(@"Pic/PacmanDown.jpg");
                            }
                        }
                        break;
                    }
            }
            if (GameOver(playerspot, RedGhost, maze))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Gameover!! Your score is: " + score);
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Restart", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            if (GameOver(playerspot, OrangeGhost, maze))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Gameover!! Your score is: " + score);
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Restart", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            if (GameOver(playerspot, PinkGhost, maze))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Gameover!! Your score is: " + score);
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Restart", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            if (GameOver(playerspot, BlueGhost, maze))
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                MessageBox.Show("Gameover!! Your score is: " + score);
                DialogResult dialogResult = MessageBox.Show("Do you want to play again?", "Restart", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            label2.Visible = false;
            timer2.Enabled = true;
            timer3.Enabled = true;
            key = e.KeyCode.ToString();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter < 3)
            {
                maze[RedGhost.X, RedGhost.Y].Image = null;
                RedGhost.X--;
                maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/RedGhost.jpg");
                maze[OrangeGhost.X, OrangeGhost.Y].Image = null;
                OrangeGhost.X++;
                maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
                ////////////////////////////////////////////////////
                maze[BlueGhost.X, BlueGhost.Y].Image = null;
                BlueGhost.X--;
                maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
                maze[PinkGhost.X, PinkGhost.Y].Image = null;
                PinkGhost.X++;
                maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
            }
            if (counter >= 3 && counter < 7)
            {
                maze[BlueGhost.X, BlueGhost.Y].Image = null;
                BlueGhost.Y--;
                maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
                maze[PinkGhost.X, PinkGhost.Y].Image = null;
                PinkGhost.Y--;
                maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
            }
            if (counter >= 7 && counter < 8)
            {
                maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/Dot.jpg");
                BlueGhost.X++;
                maze[BlueGhost.X, BlueGhost.Y].Image = Image.FromFile(@"Pic/BlueGhost.jpg");
                maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/Dot.jpg");
                PinkGhost.X--;
                maze[PinkGhost.X, PinkGhost.Y].Image = Image.FromFile(@"Pic/PinkGhost.jpg");
            }
            if (counter >= 3 && counter < 5)
            {
                maze[RedGhost.X, RedGhost.Y].Image = null;
                RedGhost.Y--;
                maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/RedGhost.jpg");
                maze[OrangeGhost.X, OrangeGhost.Y].Image = null;
                OrangeGhost.Y--;
                maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
            }
            if (counter >= 5 && counter < 9)
            {
                maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/Dot.jpg");
                RedGhost.X++;
                maze[RedGhost.X, RedGhost.Y].Image = Image.FromFile(@"Pic/RedGhost.jpg");
                maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/Dot.jpg");
                OrangeGhost.X--;
                maze[OrangeGhost.X, OrangeGhost.Y].Image = Image.FromFile(@"Pic/OrangeGhost.jpg");
            }
            if (counter == 6)
            {
                maze[13, 11].BackColor = Color.Blue;
                maze[14, 11].BackColor = Color.Blue;
            }
            if (counter >= 9)
            {
                if (GameOver(playerspot, RedGhost, maze))
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    MessageBox.Show("Gameover!! Your score is: " + score);
                    this.Close();
                }
                if (GameOver(playerspot, OrangeGhost, maze))
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    MessageBox.Show("Gameover!! Your score is: " + score);
                    this.Close();
                }
                if (GameOver(playerspot, PinkGhost, maze))
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    MessageBox.Show("Gameover!! Your score is: " + score);
                    this.Close();
                }
                if (GameOver(playerspot, BlueGhost, maze))
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    MessageBox.Show("Gameover!! Your score is: " + score);
                    this.Close();
                }
                MoveOrange();
                MoveRed();
                MovePink();
                MoveBlue();
            }
        }
        private void איטיToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Interval = 600;
        }
        private void נורמליToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Interval = 300;
        }
        private void מהירToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Interval = 200;
        }
        private void מהירמאודToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Interval = 100;
        }
        private void פורמולהאחתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Interval = 20;
        }
        private void iNSANEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer3.Interval = 40;
        }
    }
}
