using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        public void GetPlatformTradingAccountTypes()
        {
            #region Test Data
            JObject expectedResponse = JObject.Parse(System.IO.File.ReadAllText(jsonResponses + "GetPlatformTradingAccountTypes.json", Encoding.Default));
            #endregion

            JObject actualResponse;
            APIHelper.GetPlatformTradingAccountTypes(BaseUrlApi, out actualResponse);

            var resultDif = ObjectDiffPatch.GenerateDiff(expectedResponse, actualResponse);
            if (!resultDif.AreEqual)
                Log.Error(String.Format("\r\nExpected response \r\n {0}\r\n\r\nActual response \r\n{1}\r\n", expectedResponse, actualResponse));
            Assert.IsTrue(resultDif.AreEqual, String.Format("Expected response and Actual response see in log.\nOldValues:\n{0}\nNewValues:\n{1}", resultDif.OldValues, resultDif.NewValues));

        }
    }
}
