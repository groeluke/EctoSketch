namespace GraphicExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseMove;
        }
        // Custom Methods -----------------------------------------------------
        int oldX = new;
        void DrawLineSegment(int newX, int newY)
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Violet);
            // set the width of the pen
            thePen.Width = 3;
            //draw the line here 
            g.DrawLine(thePen, newX, newY, newX, newY);

            // free up resources
            g.Dispose();
            thePen.Dispose();
        }

        void DrawEllipse()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.DarkOrange);
            // set the width of the pen
            thePen.Width = 3;
            //draw the line here 
            g.DrawEllipse(thePen, 0, 0, 100, 100);

            // free up resources
            g.Dispose();
            thePen.Dispose();
        }

        void DrawRectangle()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.DeepPink);
            // set the width of the pen
            thePen.Width = 3;
            //draw the line here 
            g.DrawRectangle(thePen, 400, 100, 200, 200);

            // free up resources
            g.Dispose();
            thePen.Dispose();
        }
         
        void DrawPie()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.IndianRed);
            SolidBrush theBrush = new SolidBrush(Color.MediumPurple);
            Rectangle bounds = new Rectangle(0, 0, 200, 200);
            // set the width of the pen
            g.DrawPie(thePen, bounds, 0, 90);
            g.FillPie(theBrush, bounds, 90, 270);
            theBrush.Color = Color.LightGreen;
            g.FillPie(theBrush, bounds, 45, 110);
            theBrush.Color = Color.LightBlue;
            g.FillPie(theBrush, bounds, 110, 170);

            // free up resources
            g.Dispose();
            thePen.Dispose();
            theBrush.Dispose();
        }

        void DrawString()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a font to draw with
            Font theFont = new Font("Arial", 16);
            Rectangle bounds = new Rectangle(400, 100, 200, 200);
            SolidBrush theBrush = new SolidBrush(Color.DarkBlue);
            //draw the line here 
            g.DrawString("I LOVE C#! Its the best. Its fantasic. ", theFont, theBrush, bounds);

            // free up resources
            g.Dispose();
            theFont.Dispose();
            theBrush.Dispose();
        }

        void DrawImage()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create image
            Image theImage = Image.FromFile("..\\..\\..\\Sun_Set.JPG");
            // fills the rectangle with the image
            Rectangle bounds = new Rectangle(60, 0, 650, 350);
            //draw the line here 
            g.DrawImage(theImage, bounds);

            // free up resources
            g.Dispose();
            theImage.Dispose();
        }
        
        void ClearDrawing()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // clear the drawing area
            g.Clear(Color.White);
            // free up resources
            g.Dispose();
        }


        // Event handlers -----------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawImage();
            DrawString();
            DrawPie();
            DrawRectangle();
            DrawEllipse();
            //draw
        }

        private void DisplayPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"({e.X},{e.Y})";
            DrawLineSegment(e.X, e.Y);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearDrawing();
        }
    }
}
