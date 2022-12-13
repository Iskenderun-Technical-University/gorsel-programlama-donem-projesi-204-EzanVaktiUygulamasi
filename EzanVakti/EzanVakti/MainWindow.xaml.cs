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
using Picasso.Model;
using System.Threading;
using System.IO;

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
            if (!Directory.Exists(@"C:\Program Files\EzanVakti"))
            {
                Directory.CreateDirectory(@"C:\Program Files\EzanVakti");
            }
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
        private async void SehirSecim_Click(object sender, RoutedEventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            List<EzanListe> lst = new List<EzanListe>();
            NamazVaktiApi ezanvakti = new NamazVaktiApi();

//            Window1 window1 = new Window1();

            ComboBoxItem deger = (ComboBoxItem)sehir.SelectedItem;
            ezanvakti.City = deger.Content.ToString();
            ezanvakti.Year = dt1.Year;
            ezanvakti.Month = dt1.Month;
            //var a = ezanvakti.EzanApi();

            //  var a = await ezanvakti.EzanApi();
            //essageBox.Show(ezanvakti.City);
            
                await ezanvakti.EzanFileInput();
            
            
           Window1 window1 = new Window1();
            window1.Show();
            this.Close();
            /*foreach (var ezan in a.Data.data)
            {
                MessageBox.Show($"{ezan.Date.Gregorian.Date}      {ezan.Timings.Fajr.Remove(5, 6)}       {ezan.Timings.Sunrise.Remove(5, 6)}       {ezan.Timings.Dhuhr.Remove(5, 6)}       {ezan.Timings.Asr.Remove(5, 6)}       {ezan.Timings.Sunset.Remove(5, 6)}       {ezan.Timings.Isha.Remove(5, 6)}");
            }*/
            /*using var watcher = new FileSystemWatcher(@"C:\Program Files\EzanVakti");
            watcher.NotifyFilter= NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;
            watcher.Created += OnCreated;
            watcher.Changed+=OnChanged;
             watcher.Filter = "*.txt";
            //watcher.Path = @"C:\Program Files\EzanVakti";
            watcher.IncludeSubdirectories = true;
           watcher.EnableRaisingEvents = true;
            textbox1.Text = "Dosya olusturuldu";*/
            
            // MessageBox.Show("Dosya olusturuldu");

            /*ezanvakti.EzanFileOutput(lst);
             foreach(var item in lst)
             {
                 MessageBox.Show(item.GregMonthEn+" "+item.GregDay+" "+item.imsak);
             }*/


          
            nextPage.Visibility=Visibility.Visible;
           
         
        }


        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            /*Window1 window1 = new Window1();
            window1.Show();
            this.Close();
            MessageBox.Show("sdgff");*/
            if (!FileIsReady(@"C:\Program Files\EzanVakti\ayar.txt")) return;
            MessageBox.Show("sdgff");
        }
        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            MessageBox.Show($"Changed: {e.FullPath}");
        }
        private bool FileIsReady(string path)
        {
            try
            {
                //If we can't open the file, it's still copying
                using (var file = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    return true;
                }
            }
            catch (IOException)
            {
                return false;
            }
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
