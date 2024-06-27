using Covid_Mvc_Project.Models;
using Newtonsoft.Json;

namespace Covid_Mvc_Project.Repository
{
    public class CovidService
    {
        private readonly HttpClient _httpClient;

        public CovidService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<CovidDataViewModel> GetCovidDataAsync(string country)
        {
            string apiUrl = $"https://disease.sh/v3/covid-19/countries/{country}";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                CovidDataViewModel data = JsonConvert.DeserializeObject<CovidDataViewModel>(json);
                return data;
            }

            return null;
        }
    }
}
