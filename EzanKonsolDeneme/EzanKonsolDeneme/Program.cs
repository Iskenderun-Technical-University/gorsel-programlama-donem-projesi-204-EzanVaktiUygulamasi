using System;
using System.Collections;
using System.Text.Json;
using System.Threading.Tasks;
using Picasso.EzanVakti;
using Picasso.Services;
using Picasso;

namespace ezan_vakti_konsol
{

    class Program
    {
        public static string Place(string city)
        {
            return $"http://api.aladhan.com/v1/calendarByCity?city={city}&country=Turkey&method=13&month=11&year=2022";
        }
        static async Task Main(string[] args)
        {
            Console.Write("Sehir Giriniz: ");
            var city = Console.ReadLine();
            var prayerTimeApi = Place(city);
            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<PrayerTime>(prayerTimeApi);

            if (result.IsSuccess)
            {
                var settings = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };
                Console.WriteLine("Tarih    :      Imsak       Gunes       Ogle        Ikindi      Aksam       Yatsi");
                foreach (var ezan in result.Data.data)
                {
                    Console.WriteLine($"{ezan.Date.Gregorian.Date}      {ezan.Timings.Fajr.Remove(5,6)}       {ezan.Timings.Sunrise.Remove(5,6)}       {ezan.Timings.Dhuhr.Remove(5,6)}       {ezan.Timings.Asr.Remove(5,6)}       {ezan.Timings.Sunset.Remove(5, 6)}       {ezan.Timings.Isha.Remove(5,6)}");
                }
            }
            else
            {
                Console.WriteLine($"{result.ErrorMessage}");
            }

        }
    }
}
