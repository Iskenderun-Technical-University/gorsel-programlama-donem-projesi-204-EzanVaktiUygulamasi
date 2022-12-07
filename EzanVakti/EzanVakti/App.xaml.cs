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
        private void Application_Startup(object sender, StartupEventArgs e)
        {
           NamazVaktiApi namaz=new NamazVaktiApi();
            namaz.EzanFileCheck();
            if(namaz.MevcutDosya==false)
            {
                Window1 window1 = new Window1();
                window1.Show();
            }
            else if(namaz.MevcutDosya==true)
            {
                MainWindow window = new MainWindow();
                window.Show();
            }

        }
    }
}
