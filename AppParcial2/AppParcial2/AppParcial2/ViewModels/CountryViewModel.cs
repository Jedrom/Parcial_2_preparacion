using System;
using System.Collections.Generic;
using System.Text;

namespace AppParcial2.ViewModels
{
    class CountryViewModel:BaseViewModel
    {
        //apiservice

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
        public string Alpha2code
        {
            get { return this.alpha2code; }
            set { SetValue(ref this.alpha2code, value); }
        }
        #endregion

        #region Constructor
        public CountryViewModel()
        {
            this.LoadCountry();
        }
        #endregion

        #region Methods
        private void LoadCountry()
        {
            //llamar api
        }
        #endregion
    }
}
