using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleMVVM.Client.Models;
using SimpleMVVM.Shared;

namespace SimpleMVVM.Client.ViewModels
{
    public interface IFetchDataViewModel
    {
        //We have made a private array with a public property in the class to hold and expose our WeatherForecast[].
        WeatherForecast[] WeatherForecasts { get; set; }
        Task RetrieveForecastsAsync();
    }
    public class FetchDataViewModel : IFetchDataViewModel
    {
        private WeatherForecast[] _weatherForecasts;
        private IFetchDataModel _fetchDataModel;
        public WeatherForecast[] WeatherForecasts
        {
            get => _weatherForecasts;
            set => _weatherForecasts = value;
        }
        public FetchDataViewModel(IFetchDataModel fetchDataModel)
        {
            Console.WriteLine("FetchDataViewModel Constructor Executing");
            _fetchDataModel = fetchDataModel;
        }

        public async Task RetrieveForecastsAsync()
        {
            _weatherForecasts = await _fetchDataModel.RetrieveForecastsAsync();
            Console.WriteLine("FetchDataViewModel Forecasts Retrieved");
        }

   
    }
}
