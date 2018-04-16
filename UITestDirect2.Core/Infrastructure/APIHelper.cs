using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using NUnit.Framework;

namespace UITestDirect2.Core.Infrastructure
{
    static class APIHelper
    {
        public static HttpStatusCode SendRequest(string request, string method, string body, WebHeaderCollection headers, out string responseBody)
        {
            string uri = string.Format("{0}/{1}", ConfigurationManager.AppSettings["serverAddress"], request);

            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, policyErrors) => true;

            // create a request
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.KeepAlive = false;
            webRequest.ProtocolVersion = HttpVersion.Version11;
            webRequest.Method = method;
            if (headers != null)
            {
                webRequest.Headers.Add(headers);
            }

            Log.Info("Actual request uri. \n{0}", uri);

            if (webRequest.Method == "POST")
            {
                Log.Info("Actual request body. \n{0}", body);

                byte[] bodyBytes = Encoding.UTF8.GetBytes(body);

                webRequest.ContentType = "application/json";
                webRequest.ContentLength = bodyBytes.Length;
                Stream requestStream = webRequest.GetRequestStream();

                requestStream.Write(bodyBytes, 0, bodyBytes.Length);
                requestStream.Close();
            }

            try
            {
                using (var response = (HttpWebResponse)webRequest.GetResponse())
                {
                    using (var responseStream = response.GetResponseStream())
                    using (var reader = responseStream != null ? new StreamReader(responseStream) : null)
                    {
                        responseBody = reader != null ? reader.ReadToEnd() : null;
                        Log.Info("Actual response. \n{0}", responseBody);
                    }
                    return response.StatusCode;
                }
            }
            catch (WebException ex)
            {
                if (ex.Response == null)
                {
                    Log.Error("Error while sending API request. Response is null.\n{0}", ex);
                    throw;
                }
                using (var response = (HttpWebResponse)ex.Response)
                {
                    using (var responseStream = response.GetResponseStream())
                    using (var reader = responseStream != null ? new StreamReader(responseStream) : null)
                    {
                        responseBody = reader != null ? reader.ReadToEnd() : null;
                        Log.Info("Actual response. \n{0}", responseBody);
                    }
                    return response.StatusCode;
                }
            }
        }

        public static HttpStatusCode CreateNewUser(string login, string password)
        {
            string request = "api/registration/test/simple";
            string body = string.Format("{{\"email\": \"{0}\",\"password\": \"{1}\"}}", login, password);
            string responseOut;
            var headers = new WebHeaderCollection
            {
                {"Accept-Language", "en - US"}
            };

            var status = SendRequest(request, "POST", body, headers, out responseOut);
            Assert.IsTrue(status == HttpStatusCode.OK, "Create new user is failed. Status = {0}", status);

            return status;
        }

    }
}
