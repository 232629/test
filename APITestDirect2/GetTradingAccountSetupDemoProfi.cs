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
        [Ignore("Functional is not implemented")]
        [TestCase("mena", "AE", "fixed")]
        [TestCase("mena", "AE", "mt4m")]
        [TestCase("mena", "AE", "xtrader")]

        public void GetTradingAccountSetupDemoProfi(string authority, string country, string platform)
        {
            #region Test Data
            Dictionary<string, string> expList = new Dictionary<string, string>();
            expList.Add("mena_AE_fixed", System.IO.File.ReadAllText(jsonResponses + "GetTradingAccountSetupDemoProfi.authority=mena.country=AE.platform=fixed.json", Encoding.Default));
            expList.Add("mena_AE_mt4m", System.IO.File.ReadAllText(jsonResponses + "GetTradingAccountSetupDemoProfi.authority=mena.country=AE.platform=mt4m.json", Encoding.Default));
            expList.Add("mena_AE_xtrader", System.IO.File.ReadAllText(jsonResponses + "GetTradingAccountSetupDemoProfi.authority=mena.country=AE.platform=xtrader.json", Encoding.Default));

            JObject expectedResponse = JObject.Parse(expList[authority + "_" + country + "_" + platform]);
            #endregion

            JObject actualResponse;
            APIHelper.GetTradingAccountSetup(BaseUrlApi, "false", "true", authority, country, platform, out actualResponse);

            var resultDif = ObjectDiffPatch.GenerateDiff(expectedResponse, actualResponse);
            if (!resultDif.AreEqual)
                Log.Error(String.Format("\r\nExpected response \r\n {0}\r\n\r\nActual response \r\n{1}\r\n", expectedResponse, actualResponse));
            Assert.IsTrue(resultDif.AreEqual, String.Format("Expected response and Actual response see in log.\nOldValues:\n{0}\nNewValues:\n{1}", resultDif.OldValues, resultDif.NewValues));

        }
    }
}
