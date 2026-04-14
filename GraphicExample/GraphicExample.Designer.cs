namespace GraphicExample
{
    partial class GraphicsForm
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
            MainToolTip = new ToolTip(components);
            DisplayPictureBox = new PictureBox();
            DisplayContextMenuStrip = new ContextMenuStrip(components);
            DrawMenuItem = new ToolStripMenuItem();
            ClearMenuItem = new ToolStripMenuItem();
            ColorMenuItem = new ToolStripMenuItem();
            PenMenuItem = new ToolStripMenuItem();
            BackGroundMenuItem = new ToolStripMenuItem();
            PenSizeMenuItem = new ToolStripMenuItem();
            ToolComboBox = new ToolStripComboBox();
            ExitButton = new Button();
            DrawButton = new Button();
            ClearButton = new Button();
            PenColorDialog = new ColorDialog();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            DrawTopMenuItem = new ToolStripMenuItem();
            ClearTopMenuItem = new ToolStripMenuItem();
            ExitTopMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutTopStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            DisplayContextMenuStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ControlLightLight;
            DisplayPictureBox.ContextMenuStrip = DisplayContextMenuStrip;
            DisplayPictureBox.InitialImage = null;
            DisplayPictureBox.Location = new Point(12, 32);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(776, 330);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            DisplayPictureBox.MouseMove += DisplayPictureBox_MouseStuff;
            // 
            // DisplayContextMenuStrip
            // 
            DisplayContextMenuStrip.ImageScalingSize = new Size(24, 24);
            DisplayContextMenuStrip.Items.AddRange(new ToolStripItem[] { DrawMenuItem, ClearMenuItem, ColorMenuItem, PenSizeMenuItem });
            DisplayContextMenuStrip.Name = "DisplayContextMenuStrip";
            DisplayContextMenuStrip.Size = new Size(149, 132);
            // 
            // DrawMenuItem
            // 
            DrawMenuItem.Name = "DrawMenuItem";
            DrawMenuItem.Size = new Size(148, 32);
            DrawMenuItem.Text = "Draw";
            DrawMenuItem.Click += DrawMenuItem_Click;
            // 
            // ClearMenuItem
            // 
            ClearMenuItem.Name = "ClearMenuItem";
            ClearMenuItem.Size = new Size(148, 32);
            ClearMenuItem.Text = "Clear";
            ClearMenuItem.Click += ClearMenuItem_Click;
            // 
            // ColorMenuItem
            // 
            ColorMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PenMenuItem, BackGroundMenuItem });
            ColorMenuItem.Name = "ColorMenuItem";
            ColorMenuItem.Size = new Size(148, 32);
            ColorMenuItem.Text = "Color";
            // 
            // PenMenuItem
            // 
            PenMenuItem.Name = "PenMenuItem";
            PenMenuItem.Size = new Size(215, 34);
            PenMenuItem.Text = "Pen";
            PenMenuItem.Click += PenMenuItem_Click;
            // 
            // BackGroundMenuItem
            // 
            BackGroundMenuItem.Name = "BackGroundMenuItem";
            BackGroundMenuItem.Size = new Size(215, 34);
            BackGroundMenuItem.Text = "Back Ground";
            BackGroundMenuItem.Click += BackGroundMenuItem_Click;
            // 
            // PenSizeMenuItem
            // 
            PenSizeMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolComboBox });
            PenSizeMenuItem.Name = "PenSizeMenuItem";
            PenSizeMenuItem.Size = new Size(148, 32);
            PenSizeMenuItem.Text = "Pen Size";
            // 
            // ToolComboBox
            // 
            ToolComboBox.Name = "ToolComboBox";
            ToolComboBox.Size = new Size(121, 33);
            ToolComboBox.Click += ToolComboBox_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.Location = new Point(646, 377);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(142, 61);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DrawButton
            // 
            DrawButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DrawButton.Location = new Point(498, 377);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(142, 61);
            DrawButton.TabIndex = 2;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(350, 377);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(142, 61);
            ClearButton.TabIndex = 3;
            ClearButton.TabStop = false;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, HelpTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(800, 33);
            TopMenuStrip.TabIndex = 4;
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DrawTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(54, 29);
            FileTopMenuItem.Text = "File";
            // 
            // DrawTopMenuItem
            // 
            DrawTopMenuItem.Name = "DrawTopMenuItem";
            DrawTopMenuItem.Size = new Size(270, 34);
            DrawTopMenuItem.Text = "&Draw";
            DrawTopMenuItem.Click += DrawTopMenuItem_Click;
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(270, 34);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearTopMenuItem_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(270, 34);
            ExitTopMenuItem.Text = "E&xit";
            ExitTopMenuItem.Click += ExitTopMenuItem_Click;
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopStripMenuItem });
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(65, 29);
            HelpTopMenuItem.Text = "&Help";
            // 
            // AboutTopStripMenuItem
            // 
            AboutTopStripMenuItem.Name = "AboutTopStripMenuItem";
            AboutTopStripMenuItem.Size = new Size(164, 34);
            AboutTopStripMenuItem.Text = "&About";
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(DrawButton);
            Controls.Add(ExitButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            MinimumSize = new Size(450, 450);
            Name = "GraphicsForm";
            Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            DisplayContextMenuStrip.ResumeLayout(false);
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip MainToolTip;
        private PictureBox DisplayPictureBox;
        private Button ExitButton;
        private Button DrawButton;
        private Button ClearButton;
        private ColorDialog PenColorDialog;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private ToolStripMenuItem DrawTopMenuItem;
        private ToolStripMenuItem ClearTopMenuItem;
        private ToolStripMenuItem ExitTopMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem AboutTopStripMenuItem;
        private ContextMenuStrip DisplayContextMenuStrip;
        private ToolStripMenuItem DrawMenuItem;
        private ToolStripMenuItem ClearMenuItem;
        private ToolStripMenuItem ColorMenuItem;
        private ToolStripMenuItem PenMenuItem;
        private ToolStripMenuItem BackGroundMenuItem;
        private ToolStripMenuItem PenSizeMenuItem;
        private ToolStripComboBox ToolComboBox;
    }
}
