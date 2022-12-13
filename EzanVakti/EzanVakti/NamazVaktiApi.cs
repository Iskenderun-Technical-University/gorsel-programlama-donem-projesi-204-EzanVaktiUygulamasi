using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Picasso.Model;
using Picasso.Services;
using Picasso.EzanVakitleri;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Windows;
using EzanVakti;

public class EzanListe
{
    public string imsak { get; set; }
    public string gunes { get; set; }
    public string ogle { get; set; }
    public string ikindi { get; set; }
    public string aksam { get; set; }

    public string yatsi { get; set; }
    public string readable { get; set; }
    public string GregDate { get; set; }
    public int GregDay { get; set; }
    public string GregWeekdayEn { get; set; }
    public string GregHaftaninGunuKisa { get; set; }
    public string GregHaftaninGunuUzun { get; set; }
    public int GregMonthNumber { get; set; }
    public string GregMonthEn { get; set; }
    public string GregAylar { get; set; }
    public string GregYear { get; set; }
    public string HijriDate { get; set; }
    public int HijriDay { get; set; }
    public string HijriWeekdayEn { get; set; }
    public int HijriMonthNumber { get; set; }
    public string HijriMonthEn { get; set; }
    public string HijriYear { get; set; }
    //public List<EzanListe> liste;
}
public class Listte
{
    public List<EzanListe> DAta { get; set; }
}
public class NamazVaktiApi
{
    private static string city;
    private int month=0;
    private int year=2022;
    private int currentMonth = 0;
    private int currentYear = 0;
    private string currentCity;
    private string DosyaYolu;
    private bool mevcutDosya;

    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public int Month
    {
        get { return month; }
        set { month = value; }
    }
    public bool MevcutDosya
    {
        get { return mevcutDosya; }
        set { mevcutDosya = value; }
    }
    public int CurrentMonth
    {
        get { return currentMonth; }
        set { currentMonth = value; }
    }
    public int CurrentYear
    {
        get { return currentYear; }
        set { currentYear = value; }
    }
    public string CurrentCity
    {
        get { return currentCity; }
        set { currentCity = value; }
    }
    public static string Place(string Sehir,int yil,int ay)
    {
       return $"http://api.aladhan.com/v1/calendarByCity?city={Sehir}&country=Turkey&method=13&month={ay}&year={yil}";
       // return $"http://api.aladhan.com/v1/calendarByCity?city={Sehir}&country=Turkey&method=13&annual=true&year={yil}";
    }
    public static string DirectoryName(string Sehir, int yil)
    {
        return $"{Sehir}/{yil}";
    }
    public static string FileName(string Sehir,int yil,int ay)
    {
        return $"/_{Sehir}_{yil}_{ay}.txt";
    }
    private async Task<HttpResult<PrayerTime>> EzanApi()
    {
        var PrayerTimeApi=Place(city,year,month);
        var httpService = new HttpClientService();
        var result = await httpService.GetObjectAsync<PrayerTime>(PrayerTimeApi);
        return result;
    }
    public async Task EzanFileInput()
    {
        string[] Aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayis","Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasim", "Aralik" };
        string[] GunlerKisa = { "Pzt", "Sal", "Çar", "Per", "Cum", "Cmt", "Paz" };
        string[] GunlerUzun = { "Pazartesi", "Sali", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
        string gunUzun="", gunKisa="";
        
        var res = await EzanApi();
        String FilePath;
        if (res.IsSuccess)
        {


            if (!Directory.Exists(@"C:\Program Files\EzanVakti"))
            {
                Directory.CreateDirectory(@"C:\Program Files\EzanVakti");
            }
            var DirectoryPath = @"C:\Program Files\EzanVakti\" + DirectoryName(city, year);
            if (!Directory.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }
            using (FileStream setting = new FileStream(@"C:\Program Files\EzanVakti\ayar.txt", FileMode.Create))
            {   
               
                //BinaryWriter setbw=new BinaryWriter(setting);
                StreamWriter setsw = new StreamWriter(setting);
                FilePath = DirectoryPath + FileName(city, year, month);
                // this.DosyaYolu = FilePath;
              await setsw.WriteLineAsync(FilePath);
                await setsw.WriteLineAsync(city);
                await setsw.WriteLineAsync(year.ToString());
                await setsw.WriteLineAsync(month.ToString());
                //   setsw.WriteLine(11);
                setsw.Close();
                
              //  setting.Close();
            }

            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                
                //BinaryWriter bw=new BinaryWriter(fs);
                StreamWriter bw = new StreamWriter(fs);
                foreach (var ezan in res.Data.data)
                {

                    await bw.WriteLineAsync(ezan.Timings.Fajr.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Timings.Sunrise.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Timings.Dhuhr.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Timings.Asr.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Timings.Sunset.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Timings.Isha.Remove(5, 6));
                    await bw.WriteLineAsync(ezan.Date.Readable);
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Date);
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Day);
                    // bw.Write(ezan.Date.Gregorian.Day);
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Weekday.En);
                    if (ezan.Date.Gregorian.Weekday.En == "Monday")
                    {
                        gunKisa = GunlerKisa[0];
                        gunUzun = GunlerUzun[0];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Tuesday")
                    {
                        gunKisa = GunlerKisa[1];
                        gunUzun = GunlerUzun[1];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Wednesday")
                    {
                        gunKisa = GunlerKisa[2];
                        gunUzun = GunlerUzun[2];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Thursday")
                    {
                        gunKisa = GunlerKisa[3];
                        gunUzun = GunlerUzun[3];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Friday")
                    {
                        gunKisa = GunlerKisa[4];
                        gunUzun = GunlerUzun[4];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Saturday")
                    {
                        gunKisa = GunlerKisa[5];
                        gunUzun = GunlerUzun[5];
                    }
                    else if (ezan.Date.Gregorian.Weekday.En == "Sunday")
                    {
                        gunKisa = GunlerKisa[6];
                        gunUzun = GunlerUzun[6];
                    }
                    await bw.WriteLineAsync(gunKisa);
                    await bw.WriteLineAsync(gunUzun);
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Month.Number.ToString());
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Month.En);
                    await bw.WriteLineAsync(Aylar[(ezan.Date.Gregorian.Month.Number) - 1]);
                    await bw.WriteLineAsync(ezan.Date.Gregorian.Year);
                    await bw.WriteLineAsync(ezan.Date.Hijri.Date);
                    await bw.WriteLineAsync(ezan.Date.Hijri.Day);
                    // bw.Write(ezan.Date.Hijri.Day);
                    await bw.WriteLineAsync(ezan.Date.Hijri.Weekday.En);
                    await bw.WriteLineAsync(ezan.Date.Hijri.Month.Number.ToString());
                    await bw.WriteLineAsync(ezan.Date.Hijri.Month.En);
                    await bw.WriteLineAsync(ezan.Date.Hijri.Year);

                }
                bw.Close();
                //  fs.Close();
              /*  MainWindow mainWindow = (Application.Current.MainWindow as MainWindow);
                Window1 window1 = new Window1();
                window1.Show();
                mainWindow.Close();*/
            }
        }
        
    }
    public void EzanFileCheck()
    {   
        
        if(!File.Exists(@"C:\Program Files\EzanVakti\ayar.txt"))
        {
            this.mevcutDosya = true;
        }

        else{
            using (FileStream ayar = new FileStream(@"C:\Program Files\EzanVakti\ayar.txt", FileMode.Open))
            {
                StreamReader sett = new StreamReader(ayar);
                this.DosyaYolu = sett.ReadLine();
                this.currentCity = sett.ReadLine();
                this.currentYear = Int32.Parse(sett.ReadLine());
                this.currentMonth = Int32.Parse(sett.ReadLine());
                sett.Close();
           //     ayar.Close();
            }
            // string filp= @"C:\Program Files\EzanVakti\hatay\2022";
            if (!File.Exists(this.DosyaYolu))
            {
                this.mevcutDosya = true;
            }
            else
            {
                this.mevcutDosya = false;
               /* using (FileStream ayar = new FileStream(@"C:\Program Files\EzanVakti\ayar.txt", FileMode.Open))
                {
                    StreamReader sett = new StreamReader(ayar);
                    this.DosyaYolu = sett.ReadLine();
                    this.currentCity = sett.ReadLine();
                    this.currentYear = Int32.Parse(sett.ReadLine());
                    this.currentMonth = Int32.Parse(sett.ReadLine());
                    sett.Close();
                 //   ayar.Close();
                }*/
               // using var watcher = new FileSystemWatcher(@"C:\Program Files\EzanVakti\ayar.txt");
               

            }
        }
    }
    public void EzanFileOutput(List<EzanListe> listitem)
    {
        if (!File.Exists(@"C:\Program Files\EzanVakti\ayar.txt"))
        {
            this.mevcutDosya = true;
        }
        else
        {


            List<EzanListe> abc = new List<EzanListe>();
            using(FileStream ayar = new FileStream(@"C:\Program Files\EzanVakti\ayar.txt", FileMode.Open))
            {
                StreamReader sett = new StreamReader(ayar);
                this.DosyaYolu = sett.ReadLine();
                this.currentCity = sett.ReadLine();
                this.currentYear = Int32.Parse(sett.ReadLine());
                this.currentMonth = Int32.Parse(sett.ReadLine());
                sett.Close();
              //  ayar.Close();
            }
            // string filp= @"C:\Program Files\EzanVakti\hatay\2022";
            if (!File.Exists(this.DosyaYolu))
            {
                this.mevcutDosya = true;
            }
            else
            {


                using (FileStream fs = new FileStream(this.DosyaYolu, FileMode.Open))
                {

                    //  BinaryReader br = new BinaryReader(fs);
                    StreamReader br = new StreamReader(fs);

                    while (!br.EndOfStream)
                    {
                        listitem.Add(new EzanListe()
                        {
                            imsak = br.ReadLine(),
                            gunes = br.ReadLine(),
                            ogle = br.ReadLine(),
                            ikindi = br.ReadLine(),
                            aksam = br.ReadLine(),
                            yatsi = br.ReadLine(),
                            readable = br.ReadLine(),
                            GregDate = br.ReadLine(),
                            GregDay = int.Parse(br.ReadLine()),
                            GregWeekdayEn = br.ReadLine(),
                            GregHaftaninGunuKisa = br.ReadLine(),
                            GregHaftaninGunuUzun = br.ReadLine(),
                            GregMonthNumber = int.Parse(br.ReadLine()),
                            GregMonthEn = br.ReadLine(),
                            GregAylar = br.ReadLine(),
                            GregYear = br.ReadLine(),
                            HijriDate = br.ReadLine(),
                            HijriDay = int.Parse(br.ReadLine()),
                            HijriWeekdayEn = br.ReadLine(),
                            HijriMonthNumber = int.Parse(br.ReadLine()),
                            HijriMonthEn = br.ReadLine(),
                            HijriYear = br.ReadLine(),
                        });
                        /*  ezanliste.imsak=br.ReadLine();
                          ezanliste.gunes=br.ReadLine();
                          ezanliste.ogle=br.ReadLine();
                          ezanliste.ikindi=br.ReadLine();
                          ezanliste.aksam=br.ReadLine();
                          ezanliste.yatsi=br.ReadLine();
                          ezanliste.readable=br.ReadLine();
                          ezanliste.GregDate=br.ReadLine();
                          ezanliste.GregDay =int.Parse(br.ReadLine());
                          ezanliste.GregWeekdayEn = br.ReadLine();
                          ezanliste.GregHaftaninGunuKisa = br.ReadLine();
                          ezanliste.GregHaftaninGunuUzun=br.ReadLine();
                          ezanliste.GregMonthNumber=int.Parse(br.ReadLine());
                          ezanliste.GregMonthEn=br.ReadLine();
                          ezanliste.GregAylar=br.ReadLine();
                          ezanliste.GregYear=br.ReadLine();
                          ezanliste.HijriDate=br.ReadLine();
                          ezanliste.HijriDay =int.Parse(br.ReadLine());
                          ezanliste.HijriWeekdayEn=br.ReadLine();
                          ezanliste.HijriMonthNumber=int.Parse(br.ReadLine());
                          ezanliste.HijriMonthEn=br.ReadLine();
                          ezanliste.HijriYear=br.ReadLine();*/

                        //e.DAta.liste.Add(ezanliste);
                        //  abc.Add(ezanliste);
                        // listitem.Add(ezanliste);
                    }
                    br.Close();
                 //   fs.Close();
                }
            }
        }
    }
    
    
    
    /*public void EzanNode()
    {
        var res = EzanApi();
        EzanListe temp=new EzanListe(), start = null, kayit=new EzanListe();
        if (res.Result.IsSuccess)
        {
            foreach (var ezan in res.Result.Data.data)
            {
                kayit.imsak = ezan.Timings.Fajr.Remove(5, 6);
                kayit.gunes=ezan.Timings.Sunrise.Remove(5, 6);
                kayit.ogle = ezan.Timings.Dhuhr.Remove(5, 6);
                kayit.ikindi = ezan.Timings.Asr.Remove(5, 6);
                kayit.aksam = ezan.Timings.Sunset.Remove(5, 6);
                kayit.yatsi = ezan.Timings.Isha.Remove(5, 6);
                kayit.readable = ezan.Date.Readable;
                kayit.GregDate = ezan.Date.Gregorian.Date;
                kayit.GregDay = Int32.Parse(ezan.Date.Gregorian.Day);
                kayit.GregWeekdayEn = ezan.Date.Gregorian.Weekday.En;
                kayit.GregMonthNumber = ezan.Date.Gregorian.Month.Number;
                kayit.GregMonthEn = ezan.Date.Gregorian.Month.En;
                kayit.GregYear = ezan.Date.Gregorian.Year;
                kayit.HijriDate = ezan.Date.Hijri.Date;
                kayit.HijriDay = Int32.Parse(ezan.Date.Hijri.Day);
                kayit.HijriWeekdayEn = ezan.Date.Hijri.Weekday.En;
                kayit.HijriMonthNumber= ezan.Date.Hijri.Month.Number;
                kayit.HijriMonthEn = ezan.Date.Hijri.Month.En;
                kayit.HijriYear = ezan.Date.Hijri.Year;

                if(start==null)
                {
                    start = kayit;
                    kayit.next = null;
                }
                else
                {
                    temp = start;
                    while(temp!=null)
                    {
                        temp = temp.next;
                    }
                    temp.next = kayit;
                    kayit.next = null;
                }

            }
        }
    }*/
}