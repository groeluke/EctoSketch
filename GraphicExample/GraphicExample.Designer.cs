namespace GraphicExample
{
    partial class GraphicExample
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicExample));
            MainToolTip = new ToolTip(components);
            PictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // PictureBox
            // 
            PictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PictureBox.Image = (Image)resources.GetObject("PictureBox.Image");
            PictureBox.InitialImage = (Image)resources.GetObject("PictureBox.InitialImage");
            PictureBox.Location = new Point(12, 32);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(776, 330);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            // 
            // GraphicExample
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PictureBox);
            MinimumSize = new Size(450, 450);
            Name = "GraphicExample";
            Text = "Graphic Example";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip MainToolTip;
        private PictureBox PictureBox;
    }
}
