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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace EzanVakti
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {    
        DispatcherTimer _timer;
        TimeSpan _time;
        
        public Window1()
        {
            InitializeComponent();
            DateTime bugun=DateTime.Now;
            DateTime dt = new DateTime();
            NamazVaktiApi namaz = new NamazVaktiApi();
            List<EzanListe> liste = new List<EzanListe>();
            EzanListe ezan = new EzanListe();
            namaz.EzanFileOutput(liste);

            foreach(var item in liste)
            {
                if(item.GregDay==bugun.Day)
                {   
                    ezan=item;
                  //  MessageBox.Show(item.GregDay+" "+item.GregAylar+" "+item.GregYear);
                    break;
                }

            }
            GregLabel.Content = ezan.GregDay + " " + ezan.GregAylar + " " + ezan.GregYear;
            YerelSaatLabel.Content = bugun.Hour + ":" + bugun.Minute;
           
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
