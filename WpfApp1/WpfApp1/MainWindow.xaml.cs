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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Sap_Click(object sender, RoutedEventArgs e)
        {
            сапер w = new сапер();
            w.Show();
        }

        private void Kre_Click(object sender, RoutedEventArgs e)
        {
            Крестик_нолик s = new Крестик_нолик();
            s.Show();
        }
    }
}
