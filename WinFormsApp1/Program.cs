using Velopack;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            VelopackApp.Build().Run();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}