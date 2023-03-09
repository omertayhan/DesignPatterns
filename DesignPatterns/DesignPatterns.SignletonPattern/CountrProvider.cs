using DesignPatterns.SignletonPattern.Models;

namespace DesignPatterns.SignletonPattern
{
    public class CountryProvider
    {
        private static CountryProvider instanceCountryProvider = null;

        public static CountryProvider Instance
        {
            get => instanceCountryProvider ?? (instanceCountryProvider = new CountryProvider());
        }

        private CountryProvider()
        {
            //Retrieving data from db
            Task.Delay(2000).GetAwaiter().GetResult();

            Countries = new List<Country>()
            {
                new Country() { Name = "Turkey" },
                new Country() { Name = "Holland" }
            };
        }

        private new List<Country> Countries { get; set; }

        public int CountryCount => Countries.Count;
        public async Task<List<Country>> GetCountries() => Countries;
    }
}