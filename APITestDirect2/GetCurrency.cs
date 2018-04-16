using System;
using System.Collections.Generic;
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
        [TestCase("EUR", "mena")]
        [TestCase("USD", "mena")]
        [TestCase("GBP", "mena")]
        public void GetCurrency(string currency, string authority)
        {
            #region Test Data
            Dictionary<string, string> expList = new Dictionary<string, string>();
            expList.Add("EUR_mena", "{\"data\": [{\"key\":\"EUR\",\"vaultOptions\":[{\"server\":\"nf.test4\",\"group\":\"FXHQVAE\",\"authority\":\"mena\"}]}]}");
            expList.Add("USD_mena", "{\"data\": [{\"key\":\"USD\",\"vaultOptions\":[{\"server\":\"nf.test4\",\"group\":\"FXHQVAD\",\"authority\":\"mena\"}]}]}");
            expList.Add("GBP_mena", "{\"data\": [{\"key\":\"GBP\",\"vaultOptions\":[{\"server\":\"nf.test4\",\"group\":\"FXHQVAP\",\"authority\":\"mena\"}]}]}");

            JObject expectedResponse = JObject.Parse(expList[currency + "_" + authority]);
            #endregion

            JObject actualResponse;
            APIHelper.GetCurrency(BaseUrlApi, currency, authority,  out actualResponse);

            var resultDif = ObjectDiffPatch.GenerateDiff(expectedResponse, actualResponse);
            if (!resultDif.AreEqual)
                Log.Error(String.Format("\r\nExpected response \r\n {0}\r\n\r\nActual response \r\n{1}\r\n", expectedResponse, actualResponse));
            Assert.IsTrue(resultDif.AreEqual, String.Format("Expected response and Actual response see in log.\nOldValues:\n{0}\nNewValues:\n{1}", resultDif.OldValues, resultDif.NewValues));

        }
    }
}
