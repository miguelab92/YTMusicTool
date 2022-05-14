namespace YTMusicTool
{
    public partial class YTMusicTool : Form
    {
        public YTMusicTool()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dirPathTextBox.Text))
            {
                DirectoryInfo folder = new DirectoryInfo(dirPathTextBox.Text);
                foreach (FileInfo file in folder.GetFiles("*.mp3"))
                {
                    var fileEditor = new FileEditor(folder.FullName, file.Name);
                    fileEditor.ShowDialog();
                }
            }
        }

        private void dirButton_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                dirPathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        } 
    }
}