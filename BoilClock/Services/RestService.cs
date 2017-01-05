using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Android.Content;
using BoilClock.Models;
using Newtonsoft.Json;

namespace BoilClock.Services
{
    public static class RestService
    {
        private const string RestApiUrl = "http://boilapi.apphb.com/api";

        private static string GetProductUrl(string id) => $"{RestApiUrl}/products/{id}";

        private static string GetProductsByCategoryUrl(int id) => $"{RestApiUrl}/products";

        private static string GetCategoriesUrl() => $"{RestApiUrl}/categories";

        private static string GetFavoritesUrl() => $"{RestApiUrl}/getfavorites";

        private static string GetSearchUrl(string query) => $"{RestApiUrl}/search/{query}";

        public static async Task<ProductDetail> GetProduct(string id)
        {
            var url = GetProductUrl(id);
            var result = await FetcDataAsync<ProductDetail>(url);
            return result;
        }

        public static async Task<IEnumerable<ProductListItem>> GetProductsByCategory(int id)
        {
            var url = GetProductsByCategoryUrl(id);
            var result = await FetcDataAsync<IEnumerable<ProductListItem>>(url);
            return result;
        }

        public static async Task<IEnumerable<Category>> GetCategories()
        {
            var result = await FetcDataAsync<IEnumerable<Category>>(GetCategoriesUrl());
            return result;
        }

        public static async Task<IEnumerable<ProductListItem>> GetFavorites()
        {
            var result = await FetcDataAsync<IEnumerable<ProductListItem>>(GetFavoritesUrl());
            return result;
        }

        public static async Task<IEnumerable<ProductListItem>> Search(string query)
        {
            var result = await FetcDataAsync<IEnumerable<ProductListItem>>(GetSearchUrl(query));
            return result;
        }

        private static async Task<T> FetcDataAsync<T>(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(url);
                var result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }
        }
    }
}