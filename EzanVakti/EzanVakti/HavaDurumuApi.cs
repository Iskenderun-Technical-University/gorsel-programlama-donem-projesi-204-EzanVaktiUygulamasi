using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Picasso.Model;
using Picasso.Services;
using Picasso.HavaDurumu;

namespace EzanVakti
{
    public class HavaDurumuApi
    {
        private string city;
       public HavaDurumuApi()
        {

        }
        public HavaDurumuApi(string city)
        {
            this.city = city;
        }
        public static string Place(string Sehir)
        {
            return $"https://api.openweathermap.org/data/2.5/weather?q={Sehir}&mode=json&lang=tr&units=metric&appid=f0a46c1cf8fe28d014ed0783f9884b23";
        }
        public async Task<Picasso.Model.HttpResult<Weather>> WeatherApi()
        {
            var WeatherForecastApi = Place(city);
            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<Weather>(WeatherForecastApi);
            return result;
        }
    }
}
