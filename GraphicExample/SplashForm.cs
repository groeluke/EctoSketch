using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraphicExample
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            // Simulate some loading work
            System.Threading.Thread.Sleep(2000); // Sleep for 2 seconds
            this.Close(); // Close the splash screen after loading is done
        }
    }
}
