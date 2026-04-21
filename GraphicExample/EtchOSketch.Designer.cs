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
            BottomStatusStrip = new StatusStrip();
            DrawingStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            DisplayContextMenuStrip.SuspendLayout();
            TopMenuStrip.SuspendLayout();
            BottomStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ControlLightLight;
            DisplayPictureBox.ContextMenuStrip = DisplayContextMenuStrip;
            DisplayPictureBox.InitialImage = null;
            DisplayPictureBox.Location = new Point(14, 38);
            DisplayPictureBox.Margin = new Padding(4);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(931, 437);
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
            ExitButton.Location = new Point(775, 482);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(170, 63);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DrawButton
            // 
            DrawButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DrawButton.Location = new Point(598, 482);
            DrawButton.Margin = new Padding(4);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(170, 63);
            DrawButton.TabIndex = 2;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(420, 482);
            ClearButton.Margin = new Padding(4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(170, 63);
            ClearButton.TabIndex = 3;
            ClearButton.TabStop = false;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.Font = new Font("Source Code Pro", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem, HelpTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Padding = new Padding(7, 2, 0, 2);
            TopMenuStrip.Size = new Size(960, 38);
            TopMenuStrip.TabIndex = 4;
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DrawTopMenuItem, ClearTopMenuItem, ExitTopMenuItem });
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(77, 34);
            FileTopMenuItem.Text = "File";
            // 
            // DrawTopMenuItem
            // 
            DrawTopMenuItem.Name = "DrawTopMenuItem";
            DrawTopMenuItem.Size = new Size(176, 38);
            DrawTopMenuItem.Text = "&Draw";
            DrawTopMenuItem.Click += DrawTopMenuItem_Click;
            // 
            // ClearTopMenuItem
            // 
            ClearTopMenuItem.Name = "ClearTopMenuItem";
            ClearTopMenuItem.Size = new Size(176, 38);
            ClearTopMenuItem.Text = "&Clear";
            ClearTopMenuItem.Click += ClearTopMenuItem_Click;
            // 
            // ExitTopMenuItem
            // 
            ExitTopMenuItem.Name = "ExitTopMenuItem";
            ExitTopMenuItem.Size = new Size(176, 38);
            ExitTopMenuItem.Text = "E&xit";
            ExitTopMenuItem.Click += ExitTopMenuItem_Click;
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutTopStripMenuItem });
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(77, 34);
            HelpTopMenuItem.Text = "&Help";
            // 
            // AboutTopStripMenuItem
            // 
            AboutTopStripMenuItem.Name = "AboutTopStripMenuItem";
            AboutTopStripMenuItem.Size = new Size(176, 38);
            AboutTopStripMenuItem.Text = "&About";
            AboutTopStripMenuItem.Click += AboutTopStripMenuItem_Click;
            // 
            // BottomStatusStrip
            // 
            BottomStatusStrip.ImageScalingSize = new Size(24, 24);
            BottomStatusStrip.Items.AddRange(new ToolStripItem[] { DrawingStatusLabel });
            BottomStatusStrip.Location = new Point(0, 549);
            BottomStatusStrip.Name = "BottomStatusStrip";
            BottomStatusStrip.Padding = new Padding(1, 0, 17, 0);
            BottomStatusStrip.Size = new Size(960, 32);
            BottomStatusStrip.TabIndex = 5;
            BottomStatusStrip.Text = "statusStrip1";
            BottomStatusStrip.ItemClicked += StatusStrip_ItemClicked;
            // 
            // DrawingStatusLabel
            // 
            DrawingStatusLabel.Name = "DrawingStatusLabel";
            DrawingStatusLabel.Size = new Size(19, 25);
            DrawingStatusLabel.Text = "-";
            DrawingStatusLabel.Click += DrawingStatusLabel_Click;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 581);
            Controls.Add(BottomStatusStrip);
            Controls.Add(ClearButton);
            Controls.Add(DrawButton);
            Controls.Add(ExitButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(TopMenuStrip);
            Font = new Font("Source Code Pro", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = TopMenuStrip;
            Margin = new Padding(4);
            MinimumSize = new Size(536, 529);
            Name = "GraphicsForm";
            Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            DisplayContextMenuStrip.ResumeLayout(false);
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            BottomStatusStrip.ResumeLayout(false);
            BottomStatusStrip.PerformLayout();
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
        private StatusStrip BottomStatusStrip;
        private ToolStripStatusLabel DrawingStatusLabel;
    }
}
