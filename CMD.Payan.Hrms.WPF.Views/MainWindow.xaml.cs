using CMD.Payan.Hrms.WPF.Views.Views.CallLetter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CMD.Payan.Hrms.WPF.Views
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

        private void callLetter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CallLetterWindow callLetterWindow = new CallLetterWindow();
            callLetterWindow.ShowDialog();
        }
    }
}
