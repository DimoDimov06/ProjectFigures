using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private Color currentColor = Color.Empty;
        private string currentShape = string.Empty;
        private Random rdm;
        private Thread drawThread;
        private bool isDrawing;

        public Form1()
        {
            InitializeComponent();
            rdm = new Random();
        }


        private void red_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            currentColor = Color.Blue;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            StartDrawing("Rectangle");
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            StartDrawing("Triangle");
        }

        private void circle_Click(object sender, EventArgs e)
        {
            StartDrawing("Circle");
        }



        private void StartDrawing(string shape)
        {
            if (currentColor == Color.Empty)
            {
                MessageBox.Show("Please select a color first.");
                return;
            }

            currentShape = shape;
            isDrawing = true;

            if (drawThread == null || !drawThread.IsAlive)
            {
                drawThread = new Thread(() => DrawShape());
                drawThread.Start();
            }
        }



        private void DrawShape()
        {
            while (isDrawing)
            {
                Graphics g = this.CreateGraphics();
                Pen pen = new Pen(currentColor, 4);
                int x = rdm.Next(0, this.Width);
                int y = rdm.Next(0, this.Height);
                int size = rdm.Next(10, 100);

                switch (currentShape)
                {
                    case "Rectangle":
                        int width = rdm.Next(10, 100);
                        int height = rdm.Next(10, 100);
                        g.DrawRectangle(pen, new Rectangle(x, y, width, height));
                        break;
                    case "Triangle":
                        Point[] points = {
                        new Point(x, y),
                        new Point(x + size / 2, y - (int)(Math.Sqrt(3) / 2 * size)),
                        new Point(x + size, y)
                    };
                        g.DrawPolygon(pen, points);
                        break;
                    case "Circle":
                        g.DrawEllipse(pen, new Rectangle(x, y, size, size));
                        break;
                }

                
            }
        }
    }
}
