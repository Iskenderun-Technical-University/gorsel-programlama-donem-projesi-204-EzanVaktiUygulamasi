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
        public async void EzanT()
        {
            NamazVaktiApi ezanvakti = new NamazVaktiApi();
            ComboBoxItem deger = (ComboBoxItem)sehir.SelectedItem;
            ezanvakti.City = deger.Content.ToString();
            //var a = ezanvakti.EzanApi();
            MessageBox.Show("lkjlh");
         var a=await ezanvakti.EzanApi();
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
        }
        private async void SehirSecim_Click(object sender, RoutedEventArgs e)
        {
            //EzanT();
          //  Listte<EzanListe> acc = new Listte<EzanListe>();
          Listte aa=new Listte();
            EzanListe ezan = new EzanListe();
            List<EzanListe> lst = new List<EzanListe>();
            NamazVaktiApi ezanvakti = new NamazVaktiApi();
          //  List<EzanListe> ezanListe = new List<EzanListe>();
            ComboBoxItem deger = (ComboBoxItem)sehir.SelectedItem;
            ezanvakti.City = deger.Content.ToString();
            //var a = ezanvakti.EzanApi();
            
            var a = await ezanvakti.EzanApi();
           // MessageBox.Show(ezanvakti.City);
            if (a.IsSuccess)
            {
                var settings = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };
                /*foreach (var ezan in a.Data.data)
                {
                    MessageBox.Show($"{ezan.Date.Gregorian.Date}      {ezan.Timings.Fajr.Remove(5, 6)}       {ezan.Timings.Sunrise.Remove(5, 6)}       {ezan.Timings.Dhuhr.Remove(5, 6)}       {ezan.Timings.Asr.Remove(5, 6)}       {ezan.Timings.Sunset.Remove(5, 6)}       {ezan.Timings.Isha.Remove(5, 6)}");
                }*/
                 ezanvakti.EzanFileInput();
                
                ezanvakti.EzanFileOutput(lst, ezan);
                foreach(var item in lst)
                {
                    MessageBox.Show(item.GregMonthEn+" "+item.GregDay+" "+item.imsak);
                }

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
