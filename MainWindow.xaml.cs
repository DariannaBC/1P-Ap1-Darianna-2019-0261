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
using _1P_Ap1_Darianna_2019_0261.UI;

namespace _1P_Ap1_Darianna_2019_0261
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            RegistroAporte r = new RegistroAporte();
            r.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ConsultaAportes c = new ConsultaAportes();
            c.Show();
        }
    }
}
