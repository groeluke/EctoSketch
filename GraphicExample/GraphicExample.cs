namespace GraphicExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
        }
        // Custom Methods -----------------------------------------------------

        void DrawLine()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.Black);
            // set the width of the pen
            thePen.Width = 3; 
            //draw the line here 
            g.DrawLine(thePen, 0, 0, DisplayPictureBox.Width, DisplayPictureBox.Height);


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
            g.DrawEllipse(thePen,0,0,100,100);

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
            g.DrawRectangle(thePen, 0, 0, 200, 200);

            // free up resources
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
            DrawRectangle();
            DrawEllipse();
            DrawLine();
            //draw
        }
    }
}
