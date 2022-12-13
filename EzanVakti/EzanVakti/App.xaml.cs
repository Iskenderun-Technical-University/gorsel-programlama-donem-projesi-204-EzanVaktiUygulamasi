using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

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
                    await namaz.EzanFileInput();
                    //namaz.MevcutDosya = true;
                   /* while(true)
                    {    NamazVaktiApi ezancheck=new NamazVaktiApi();
                        ezancheck.EzanFileCheck();
                        if (date.Year == ezancheck.CurrentYear && date.Month == ezancheck.CurrentMonth)
                        {
                            break;

                        }
                    }*/
                    Window1 window2 = new Window1();
                    window2.Show();
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
