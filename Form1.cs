using Newtonsoft.Json; //JSON Deserialize
using RestSharp; //HTTP requests to the API
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CurrencyConverter
//Author: Jayden Robertson
//Date: 13/03/2025
//Description: Convert an amount from one currency to another using real-time exchange rates fetched from the CurrencyAPI service
{
    public partial class Form1 : Form
    {
        //Dictionary to store currency codes and their exchange rates
        private Dictionary<string, double> currencies = new Dictionary<string, double>();
        public Form1()
        {
            InitializeComponent(); 

            //Get the latest currency exachange rates from the API
            var currenciesJson = GetLatestCurrency();

            //Deserialize the JSON into an object
            dynamic responseObject = JsonConvert.DeserializeObject(currenciesJson);

            //Loop through all the currencies and populate the combo boxes and dictionary
            foreach (var item in responseObject.data)
            {
                var currency = item.Value;
                this.comboBoxFromCurrency.Items.Add(currency.code.ToString());
                this.comboBoxToCurrency.Items.Add(currency.code.ToString());
                this.currencies.Add(currency.code.ToString(), (double)currency.value);
            }
        }

        //Method to get the latest currency exchange rates from the API - code provided by API documentation
        private string GetLatestCurrency()
        {
            var client = new RestClient("https://api.currencyapi.com/v3/latest");
            var request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("apikey", "cur_live_mCubawOnevrS2NGS0h443xFtYyth0VwahkfEmBFb");
            RestResponse response = client.Execute(request);
            return response.Content;
        }

        //Event handler for clear button 
        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear all inputs and result label
            this.textBoxAmount.Text = "";
            this.comboBoxFromCurrency.Text = "";
            this.comboBoxToCurrency.Text = "";
            this.labelConvertAmount.Text = "";
        }

        //Label event handler
        private void labelConvertAmount_Click(object sender, EventArgs e)
        {
            this.Text = ""; //This does nothing
        }

        //Event handler for convert button
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            var selectedFromCurrency = this.comboBoxFromCurrency.SelectedItem.ToString(); //Select from currency
            var selectedToCurrency = this.comboBoxToCurrency.SelectedItem.ToString(); //Select to currency
            var amount = double.Parse(this.textBoxAmount.Text); //Parse amount entered by the user

            //Get the exchange rates for the selected currencies
            var fromCurrencyExchangeRate = currencies[selectedFromCurrency];
            var toCurrencyExchangeRate = currencies[selectedToCurrency];

            //Calculate the converted amount
            var calculatedAmount = amount * (toCurrencyExchangeRate / fromCurrencyExchangeRate);

            this.labelConvertAmount.Text = "Result: " + calculatedAmount.ToString(); //Display the result back to the user
        }
    }
}
