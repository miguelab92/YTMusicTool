namespace YTMusicTool
{
    partial class YTMusicTool
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
            this.dirPathTextBox = new System.Windows.Forms.TextBox();
            this.dirButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // dirPathTextBox
            // 
            this.dirPathTextBox.Location = new System.Drawing.Point(12, 22);
            this.dirPathTextBox.Name = "dirPathTextBox";
            this.dirPathTextBox.Size = new System.Drawing.Size(376, 23);
            this.dirPathTextBox.TabIndex = 0;
            // 
            // dirButton
            // 
            this.dirButton.Location = new System.Drawing.Point(394, 22);
            this.dirButton.Name = "dirButton";
            this.dirButton.Size = new System.Drawing.Size(23, 23);
            this.dirButton.TabIndex = 1;
            this.dirButton.Text = "*";
            this.dirButton.UseVisualStyleBackColor = true;
            this.dirButton.Click += new System.EventHandler(this.dirButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(340, 54);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory of files to edit";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyMusic;
            // 
            // YTMusicTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 89);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.dirButton);
            this.Controls.Add(this.dirPathTextBox);
            this.Name = "YTMusicTool";
            this.Text = "YTMusicTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox dirPathTextBox;
        private Button dirButton;
        private Button nextButton;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialog;
    }
}