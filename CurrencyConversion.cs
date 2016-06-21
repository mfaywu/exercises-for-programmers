using System;
using System.Collections.Generic;
using System.Net;

using System.Runtime.Serialization.Json;

public class Rates
{
    public double AUD { get; set; }
    public double BGN { get; set; }
    public double BRL { get; set; }
    public double CAD { get; set; }
    public double CHF { get; set; }
    public double CNY { get; set; }
    public double CZK { get; set; }
    public double DKK { get; set; }
    public double GBP { get; set; }
    public double HKD { get; set; }
    public double HRK { get; set; }
    public double HUF { get; set; }
    public double IDR { get; set; }
    public double ILS { get; set; }
    public double INR { get; set; }
    public double JPY { get; set; }
    public double KRW { get; set; }
    public double MXN { get; set; }
    public double MYR { get; set; }
    public double NOK { get; set; }
    public double NZD { get; set; }
    public double PHP { get; set; }
    public double PLN { get; set; }
    public double RON { get; set; }
    public double RUB { get; set; }
    public double SEK { get; set; }
    public double SGD { get; set; }
    public double THB { get; set; }
    public double TRY { get; set; }
    public double ZAR { get; set; }
    public double EUR { get; set; }
}

public class RootObject
{
    public string @base { get; set; }
    public string date { get; set; }
    public Rates rates { get; set; }
}

public class CurrencyConversion
{
	public static void Main() {
		CurrencyConversion calculator = new CurrencyConversion();
		
		Dictionary<string, decimal> exchangeRates = calculator.getExchangeRates();

		
		Console.WriteLine("What is the currency you are exchanging from? (? -> USD). Enter 'list' to display list of currencies.");
		string currencyEntry = Console.ReadLine();
		while (!exchangeRates.ContainsKey(currencyEntry)) {
			if (currencyEntry == "list") {
				Console.WriteLine("Available currencies: ");
				foreach (KeyValuePair<string, decimal> item in exchangeRates) {
					Console.Write(item.Key + " ");
				}
			}
			else {
				Console.WriteLine("Please enter a valid currency.");	
			}
			Console.WriteLine("What is the currency you are exchanging from? (? -> USD). Enter 'list' to display list of currencies.");
			currencyEntry = Console.ReadLine();
		}
		
		Console.WriteLine("How much " + currencyEntry + " are you exchanging?");
		string moneyEntry = Console.ReadLine();
		decimal money;
		while (!decimal.TryParse(moneyEntry, out money) || money <= 0 || (Decimal.Round(money, 2) != money)) {
			Console.WriteLine("Must be a valid amount of money greater than 0. Enter amount to exchange: ");
			moneyEntry = Console.ReadLine();
		}
		
		decimal rate = exchangeRates[currencyEntry];
		
		decimal exchangedMoney = calculator.exchange(money, rate);
		
		Console.WriteLine(money + " " + currencyEntry + " at an exchange rate of " + rate + " is " + exchangedMoney + " USD.");
	}
	
	public decimal exchange (decimal money, decimal rate) {
		decimal exchanged = money / rate;
		return Math.Ceiling(exchanged * 100) / 100;
	}
	
	public Dictionary<string, decimal> getExchangeRates () {
		
		string url = "http://api.fixer.io/latest?base=USD";
		
		try {
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
        	{
				if (response.StatusCode != HttpStatusCode.OK)
                throw new Exception(String.Format(
                "Server error (HTTP {0}: {1}).",
                response.StatusCode,
                response.StatusDescription));

				Console.WriteLine(response);
				DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Response));
            	object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
            	Response jsonResponse
            	= objResponse as Response;
				
				//TODO: Got response
			}
		}
		catch (Exception e) {
			Console.WriteLine(e.Message);
		}
		
		Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>();
		exchangeRates.Add("EUR", (decimal)0.89);
		return exchangeRates;
	}
}