using SebastianCruzPersonalizacionMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using SebastianCruzPersonalizacionMaui.Models;

namespace SebastianCruzPersonalizacionMaui.Services
{
    public class ApiServiceSC
    {
        private readonly HttpClient _httpClient;

        public ApiServiceSC()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://tuapiurl.com/api/")
            };
        }

        public async Task<List<BurgerSC>> GetBurgersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<BurgerSC>>("Burger");
        }

        public async Task<BurgerSC> GetBurgerByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<BurgerSC>($"Burger/{id}");
        }

        public async Task<List<PromoSC>> GetPromosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<PromoSC>>("Promo");
        }

        public async Task<PromoSC> GetPromoByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<PromoSC>($"Promo/{id}");
        }
    }
}
