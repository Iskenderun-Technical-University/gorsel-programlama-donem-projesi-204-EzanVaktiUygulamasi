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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            if(__checkbox1_.IsChecked==true)
            {
                MessageBox.Show("kutu isaretli..");
            }
            else
            {
                MessageBox.Show("kutu isaretli degil..");
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ___sehir__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexval = sehir.SelectedIndex;
            string deger = sehir.Text;
            ComboBoxItem degerler = (ComboBoxItem)sehir.SelectedItem;
            string gelendeger = degerler.Content.ToString();
            MessageBox.Show("Index Deger: " + indexval + "\n" + "Degeri: " + gelendeger);
        }
    }
}
