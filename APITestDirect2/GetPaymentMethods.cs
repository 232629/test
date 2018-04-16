using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Text;
using APITestDirect2.Infrastructure;
using Newtonsoft.Json.Linq;
using NUnit.Framework;


namespace APITestDirect2
{
    [TestFixture]
    public partial class APITestDirect2
    {
        [Test]
        [Ignore("https://fxpropm.atlassian.net/browse/DUI-445")]
        [TestCase("mena", "AE")]

        public void GetPaymentMethods(string authority, string country)
        {
            #region Test Data
            Dictionary<string, string> expList = new Dictionary<string, string>();
            expList.Add("mena_AE", System.IO.File.ReadAllText(jsonResponses + "GetPaymentMethods.authority=mena.country=AE.json", Encoding.Default));

            JObject expectedResponse = JObject.Parse(expList[authority + "_" + country]);
            #endregion

            JObject actualResponse;
            APIHelper.GetPaymentMethods(BaseUrlApi, authority, country, out actualResponse);

            var resultDif = ObjectDiffPatch.GenerateDiff(expectedResponse, actualResponse);
            if (!resultDif.AreEqual)
                Log.Error(String.Format("\r\nExpected response \r\n {0}\r\n\r\nActual response \r\n{1}\r\n", expectedResponse, actualResponse));
            Assert.IsTrue(resultDif.AreEqual, String.Format("Expected response and Actual response see in log.\nOldValues:\n{0}\nNewValues:\n{1}", resultDif.OldValues, resultDif.NewValues));

        }
    }
}
