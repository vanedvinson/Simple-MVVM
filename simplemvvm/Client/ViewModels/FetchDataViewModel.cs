using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleMVVM.Shared;

namespace SimpleMVVM.Client.ViewModels
{
    public interface IFetchDataViewModel
    {
        //We have made a private array with a public property in the class to hold and expose our WeatherForecast[].
        WeatherForecast[] WeatherForecasts { get; set; }
    }
    public class FetchDataViewModel : IFetchDataViewModel
    {
        private WeatherForecast[] _weatherForecasts;
        public WeatherForecast[] WeatherForecasts
        {
            get => _weatherForecasts;
            set => _weatherForecasts = value;
        }
        public FetchDataViewModel()
        {
            Console.WriteLine("FetchDataViewModel Constructor Executing");
        }
    }
}
