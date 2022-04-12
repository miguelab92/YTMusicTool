using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using TagLib;

namespace YTMusicTool
{
    public partial class FileEditor : Form
    {
        private TextInfo TextInfo { get; set; }
        private string OutputDirectory { get; set; }
        private string OriginalFileName { get; set; }
        private string OriginalName { get; set; }
        private string OriginalArtist { get; set; }
        private string OriginalGenre { get; set; }
        private string OriginalAlbum { get; set; }

        public FileEditor(string dirPath, string fileName)
        {
            InitializeComponent();

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo = cultureInfo.TextInfo;

            OutputDirectory = dirPath;
            OriginalFileName = fileName;
            OriginalName = OriginalFileName[..OriginalFileName.LastIndexOf('.')];

            var file = new TagLib.Mpeg.AudioFile($"{OutputDirectory}\\{OriginalFileName}");
            OriginalArtist = file.Tag.FirstArtist;
            OriginalGenre = file.Tag.FirstGenre;
            OriginalAlbum = file.Tag.Album;

            nameTextBox.Text = OriginalName;
            artistTextBox.Text = OriginalArtist;
            albumTextBox.Text = OriginalAlbum;
            genreTextBox.Text = OriginalGenre;
            fileNameTextBox.Text = OriginalFileName;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            nameTextBox.Text = TextInfo.ToTitleCase(nameTextBox.Text.Trim());
            artistTextBox.Text = TextInfo.ToTitleCase(artistTextBox.Text.Trim());
            albumTextBox.Text = TextInfo.ToTitleCase(albumTextBox.Text.Trim());
            genreTextBox.Text = TextInfo.ToTitleCase(genreTextBox.Text.Trim());
            fileNameTextBox.Text = TextInfo.ToTitleCase(nameTextBox.Text.Trim() + ".mp3");
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enter key pressed
                SaveAndExit();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SaveAndExit();
        }

        private void SaveAndExit()
        {
            var finalOriginalFileName = $"{OutputDirectory}\\{OriginalFileName}";
            var finalFileName = $"{OutputDirectory}\\{fileNameTextBox.Text}";

            var file = new TagLib.Mpeg.AudioFile(finalOriginalFileName);

            file.Tag.Title = nameTextBox.Text;
            file.Tag.AlbumArtists = new[] { artistTextBox.Text };
            file.Tag.Artists = new[] { artistTextBox.Text };
            file.Tag.Genres = new[] { genreTextBox.Text };
            file.Tag.Album = albumTextBox.Text;

            file.Save();

            System.IO.File.Move(finalOriginalFileName, finalFileName);

            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = OriginalName;
            artistTextBox.Text = OriginalArtist;
            albumTextBox.Text = OriginalAlbum;
            genreTextBox.Text = OriginalGenre;
            fileNameTextBox.Text = OriginalFileName;
        }
    }
}
