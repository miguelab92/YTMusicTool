namespace YTMusicTool
{
    partial class FileEditor
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
            this.originalNameLabel = new System.Windows.Forms.Label();
            this.finalName = new System.Windows.Forms.Label();
            this.finalArtist = new System.Windows.Forms.Label();
            this.finalGenre = new System.Windows.Forms.Label();
            this.finalAlbum = new System.Windows.Forms.Label();
            this.finalFileName = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // originalNameLabel
            // 
            this.originalNameLabel.AutoSize = true;
            this.originalNameLabel.Location = new System.Drawing.Point(17, 13);
            this.originalNameLabel.Name = "originalNameLabel";
            this.originalNameLabel.Size = new System.Drawing.Size(87, 15);
            this.originalNameLabel.TabIndex = 0;
            this.originalNameLabel.Text = "Original Name:";
            // 
            // finalName
            // 
            this.finalName.AutoSize = true;
            this.finalName.Location = new System.Drawing.Point(17, 41);
            this.finalName.Name = "finalName";
            this.finalName.Size = new System.Drawing.Size(42, 15);
            this.finalName.TabIndex = 1;
            this.finalName.Text = "Name:";
            // 
            // finalArtist
            // 
            this.finalArtist.AutoSize = true;
            this.finalArtist.Location = new System.Drawing.Point(17, 72);
            this.finalArtist.Name = "finalArtist";
            this.finalArtist.Size = new System.Drawing.Size(38, 15);
            this.finalArtist.TabIndex = 2;
            this.finalArtist.Text = "Artist:";
            // 
            // finalGenre
            // 
            this.finalGenre.AutoSize = true;
            this.finalGenre.Location = new System.Drawing.Point(17, 104);
            this.finalGenre.Name = "finalGenre";
            this.finalGenre.Size = new System.Drawing.Size(41, 15);
            this.finalGenre.TabIndex = 3;
            this.finalGenre.Text = "Genre:";
            // 
            // finalAlbum
            // 
            this.finalAlbum.AutoSize = true;
            this.finalAlbum.Location = new System.Drawing.Point(18, 133);
            this.finalAlbum.Name = "finalAlbum";
            this.finalAlbum.Size = new System.Drawing.Size(46, 15);
            this.finalAlbum.TabIndex = 4;
            this.finalAlbum.Text = "Album:";
            // 
            // finalFileName
            // 
            this.finalFileName.AutoSize = true;
            this.finalFileName.Location = new System.Drawing.Point(17, 163);
            this.finalFileName.Name = "finalFileName";
            this.finalFileName.Size = new System.Drawing.Size(60, 15);
            this.finalFileName.TabIndex = 5;
            this.finalFileName.Text = "FileName:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(82, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(355, 23);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.nameTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(82, 69);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(355, 23);
            this.artistTextBox.TabIndex = 7;
            this.artistTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.artistTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(82, 101);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(355, 23);
            this.genreTextBox.TabIndex = 8;
            this.genreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.genreTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // albumTextBox
            // 
            this.albumTextBox.Location = new System.Drawing.Point(82, 130);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(355, 23);
            this.albumTextBox.TabIndex = 9;
            this.albumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.albumTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(82, 159);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(355, 23);
            this.fileNameTextBox.TabIndex = 10;
            this.fileNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            this.fileNameTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(362, 188);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(281, 188);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // FileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 218);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.finalFileName);
            this.Controls.Add(this.finalAlbum);
            this.Controls.Add(this.finalGenre);
            this.Controls.Add(this.finalArtist);
            this.Controls.Add(this.finalName);
            this.Controls.Add(this.originalNameLabel);
            this.Name = "FileEditor";
            this.Text = "FileEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label originalNameLabel;
        private Label finalName;
        private Label finalArtist;
        private Label finalGenre;
        private Label finalAlbum;
        private Label finalFileName;
        private TextBox nameTextBox;
        private TextBox artistTextBox;
        private TextBox genreTextBox;
        private TextBox albumTextBox;
        private TextBox fileNameTextBox;
        private Button confirmButton;
        private Button resetButton;
    }
}