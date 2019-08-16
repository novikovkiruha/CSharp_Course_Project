using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingWinForm
{
    public partial class FormView : Form
    {
        #region Fields

        private int row;

        private int column;

        private int startX;

        private int startY;

        private int elementSize;

        private int[,] gameMatrix;

        private int carX;

        private int carY;

        private Random random;

        private int myCarPosition;


        #endregion

        public FormView()
        {
            InitializeComponent();
            this.InitializeGame();
        }

        private void InitializeGame()
        {
            this.row = 16;
            this.column = 6;
            this.startX = 50;
            this.startY = 50;
            this.elementSize = 15;
            this.carX = this.carY = 0;
            this.gameMatrix = new int[this.row, this.column];
            this.ResetGameBoard();

            this.random = new Random();

            this.myCarPosition = 0;
            this.DrawCar(12, this.myCarPosition, 2);
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            this.DrawGameBoard(e.Graphics);
        }

        private void DrawGameBoard(Graphics graphics)
        {
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.column; j++)
                {
                    graphics.DrawRectangle(new Pen(Brushes.Brown), this.startX + j * this.elementSize, this.startY + i * this.elementSize, this.elementSize, this.elementSize);

                    if (this.gameMatrix[i, j] == 1)
                    {
                        graphics.FillRectangle(Brushes.DarkCyan, this.startX + j * this.elementSize, this.startY + i * this.elementSize, this.elementSize, this.elementSize);
                    }
                    if (this.gameMatrix[i, j] == 2)
                    {
                        graphics.FillRectangle(Brushes.Blue, this.startX + j * this.elementSize, this.startY + i * this.elementSize, this.elementSize, this.elementSize);
                    }
                }
            }
        }

        #region Functions

        private void ResetGameBoard()
        {
            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.column; j++)
                {
                    this.gameMatrix[i, j] = 0;
                }
            }
        }

        private void DrawCar(int x, int y, int value)
        {
            this.DrawPoint(x, y + 1, value);
            this.DrawPoint(x + 1, y + 1, value);
            this.DrawPoint(x + 2, y + 1, value);
            this.DrawPoint(x + 3, y + 1, value);
            this.DrawPoint(x + 1, y, value);
            this.DrawPoint(x + 1, y + 2, value);
            this.DrawPoint(x + 3, y, value);
            this.DrawPoint(x + 3, y + 2, value);
        }

        private void DrawPoint(int x, int y, int value)
        {
            if (x < this.row && x >= 0 && y < this.column && y >= 0)
            {
                this.gameMatrix[x, y] = value;
            }
        }

        #endregion

        private void TimerRacing_Tick(object sender, EventArgs e)
        {
            this.ResetGameBoard();
            this.DrawCar(12, this.myCarPosition, 2);
            this.DrawCar(this.carX, this.carY, 1);
            Invalidate();
            this.carX++;

            if (this.carX == this.row)
            {
                this.carX = 0;
                this.carY = this.random.Next() % 2 == 0 ? 0 : 3;
            }

            CheckGame();
        }

        private void CheckGame()
        {
            if (this.carX + 3 > 12 && this.carY == this.myCarPosition)
            {
                TimerRacing.Enabled = false;
            }
        }

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && this.myCarPosition == 3)
            {
                this.myCarPosition = 0;
            }
            else if(e.KeyCode == Keys.Right && this.myCarPosition == 0)
            {
                this.myCarPosition = 3;
            }
        }

        private void FormView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.carX = this.carY = 0;
            this.myCarPosition = 0;
            TimerRacing.Enabled = true;
        }
    }
}
