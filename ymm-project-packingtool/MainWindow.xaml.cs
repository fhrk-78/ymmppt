using System.IO.Compression;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace ymm_project_packingtool
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Convert(object sender, RoutedEventArgs e)
        {
            var converttask = new ToDirectory(Ymmpfp.Text, Outdirb.Text);
            ResultBox.Text = await converttask.Run();
        }

        private void Zip(object sender, RoutedEventArgs e)
        {
            ZipFile.CreateFromDirectory(Outdirb.Text, Path.Combine(Outdirb.Text, "../", "_ymmpptmp.zip"));
            File.Move(Path.Combine(Outdirb.Text, "../", "_ymmpptmp.zip"), Path.Combine(Outdirb.Text, "_共有用.zip"));
        }

        private void selectFile(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog() { Filter = "YMMプロジェクトファイル|*.ymmp" };
            if (dlg.ShowDialog() == true)
            {
                Ymmpfp.Text = dlg.FileName;
            }
        }

        private void selectFolder(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFolderDialog();
            if (dlg.ShowDialog() == true)
            {
                Outdirb.Text = dlg.FolderName;
            }
        }
    }
}