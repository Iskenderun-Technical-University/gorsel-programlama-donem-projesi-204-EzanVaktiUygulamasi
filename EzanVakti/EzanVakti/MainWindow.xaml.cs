using Picasso.EzanVakti;
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
using Picasso.Model;
using System.Threading;

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
            nextPage.Visibility = Visibility.Hidden;
            /*MainWindow window = new MainWindow();
            Window1 window1 = new Window1();
            NamazVaktiApi a = new NamazVaktiApi();
            List<EzanListe> lst = new List<EzanListe>();
            a.EzanFileOutput(lst);
            if(a.MevcutDosya==false)
            {
                window.Close();
                window1.Show();
            }*/
        }
        /* public static string Place(string city)
         {
             return $"http://api.aladhan.com/v1/calendarByCity?city={city}&country=Turkey&method=13&month=11&year=2022";
         }
         public async Task<HttpResult<PrayerTime>> ezantime()
         {
            ComboBoxItem degerler = (ComboBoxItem)sehir.SelectedItem;
            var city = degerler.Content.ToString();
           //  MessageBox.Show(city);
             var prayerTimeApi = Place(city);
             var httpService = new HttpClientService();
             var result = await httpService.GetObjectAsync<PrayerTime>(prayerTimeApi);
            /* if (result.IsSuccess)
             {
                 var settings = new JsonSerializerOptions()
                 {
                     WriteIndented = true
                 };
                 MessageBox.Show("basarili");
                    foreach (var ezan in result.Data.data)
                    {
                    // MessageBox.Show("Tarih    :      Imsak       Gunes       Ogle        Ikindi      Aksam       Yatsi");
                     MessageBox.Show($"{ezan.Date.Gregorian.Date}      {ezan.Timings.Fajr.Remove(5, 6)}       {ezan.Timings.Sunrise.Remove(5, 6)}       {ezan.Timings.Dhuhr.Remove(5, 6)}       {ezan.Timings.Asr.Remove(5, 6)}       {ezan.Timings.Sunset.Remove(5, 6)}       {ezan.Timings.Isha.Remove(5, 6)}");
                    }
             }
             else
             {
                 MessageBox.Show($"{result.ErrorMessage}");

             }
             return result;

         }*/
  /*      public async void EzanT()
        {
            NamazVaktiApi ezanvakti = new NamazVaktiApi();
            ComboBoxItem deger = (ComboBoxItem)sehir.SelectedItem;
            ezanvakti.City = deger.Content.ToString();
            //var a = ezanvakti.EzanApi();
            MessageBox.Show("lkjlh");
     //    var a=await ezanvakti.EzanApi();
            MessageBox.Show(ezanvakti.City);
            if (a.IsSuccess)
            {
                var settings = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };
                foreach (var ezan in a.Data.data)
                {
                    MessageBox.Show($"{ezan.Date.Gregorian.Date}      {ezan.Timings.Fajr.Remove(5, 6)}       {ezan.Timings.Sunrise.Remove(5, 6)}       {ezan.Timings.Dhuhr.Remove(5, 6)}       {ezan.Timings.Asr.Remove(5, 6)}       {ezan.Timings.Sunset.Remove(5, 6)}       {ezan.Timings.Isha.Remove(5, 6)}");
                }

            }
        }*/
        private void SehirSecim_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            List<EzanListe> lst = new List<EzanListe>();
            NamazVaktiApi ezanvakti = new NamazVaktiApi();
            
            ComboBoxItem deger = (ComboBoxItem)sehir.SelectedItem;
            ezanvakti.City = deger.Content.ToString();
            ezanvakti.Year = dt1.Year;
            ezanvakti.Month = dt1.Month;
            //var a = ezanvakti.EzanApi();
            
          //  var a = await ezanvakti.EzanApi();
            //essageBox.Show(ezanvakti.City);
         
            ezanvakti.EzanFileInput();
            /*foreach (var ezan in a.Data.data)
            {
                MessageBox.Show($"{ezan.Date.Gregorian.Date}      {ezan.Timings.Fajr.Remove(5, 6)}       {ezan.Timings.Sunrise.Remove(5, 6)}       {ezan.Timings.Dhuhr.Remove(5, 6)}       {ezan.Timings.Asr.Remove(5, 6)}       {ezan.Timings.Sunset.Remove(5, 6)}       {ezan.Timings.Isha.Remove(5, 6)}");
            }*/
            textbox1.Text = "Dosya olusturuldu";
            // MessageBox.Show("Dosya olusturuldu");

            /*ezanvakti.EzanFileOutput(lst);
             foreach(var item in lst)
             {
                 MessageBox.Show(item.GregMonthEn+" "+item.GregDay+" "+item.imsak);
             }*/

            //window1.Show();
            //this.Close();*/
          
            nextPage.Visibility=Visibility.Visible;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void DosyaOut_Click(object sender, RoutedEventArgs e)
        {
            NamazVaktiApi ezanvakti = new NamazVaktiApi();
            List<EzanListe> lst = new List<EzanListe>();
            ezanvakti.EzanFileOutput(lst);
            foreach (var item in lst)
            {
                MessageBox.Show(item.GregMonthEn + " " + item.GregDay + " " + item.imsak);
            }
        }

        private void nextPage_Click(object sender, RoutedEventArgs e)
        {
            NamazVaktiApi namaz = new NamazVaktiApi();
            namaz.EzanFileCheck();
            if (!namaz.MevcutDosya)
            {
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bir sorun oluştu\nTekrar Deneyiniz..");
            }
        }
    }
}
