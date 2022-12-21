using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace EzanVakti
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private async void Application_Startup(object sender, StartupEventArgs e)
        {
           NamazVaktiApi namaz=new NamazVaktiApi();
            DateTime date = DateTime.Now;
            namaz.EzanFileCheck();
            if(namaz.MevcutDosya==false)
            {
                if (date.Year == namaz.CurrentYear && date.Month == namaz.CurrentMonth)
                {
                    Window1 window1 = new Window1();
                    window1.Show();
                }
                else
                {   
                    
                    namaz.City = namaz.CurrentCity;
                    namaz.Year = date.Year;
                    namaz.Month = date.Month;
                    try
                    {
                        await namaz.EzanFileInput();

                        Window1 window2 = new Window1();
                        window2.Show();
                    }
                    catch (HttpRequestException)
                    {
                        MainWindow mainWindow = (Application.Current.MainWindow as MainWindow);
                        mainWindow.Show();
                        mainWindow.viewboxResim.Stretch = Stretch.None;
                        mainWindow.arkaplanresmi.Source = new BitmapImage(new Uri(@"/no-wifi.png", UriKind.RelativeOrAbsolute));
                        mainWindow.baglantiyoklabel.Visibility = Visibility.Visible;
                        mainWindow.Kapat.Visibility = Visibility.Visible;
                        mainWindow.sehirseclabel.Visibility = Visibility.Hidden;
                        mainWindow.sehir.Visibility = Visibility.Hidden;
                        mainWindow.SehirSec.Visibility = Visibility.Hidden;
                    }
                }
            }
            else if(namaz.MevcutDosya==true)
            {
                MainWindow window = new MainWindow();
                window.Show();
            }

        }
    }
}
