using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cleaner_PC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Close_PreviewDragEnter(object sender, DragEventArgs e)
        {
            Close.Content = "close";
        }

        private void Close_PreviewDragLeave(object sender, DragEventArgs e)
        {
            Close.Content = "";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            this.MouseDown += delegate
            {
                DragMove();
            };
        }

        private void Analyzer_Click(object sender, RoutedEventArgs e)
        {

        }

        private String GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = string.Format("(0:##.##)", byteCount / 1073741824.0) + "GB";
            else if (byteCount >= 1048576.0)
                size = string.Format("(0:##.##)", byteCount / 1048576.0) + "MB";

            else if (byteCount >= 1024.0)
                size = string.Format("(0:##.##)", byteCount / 1024.0) + "KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + "Bytes";
            return size;
        }
    }
}
