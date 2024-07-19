using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        public Form1()
        {
            InitializeComponent();
            StartGame();
            GenerateFood();

            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
        }

       private void UpdateScreen(object sender, EventArgs e)
       { 
            if(Settings.GameOver == true)
            {
                lblGameOver.Visible = true;
                if(Input.KeyPresed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPresed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                }
                else if (Input.KeyPresed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                }
                else if (Input.KeyPresed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                }
                else if (Input.KeyPresed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                }
                MovePlayer(); // ovde nastaviti
            }
            pbCanvas.Invalidate();
        }
       private void Eat()
       {
           Circle food = new Circle();
           food.X = Snake[Snake.Count - 1].X;
           food.Y = Snake[Snake.Count - 1].Y;
           Snake.Add(food);
           Settings.Score += Settings.Points;
           lblScore.Text = Settings.Score.ToString();
           GenerateFood();
       }
        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Up:
                            Snake[0].Y -= Settings.Speed;
                            break;
                        case Direction.Down:
                            Snake[0].Y += Settings.Speed;
                            break;
                        case Direction.Left:
                            Snake[0].X -= Settings.Speed;
                            break;
                        case Direction.Right:
                            Snake[0].X += Settings.Speed;
                            break;
                        default:
                            break;
                    }
                    int maxXPos = pbCanvas.Size.Width;
                    int maxYPos = pbCanvas.Size.Height;
                    if (Snake[0].X < 0 || Snake[0].Y < 0 ||
                        Snake[0].X >= maxXPos || Snake[0].Y >= maxYPos)
                    {
                        Die();
                    }
                    if (Difference(Snake[0].X, food.X) && Difference(Snake[0].Y, food.Y))
                    {
                        Eat();
                    }
                }
                //move body
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
         }
        private void Die()
        {
            Settings.GameOver = true;
        }
        private void StartGame()
        {
            lblGameOver.Visible = false;
            new Settings();
            Snake.Clear();
            Circle head = new Circle();
            head.X = 5;
            head.Y = 5;
            Snake.Add(head);
            lblScore.Text = Settings.Score.ToString();
        }
        Random random = new Random();
        private void GenerateFood()
        {
        int MaxXPos = pbCanvas.Size.Width - 5;
        int MaxYPos = pbCanvas.Size.Height - 5;
        food = new Circle();
        food.X = random.Next(0,MaxXPos);
        food.Y = random.Next(0,MaxYPos);
        }
        private bool Difference(int i, int j)
        {
            if (((i - j) < 9 && (i - j) >= 0) || ((j - i) < 9 && (j - i) >= 0))
            {
                return true;
            }
            return false;
        }
        class Input
        {
            private static Hashtable keyTable = new Hashtable();

            public static bool KeyPresed(Keys key)
            {
                if (keyTable[key] == null)
                {
                    return false;
                }
                return (bool)keyTable[key];
            }
            public static void ChangeState(Keys key, bool state)
            {
                keyTable[key] = state;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColor;
            if(!Settings.GameOver)
            {
                for(int i = 0; i <Snake.Count;i++)
                {
                    if(i == 0)
                    {
                        snakeColor = Brushes.Black;
                    }
                    else 
                    {
                        snakeColor = Brushes.Purple;
                    }
                    canvas.FillEllipse(snakeColor, new Rectangle(Snake[i].X, Snake[i].Y, Settings.Width, Settings.Height));

                    canvas.FillEllipse(Brushes.Red, new Rectangle(food.X, food.Y, Settings.Width, Settings.Height));
                }
            }
        }
    }
}
