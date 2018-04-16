using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Remoting.Messaging;
using APITestDirect2.Infrastructure;
using Newtonsoft.Json.Linq;
using NUnit.Framework;


namespace APITestDirect2
{
    [TestFixture]
    public partial class APITestDirect2
    {
        [Test]

        [TestCase("USD", "USD")]
        [TestCase("EUR", "USD")]
        [TestCase("GBP", "USD")]
        //[TestCase("CHF", "USD")]
        //[TestCase("JPY", "USD")]
        //[TestCase("PLN", "USD")]
        //[TestCase("AUD", "USD")]

        [TestCase("USD", "EUR")]
        [TestCase("EUR", "EUR")]
        [TestCase("GBP", "EUR")]
        //[TestCase("CHF", "EUR")]
        //[TestCase("JPY", "EUR")]
        //[TestCase("PLN", "EUR")]
        //[TestCase("AUD", "EUR")]

        [TestCase("USD", "GBP")]
        [TestCase("EUR", "GBP")]
        [TestCase("GBP", "GBP")]
        //[TestCase("CHF", "GBP")]
        //[TestCase("JPY", "GBP")]
        //[TestCase("PLN", "GBP")]
        //[TestCase("AUD", "GBP")]

        //[TestCase("USD", "CHF")]
        //[TestCase("EUR", "CHF")]
        //[TestCase("GBP", "CHF")]
        [TestCase("CHF", "CHF")]
        //[TestCase("JPY", "CHF")]
        //[TestCase("PLN", "CHF")]
        //[TestCase("AUD", "CHF")]

        //[TestCase("USD", "JPY")]
        //[TestCase("EUR", "JPY")]
        //[TestCase("GBP", "JPY")]
        //[TestCase("CHF", "JPY")]
        [TestCase("JPY", "JPY")]
        //[TestCase("PLN", "JPY")]
        //[TestCase("AUD", "JPY")]

        //[TestCase("USD", "PLN")]
        //[TestCase("EUR", "PLN")]
        //[TestCase("GBP", "PLN")]
        //[TestCase("CHF", "PLN")]
        //[TestCase("JPY", "PLN")]
        [TestCase("PLN", "PLN")]
        //[TestCase("AUD", "PLN")]

        //[TestCase("USD", "AUD")]
        //[TestCase("EUR", "AUD")]
        //[TestCase("GBP", "AUD")]
        //[TestCase("CHF", "AUD")]
        //[TestCase("JPY", "AUD")]
        //[TestCase("PLN", "AUD")]
        [TestCase("AUD", "AUD")]

        public void GetExchangeRates(string fromCurrency, string toCurrency)
        {
            #region Test Data
            string response;
            #endregion

            Assert.AreEqual(HttpStatusCode.OK, APIHelper.GetExchangeRates(BaseUrlApi, fromCurrency, toCurrency, out response), response);

        }
    }
}
