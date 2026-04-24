using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GraphicExample
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            SplashForm(); // show the splash form before initializing the main form
            InitializeComponent();
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseStuff;
            ToolComboBox.Items.Add(2);
            ToolComboBox.Items.Add(3);
            ToolComboBox.Items.Add(4);
            ToolComboBox.Items.Add(5);
            ToolComboBox.Items.Add(6);
            ToolComboBox.Items.Add(7);
            ToolComboBox.SelectedIndex = 1;
        }

        // Custom Methods -----------------------------------------------------
        int oldX, oldY;
        void DrawLineSegment(int newX, int newY)
        {
            //create a Graphics object named g that draws on the picture box
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(this.penColor);
            thePen.Width = this.penWidth;
            //draw the line here
            g.DrawLine(thePen, oldX, oldY, newX, newY);

            //free up resources
            g.Dispose();
            thePen.Dispose();
        }
        private void SplashForm()
        {
            SplashForm splashForm = new SplashForm(); //instantitate the splash form
            splashForm.Show(); // show the splash form
            System.Threading.Thread.Sleep(1000);// pause the main thread for 3 seconds to allow the splash form to be visible
            splashForm.Close(); // close the splash form after 3 seconds
        }


        void ClearDrawing()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            
            // Shake the form
            var original = this.Location; // save the original position of the form
            var random = new Random(); // create a random number generator
            int shake_amplitude = 75; // how far the form should shake in pixels
            // play sound effect 
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("..\\..\\..\\Resources_shaker.wav");
            player.Play();

            for (int i = 0; i < 15; i++) // shake the form 15 times
            {
                // Randomly offset the form's position
                this.Location = new Point(
                    original.X + random.Next(-shake_amplitude, shake_amplitude), // shake horizontally
                    original.Y + random.Next(-shake_amplitude, shake_amplitude));// shake vertically
                System.Threading.Thread.Sleep(150); // Small pause for visibility
            }
            // clear the drawing by filling the picture box
            g.Clear(Color.White);
            // Reset to original position
            this.Location = original;

            // free up resources
            g.Dispose();
        }

        private Color penColor = Color.Black;
        private Color BackGround = Color.White;
        private int penWidth = 3;

        void UpdatePenColor()
        {
            PenColorDialog.ShowDialog();
            this.penColor = PenColorDialog.Color;
        }

        void UpdateBackGroundColor()
        {
            PenColorDialog.ShowDialog();
            this.BackGround = PenColorDialog.Color;
            DisplayPictureBox.BackColor = this.BackGround;
        }

        void UpdatePenWidth()
        {
            this.penWidth = int.Parse(ToolComboBox.SelectedItem.ToString());
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
            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            // move the origin (start) of the drawing area to the center of the picture box
            g.ScaleTransform(scaleX, scaleY);
            // scale the drawing area so that the sine wave is wider and flip
            // the y-axis so that positive values go upinstead of down
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Sin((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }
            g.Dispose();
            thePen.Dispose();
        }

        void DrawCosineWave()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.MediumVioletRed);
            // set the width of the pen
            thePen.Width = 3;
            int lastX = 0, lastY = 0, currentY = 0;
            // draw the line here 
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;
            // scale the x-axis so that one period of the sine wave fits in the width of the picture box
            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            g.ScaleTransform(scaleX, scaleY);
            // scale the drawing area so that the sine wave is wider and flip
            // the y-axis so that positive values go upinstead of down
            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Cos((Math.PI / 180) * currentX)));
                g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                lastX = currentX;
                lastY = currentY;
            }
            g.Dispose();
        }

        void DrawTangentWave()
        {
            // create a graphics object named g that draws on the PictureBox
            Graphics g = DisplayPictureBox.CreateGraphics();
            // create a pen to draw with
            Pen thePen = new Pen(Color.RebeccaPurple);
            // set the width of the pen
            thePen.Width = 3;
            int lastX = 0, lastY = 0, currentY = 0;
            // draw the line here 
            float scaleX = DisplayPictureBox.Width / 360f;
            float scaleY = (DisplayPictureBox.Height / 200f) * -1;
            // scale the x-axis so that one period of the sine wave fits in the width of the picture box
            g.TranslateTransform(0, DisplayPictureBox.Height / 2);
            g.ScaleTransform(scaleX, scaleY);
            // scale the drawing area so that the sine wave is wider and flip
            // the y-axis so that positive values go upinstead of down

            for (int currentX = 0; currentX < 360; currentX++)
            {
                currentY = (int)(Math.Round(100 * Math.Tan((Math.PI / 180) * currentX)));
                if (Math.Abs(currentY) < DisplayPictureBox.Height / 2)
                {
                    g.DrawLine(thePen, lastX, lastY, currentX, currentY);
                }
                lastX = currentX;
                lastY = currentY;
                // makes sure that the tan wave doesn't draw that would be outside
                // the picture box
            }
            //free up resorces
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
            DrawTangentWave();
            DrawCosineWave();
            DrawSineWave();
            DrawGrid();
        }

        private void DisplayPictureBox_MouseStuff(object sender, MouseEventArgs e)
        {
            DrawingStatusLabel.Text = $"({e.X},{e.Y}) | {e.Button} " +
                $"| {this.penColor} | {this.penWidth}";

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

        private void DrawMenuItem_Click(object sender, EventArgs e)
        {
            DrawButton_Click(sender, e);
        }

        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            ClearDrawing();
        }

        private void PenMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePenColor();
        }

        private void BackGroundMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBackGroundColor();
        }

        private void ToolComboBox_Click(object sender, EventArgs e)
        {
            UpdatePenWidth();
        }

        private void DrawTopMenuItem_Click(object sender, EventArgs e)
        {
            DrawButton_Click(sender, e);
        }

        private void ClearTopMenuItem_Click(object sender, EventArgs e)
        {
            ClearDrawing();
        }

        private void ExitTopMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutTopStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm(); //instantitate the about form
            aboutForm.FormClosed += AboutForm_FormClosed; //map the FormClosed event to a handler
            aboutForm.Show(); // show the about form
            this.Hide();// hide the main form while the about form is open
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // show the main form again when the about form is closed
        }
    }
}
