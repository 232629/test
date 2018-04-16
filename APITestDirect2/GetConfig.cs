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
        [Ignore("Obsolate")]
        public void GetConfig()
        {
            #region Test Data
            string email = "848521@testing.test";
            string pass = "Password1";
            JObject expectedResponse = JObject.Parse(System.IO.File.ReadAllText(@"C:\Users\e.kovalenko\Visual Studio 2017\Projects\UITestDirest2\APITestDirect2\Resources\Json responses\GetConfig.json"));
            #endregion


            string resposeOut;

            //получаем токин пользователя bb@bb.bb
            APIHelper.Login(BaseUrlApi, email, pass, out resposeOut);

            //звапрашиваем GetConfig для пользователя bb@bb.bb
            JObject actualResponse;
            APIHelper.GetConfig(BaseUrlApi, resposeOut, out actualResponse);

            var resultDif = ObjectDiffPatch.GenerateDiff(expectedResponse, actualResponse);
            if (!resultDif.AreEqual)
                Log.Error(String.Format("\r\nExpected response \r\n {0}\r\n\r\nActual response \r\n{1}\r\n", expectedResponse, actualResponse));
            Assert.IsTrue(resultDif.AreEqual, String.Format("Expected response and Actual response see in log.\nOldValues:\n{0}\nNewValues:\n{1}", resultDif.OldValues, resultDif.NewValues));

        }
    }
}
