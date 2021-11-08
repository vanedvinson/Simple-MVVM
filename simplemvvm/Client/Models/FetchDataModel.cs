using SimpleMVVM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace SimpleMVVM.Client.Models
{
    public interface IFetchDataModel
    {
        Task<WeatherForecast[]> RetrieveForecastsAsync();
        
    }
    public class FetchDataModel : IFetchDataModel
    {
        private HttpClient _http;
        public FetchDataModel(HttpClient http)
        {
            _http = http;
        }

        public async Task<WeatherForecast[]> RetrieveForecastsAsync()
        {
            return await _http.GetFromJsonAsync<WeatherForecast[]>("api/SampleData/WeatherForecasts");
        }
    }
}