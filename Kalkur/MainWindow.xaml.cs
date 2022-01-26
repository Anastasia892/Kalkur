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

namespace Kalkur
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
   
        public MainWindow()
        {
            InitializeComponent();
            model.tbItog = Tb6;
            CBox1.ItemsSource = model.datalist;
        }

        private void vich_Click(object sender, RoutedEventArgs e)
        {
            model.oneSV = Convert.ToInt32(Tb2.Text);
            model.twoSV = Convert.ToInt32(Tb4.Text);
            model.idSV = CBox1.SelectedIndex;
            Tb6.Text = model.Rezultat;
        }

        private void CBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            model.idSV = CBox1.SelectedIndex;
            Tb3.Text = model.Combo;
        }
    }
}
