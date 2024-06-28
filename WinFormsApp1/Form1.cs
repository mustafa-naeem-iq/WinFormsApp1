using Velopack;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Lable.Text = @"hello world";
        }

        private static async Task UpdateMyApp()
        {
            var manager = new UpdateManager("");

            var newVersion = await manager.CheckForUpdatesAsync();
            if (newVersion == null) return;

            await manager.DownloadUpdatesAsync(newVersion);

            manager.ApplyUpdatesAndRestart(newVersion);
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            await UpdateMyApp();
        }
    }
}
