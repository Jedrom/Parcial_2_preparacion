using AppParcial2.Models;
using AppParcial2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppParcial2.ViewModels
{
    public class CountryViewModel:BaseViewModel
    {
        //apiservice
        #region Service
        private ApiService apiService;

        #endregion

        #region Attributes
        private string name;
        private string alpha2code;
        private string capital;
        #endregion

        #region Properties
        public string Name
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }
        public string Capital
        {
            get { return this.capital; }
            set { SetValue(ref this.capital, value); }
        }
        public string Alpha2Code
        {
            get { return this.alpha2code; }
            set { SetValue(ref this.alpha2code, value); }
        }
        #endregion

        #region Constructor
        public CountryViewModel()
        {
            apiService = new ApiService();
            this.LoadCountryAsync();
        }
        #endregion

        #region Methods
        private async void LoadCountryAsync()
        {
            var country = await this.apiService.Get<Country>(
                "https://restcountries.eu/",
                "rest/v2",
                "name/bolivia"
                );
            this.Name = country[0].Name;
            this.Capital = country[0].Capital;
            this.Alpha2Code = country[0].Alpha2Code;
        }
        #endregion
    }
}
