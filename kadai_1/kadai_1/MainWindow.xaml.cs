using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace kadai_1
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private WindowChild windowChild = new WindowChild();

        public MainWindow()
        {
            InitializeComponent();
            windowChild.Show();
        }
    }
}
