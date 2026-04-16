namespace GraphicExample
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AboutLabel = new Label();
            AboutOkButton = new Button();
            AboutOkLabel = new Label();
            SuspendLayout();
            // 
            // AboutLabel
            // 
            AboutLabel.AutoSize = true;
            AboutLabel.Location = new Point(50, 72);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(0, 25);
            AboutLabel.TabIndex = 0;
            // 
            // AboutOkButton
            // 
            AboutOkButton.ImageAlign = ContentAlignment.BottomRight;
            AboutOkButton.Location = new Point(203, 193);
            AboutOkButton.Name = "AboutOkButton";
            AboutOkButton.Size = new Size(112, 34);
            AboutOkButton.TabIndex = 3;
            AboutOkButton.Text = "&Ok";
            AboutOkButton.UseVisualStyleBackColor = true;
            AboutOkButton.Click += AboutOkButton_Click;
            // 
            // AboutOkLabel
            // 
            AboutOkLabel.AutoSize = true;
            AboutOkLabel.Location = new Point(12, 9);
            AboutOkLabel.Name = "AboutOkLabel";
            AboutOkLabel.Size = new Size(59, 25);
            AboutOkLabel.TabIndex = 4;
            AboutOkLabel.Text = "label1";
            AboutOkLabel.Click += AboutOkLabel_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 236);
            Controls.Add(AboutOkLabel);
            Controls.Add(AboutOkButton);
            Controls.Add(AboutLabel);
            Name = "AboutForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "AboutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AboutLabel;
        private Button AboutOkButton;
        private Label AboutOkLabel;
    }
}