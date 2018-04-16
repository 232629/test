using System;
using System.IO;
using NUnit.Framework;
namespace APITestDirect2
{
    [TestFixture]
    public partial class APITestDirect2
    {

        //private readonly string BaseUrlApi = "http://direct.local.fxpro.com/";
        //private readonly string BaseUrlApi = "http://localhost:56596/";
        private readonly string BaseUrlApi = "https://adminapi-int.fxpro.com/";
        //private readonly string jsonResponses = new FileInfo(AppDomain.CurrentDomain.BaseDirectory).Directory.Parent.FullName + @"\Resources\Json responses\";
        private readonly string jsonResponses = AppDomain.CurrentDomain.BaseDirectory + @"\Resources\Json responses\";



    }
}
