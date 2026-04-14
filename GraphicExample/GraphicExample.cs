namespace GraphicExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseStuff;
        }



        // Custom Methods -----------------------------------------------------
        int oldX, oldY;
        void DrawLineSegment(int newX, int newY)
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.penColor);
            thePen.Width = 3;
            //draw the line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }

        //void DrawEllipse()
        //{
        //    // create a graphics object named g that draws on the PictureBox
        //    Graphics g = DisplayPictureBox.CreateGraphics();
        //    // create a pen to draw with
        //    Pen thePen = new Pen(Color.DarkOrange);
        //    // set the width of the pen
        //    thePen.Width = 3;
        //    //draw the line here 
        //    g.DrawEllipse(thePen, 0, 0, 100, 100);

        //    // free up resources
        //    g.Dispose();
        //    thePen.Dispose();
        //}

        //void DrawRectangle()
        //{
        //    // create a graphics object named g that draws on the PictureBox
        //    Graphics g = DisplayPictureBox.CreateGraphics();
        //    // create a pen to draw with
        //    Pen thePen = new Pen(Color.DeepPink);
        //    // set the width of the pen
        //    thePen.Width = 3;
        //    //draw the line here 
        //    g.DrawRectangle(thePen, 400, 100, 200, 200);

        //    // free up resources
        //    g.Dispose();
        //    thePen.Dispose();
        //}

        //void DrawPie()
        //{
        //    // create a graphics object named g that draws on the PictureBox
        //    Graphics g = DisplayPictureBox.CreateGraphics();
        //    // create a pen to draw with
        //    Pen thePen = new Pen(Color.IndianRed);
        //    SolidBrush theBrush = new SolidBrush(Color.MediumPurple);
        //    Rectangle bounds = new Rectangle(0, 0, 200, 200);
        //    // set the width of the pen
        //    g.DrawPie(thePen, bounds, 0, 90);
        //    g.FillPie(theBrush, bounds, 90, 270);
        //    theBrush.Color = Color.LightGreen;
        //    g.FillPie(theBrush, bounds, 45, 110);
        //    theBrush.Color = Color.LightBlue;
        //    g.FillPie(theBrush, bounds, 110, 170);

        //    // free up resources
        //    g.Dispose();
        //    thePen.Dispose();
        //    theBrush.Dispose();
        //}

        //void DrawString()
        //{
        //    // create a graphics object named g that draws on the PictureBox
        //    Graphics g = DisplayPictureBox.CreateGraphics();
        //    // create a font to draw with
        //    Font theFont = new Font("Arial", 16);
        //    Rectangle bounds = new Rectangle(100, 100, 200, 200);
        //    SolidBrush theBrush = new SolidBrush(Color.DarkBlue);
        //    //draw the line here 
        //    g.DrawString("I LOVE C#! Its the best. Its fantasic. ", theFont, theBrush, bounds);

        //    // free up resources
        //    g.Dispose();
        //    theFont.Dispose();
        //    theBrush.Dispose();
        //}

        //void DrawImage()
        //{
        //    // create a graphics object named g that draws on the PictureBox
        //    Graphics g = DisplayPictureBox.CreateGraphics();
        //    // create image
        //    Image theImage = Image.FromFile("..\\..\\..\\Sun_Set.JPG");
        //    // fills the rectangle with the image
        //    Rectangle bounds = new Rectangle(60, 0, 650, 350);
        //    //draw the line here 
        //    g.DrawImage(theImage, bounds);

        //    // free up resources
        //    g.Dispose();
        //    theImage.Dispose();
        //}

        void ClearDrawing()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // clear the drawing area
            g.Clear(Color.White);
            // free up resources
            g.Dispose();
        }
        private Color penColor = Color.Black;
        void UpdatePenColor()
        {
            PenColorDialog.ShowDialog();
            this.penColor = PenColorDialog.Color;
        }

        void DrawSineWave()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Lime);
            // set the width of the pen
            thePen.Width = 3;
            int lastX = 0, lastY = 0, currentY = 0;
            // draw the line here 
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;
            // scale the x-axis so that one period of the sine wave fits in the width of the picture box
            g.TranslateTransform(0 , DisplayPictureBox.Height / 2);
            // move the origin (start) of the drawing area to the center of the picture box
            g.ScaleTransform(scaleX, scaleY);
            // scale the drawing area so that the sine wave is wider and flip
            // the y-axis so that positive values go upinstead of down
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int) (Math.Round(100 * Math.Sin((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }
            g.Dispose();
            thePen.Dispose();
        }

        void DrawGrid()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.LightGray);
            // set the width of the pen
            thePen.Width = 1;
            // draw the line here 
            for (int x = 0; x < DisplayPictureBox.Width; x += 100)
            {
                g.DrawLine(thePen, x, 0, x, DisplayPictureBox.Height);
            }
            for (int y = 0; y < DisplayPictureBox.Height; y += 100)
            {
                g.DrawLine(thePen, 0, y, DisplayPictureBox.Width, y);
            }
            g.Dispose();
            thePen.Dispose();
        }

        // Event handlers -----------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            //DrawImage();
            //DrawString();
         //   DrawPie();
         //   DrawRectangle();
         //   DrawEllipse();
            DrawSineWave();
            DrawGrid();
        }

        private void DisplayPictureBox_MouseStuff(object sender, MouseEventArgs e)
        {
            this.Text = $"({e.X},{e.Y}) {e.Button}";
            this.Text = $"({e.Button})";

            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawLineSegment(e.X, e.Y); // only draw when the left mouse button is down
                    break;
                case MouseButtons.Right:
                    // Save for context menu
                    break;
                case MouseButtons.Middle:
                    UpdatePenColor();
                    // TODO open color picker dialogue
                    break;
                default:
                    //MessageBox.Show($"{e.Button}");
                    break;
            }
                    // save the current mouse position for the next time we draw a line segment
                    this.oldX = e.X;
                    this.oldY = e.Y;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearDrawing();
        }
    }
}
