using Picasso.EzanVakitleri;
using Picasso.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
using Picasso;
using System.Threading;
using System.IO;
using System.Net.Http;

namespace EzanVakti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            baglantiyoklabel.Visibility = Visibility.Hidden;
            Kapat.Visibility=Visibility.Hidden;

        }


  

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }


        private async void SehirSec_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            List<EzanListe> lst = new List<EzanListe>();
            NamazVaktiApi ezanvakti = new NamazVaktiApi();

            ComboBoxItem deger = (ComboBoxItem)sehir.SelectedItem;
            ezanvakti.City = deger.Content.ToString();
            ezanvakti.Year = dt1.Year;
            ezanvakti.Month = dt1.Month;


            try
            {
                await ezanvakti.EzanFileInput();

                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
            catch (HttpRequestException)
            {
                viewboxResim.Stretch = Stretch.None;
                arkaplanresmi.Source = new BitmapImage(new Uri(@"/no-wifi.png", UriKind.RelativeOrAbsolute));
                baglantiyoklabel.Visibility = Visibility.Visible;
                Kapat.Visibility = Visibility.Visible;
                sehirseclabel.Visibility = Visibility.Hidden;
                sehir.Visibility = Visibility.Hidden;
                SehirSec.Visibility = Visibility.Hidden;
            }
        }

        private void Kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
