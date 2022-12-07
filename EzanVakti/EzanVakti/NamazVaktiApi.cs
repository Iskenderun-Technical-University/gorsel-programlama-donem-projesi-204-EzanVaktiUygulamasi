using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Picasso.Model;
using Picasso.Services;
using Picasso.EzanVakti;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Windows;

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
    private int ay=0;
    private int year = 2022;
    private string DosyaYolu;
    private bool mevcutDosya;
    public string a="kuh";

    public string City
    {
        get { return city; }
        set { city = value; }
    }
    public int Ay
    {
        get { return ay; } 
        set { ay = value; } 
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public static string Place(string Sehir)
    {
        return $"http://api.aladhan.com/v1/calendarByCity?city={Sehir}&country=Turkey&method=13&month=11&year=2022";
    }
    public static string DirectoryName(string Sehir, int yil)
    {
        return $"{Sehir}/{yil}";
    }
    public static string FileName(string Sehir,int yil)
    {
        return $"/_{Sehir}_{yil}.txt";
    }
    public async Task<HttpResult<PrayerTime>> EzanApi()
    {
        var PrayerTimeApi=Place(city);
        var httpService = new HttpClientService();
        var result = await httpService.GetObjectAsync<PrayerTime>(PrayerTimeApi);
        return result;
    }
    public async void EzanFileInput()
    {
        string[] Aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayis", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasim", "Aralik" };
        string[] GunlerKisa = { "Pzt", "Sal", "Çar", "Per", "Cum", "Cmt", "Paz" };
        string[] GunlerUzun = { "Pazartesi", "Sali", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
        string gunUzun="", gunKisa="";
        var res = await EzanApi();
            if (!Directory.Exists(@"C:\Program Files\EzanVakti"))
            {
                Directory.CreateDirectory(@"C:\Program Files\EzanVakti");
            }
            var DirectoryPath = @"C:\Program Files\EzanVakti\" + DirectoryName(city, year);
            if (!Directory.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }
            FileStream setting=new FileStream(@"C:\Program Files\EzanVakti\ayar.txt", FileMode.Create);
        //BinaryWriter setbw=new BinaryWriter(setting);
        StreamWriter setsw = new StreamWriter(setting);
            var FilePath = DirectoryPath + FileName(city, year);
           // this.DosyaYolu = FilePath;
            setsw.Write(FilePath);
            setsw.Close();
            FileStream fs=new FileStream(FilePath, FileMode.Create);
        //BinaryWriter bw=new BinaryWriter(fs);
        StreamWriter bw = new StreamWriter(fs);
          foreach(var ezan in res.Data.data)
          {   
              
              bw.Write(ezan.Timings.Fajr.Remove(5, 6));
              bw.Write(ezan.Timings.Sunrise.Remove(5, 6));
              bw.Write(ezan.Timings.Dhuhr.Remove(5,6));
              bw.Write(ezan.Timings.Asr.Remove(5, 6));
              bw.Write(ezan.Timings.Sunset.Remove(5, 6));
              bw.Write(ezan.Timings.Isha.Remove(5, 6));
              bw.Write(ezan.Date.Readable);
              bw.Write(ezan.Date.Gregorian.Date);
            //  bw.Write(Int32.Parse(ezan.Date.Gregorian.Day));
            bw.Write(ezan.Date.Gregorian.Day);
              bw.Write(ezan.Date.Gregorian.Weekday.En);
            if(ezan.Date.Gregorian.Weekday.En=="Monday")
            {
                gunKisa = GunlerKisa[0];
                gunUzun = GunlerUzun[0];
            }
            else if(ezan.Date.Gregorian.Weekday.En=="Tuesday")
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
            bw.Write(gunKisa);
            bw.Write(gunUzun);
            bw.Write(ezan.Date.Gregorian.Month.Number.ToString);
              bw.Write(ezan.Date.Gregorian.Month.En);
              bw.Write(Aylar[(ezan.Date.Gregorian.Month.Number) - 1]);
              bw.Write(ezan.Date.Gregorian.Year);
              bw.Write(ezan.Date.Hijri.Date);
            //  bw.Write(Int32.Parse(ezan.Date.Hijri.Day));
              bw.Write(ezan.Date.Hijri.Day);
              bw.Write(ezan.Date.Hijri.Weekday.En);
              bw.Write(ezan.Date.Hijri.Month.Number);
              bw.Write(ezan.Date.Hijri.Month.En);
              bw.Write(ezan.Date.Hijri.Year);

          }
        bw.Close();
    }
    public void EzanFileOutput(List<EzanListe> listitem,EzanListe ezanliste)
    {
        Listte e = new Listte();
        List<EzanListe> abc = new List<EzanListe>();
       // EzanListe ezanliste=new EzanListe();
        FileStream ayar = new FileStream(@"C:\Program Files\EzanVakti\ayar.txt", FileMode.Open);
        BinaryReader sett = new BinaryReader(ayar);
        this.DosyaYolu = sett.ReadString();
        sett.Close();
      // string filp= @"C:\Program Files\EzanVakti\hatay\2022";
        if (!File.Exists(this.DosyaYolu))
        {
            this.mevcutDosya = true;
        }
        else
        {


            FileStream fs = new FileStream(this.DosyaYolu, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

                
            while(br.BaseStream.Position<br.BaseStream.Length)
                { 
                    ezanliste.imsak=br.ReadString();
                    ezanliste.gunes=br.ReadString();
                    ezanliste.ogle=br.ReadString();
                    ezanliste.ikindi=br.ReadString();
                    ezanliste.aksam=br.ReadString();
                    ezanliste.yatsi=br.ReadString();
                    ezanliste.readable=br.ReadString();
                    ezanliste.GregDate=br.ReadString();
                    ezanliste.GregDay = br.ReadInt32();
                    ezanliste.GregWeekdayEn = br.ReadString();
                    ezanliste.GregHaftaninGunuKisa = br.ReadString();
                    ezanliste.GregHaftaninGunuUzun=br.ReadString();
                    ezanliste.GregMonthNumber=br.ReadInt32();
                    ezanliste.GregMonthEn=br.ReadString();
                    ezanliste.GregAylar=br.ReadString();
                    ezanliste.GregYear=br.ReadString();
                    ezanliste.HijriDate=br.ReadString();
                    ezanliste.HijriDay = br.ReadInt32();
                    ezanliste.HijriWeekdayEn=br.ReadString();
                    ezanliste.HijriMonthNumber=br.ReadInt32();
                    ezanliste.HijriMonthEn=br.ReadString();
                    ezanliste.HijriYear=br.ReadString();

                //e.DAta.liste.Add(ezanliste);
                //  abc.Add(ezanliste);
                listitem.Add(ezanliste);
                }
                br.Close();
            
            
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