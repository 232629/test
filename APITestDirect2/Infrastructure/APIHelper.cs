using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APITestDirect2.Infrastructure
{
    class APIHelper
    {

        public static HttpStatusCode SendRequest(string baseServiceUrl, string request, string method, string body, WebHeaderCollection headers, out string responseBody)
        {
            string uri = string.Format("{0}{1}", baseServiceUrl, request);

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

        /// <summary>
        /// It deletes the file selected in JSon field 
        /// </summary>
        /// <param name="token">JObject</param>
        /// <param name="fields">Name deleted fields</param>

        public static void RemoveFields(JToken token, List<string> fields)
        {
            JContainer container = token as JContainer;
            if (container == null) return;

            List<JToken> removeList = new List<JToken>();
            foreach (JToken el in container.Children())
            {
                JProperty p = el as JProperty;
                if (p != null && fields.Contains(p.Name))
                    removeList.Add(el);
                RemoveFields(el, fields);
            }

            foreach (JToken el in removeList)
                el.Remove();
        }

        ///// <summary>
        ///// GET 
        ///// </summary>
        ///// 
        //public static HttpStatusCode GetGlobal(string baseServiceUrl, string lang, out JObject response)
        //{
        //    string responseBody;
        //    string request = string.Format("api/Localization/GetGlobal?lang={0}", lang);
        //    HttpStatusCode status = SendRequest(baseServiceUrl, request, "GET", null, null, out responseBody);
        //    response = ParseInJObject(responseBody);

        //    return status;
        //}

        //public static HttpStatusCode GetCountries(string baseServiceUrl, out JObject response)
        //{
        //    string responseBody;
        //    string request = string.Format("api/registration/getcountries");
        //    HttpStatusCode status = SendRequest(baseServiceUrl, request, "GET", null, null, out responseBody);
        //    response = ParseInJObject(responseBody);

        //    return status;
        //}

        //public static HttpStatusCode GetComponentName(string baseServiceUrl, string name, out JObject response)
        //{
        //    string responseBody;
        //    string request = string.Format("api/Localization/GetLocal?componentName={0}&lang=en", name);
        //    HttpStatusCode status = SendRequest(baseServiceUrl, request, "GET", null, null, out responseBody);
        //    response = ParseInJObject(responseBody);

        //    return status;
        //}


        /// <summary>
        /// POST
        /// </summary>

        public static HttpStatusCode Login(string baseServiceUrl, string email, string pass, out string responseOut)    //out string responseOut сделать как в GET
        {
            string request = string.Format("api/profile/login");
            string body = string.Format("{{email: \"{0}\", password: \"{1}\"}}", email, pass);
            var headers = new WebHeaderCollection
            {
                {"Accept-Language", "en - US"}
            };

            var status = SendRequest(baseServiceUrl, request, "POST", body, headers, out responseOut);

            return status;
        }

        public static HttpStatusCode Email(string baseServiceUrl, string body, out string responseOut)
        {
            string request = string.Format("api/forgotPassword/sendEmail");

            var headers = new WebHeaderCollection
            {
                {"Accept-Language", "en - US"}
            };

            var status = SendRequest(baseServiceUrl, request, "POST", body, headers, out responseOut);

            return status;
        }

        /// <summary>
        /// Длбавляем корневой объект data и парсим текстовый ответ в обект JObject.
        /// Ко всем expected должен быть добавлен корневой объект data
        /// </summary>
        /// <param name="response">ответ JSON текстом</param>
        /// <returns></returns>
        protected static JObject ParseInJObject(string response)
        {
            response = response.Trim(new char[] { '[', ']' });
            return JObject.Parse("{\"data\": [" + response + "]}");
        }

        public static HttpStatusCode GetConfig(string baseServiceUrl, string tokin, out JObject response)
        {
            string request = string.Format("api/registration/GetConfig");
            string responseBody;
            var headers = new WebHeaderCollection
            {
                {"Authorization", "Bearer " + tokin.Trim('"')}
            };

            var status = SendRequest(baseServiceUrl, request, "GET", null, headers, out responseBody);
            //response = ParseInJObject(responseBody);
            response = JObject.Parse(responseBody);

            return status;
        }

        public static HttpStatusCode GetRegistrationJurisdictions(string baseServiceUrl, out JObject response)
        {
            string request = string.Format("api/Middleware/GetRegistrationJurisdictions");
            string responseBody;
            var headers = new WebHeaderCollection{};

            var status = SendRequest(baseServiceUrl, request, "GET", null, headers, out responseBody);
            response = ParseInJObject(responseBody);


            return status;
        }

        public static HttpStatusCode GetCurrency(string baseServiceUrl, string currency, string authority,  out JObject response)
        {
            string request = string.Format("api/Middleware/getcurrency?currency={0}&authority={1}", currency, authority);
            string responseBody;
            var headers = new WebHeaderCollection { };

            var status = SendRequest(baseServiceUrl, request, "GET", null, headers, out responseBody);
            response = ParseInJObject(responseBody);

            return status;
        }

        public static HttpStatusCode GetCurrencies(string baseServiceUrl, string vault, out JObject response)
        {
            string request = string.Format("api/Middleware/GetCurrencies?vault={0}", vault);
            string responseBody;
            var headers = new WebHeaderCollection { };

            var status = SendRequest(baseServiceUrl, request, "GET", null, headers, out responseBody);
            response = ParseInJObject(responseBody);

            return status;
        }

        public static HttpStatusCode GetRegistrationFields(string baseServiceUrl, string authority, string country, out JObject response)
        {
            string request = string.Format("api/Middleware/GetRegistrationFields?authority={0}&country={1}", authority, country);
            string responseBody;
            var headers = new WebHeaderCollection { };

            var status = SendRequest(baseServiceUrl, request, "GET", null, headers, out responseBody);
            response = ParseInJObject(responseBody);

            return status;
        }

        public static HttpStatusCode GetTradingAccountSetup(string baseServiceUrl, string isReal, string isProfessional, string authority, string country, string platform, out JObject response)
        {
            string request = string.Format("api/Middleware/GetTradingAccountSetup?isReal={0}&isProfessional={1}&authority={2}&country={3}&platform={4}", isReal, isProfessional, authority, country, platform);
            string responseBody;
            var headers = new WebHeaderCollection { };

            var status = SendRequest(baseServiceUrl, request, "GET", null, headers, out responseBody);
            response = ParseInJObject(responseBody);

            return status;
        }

        public static HttpStatusCode GetPaymentMethods(string baseServiceUrl, string authority, string country, out JObject response)
        {
            string request = string.Format("api/Middleware/GetPaymentMethods?authority={0}&country={1}&sandbox=true", authority, country);
            string responseBody;
            var headers = new WebHeaderCollection { };

            var status = SendRequest(baseServiceUrl, request, "GET", null, headers, out responseBody);
            response = ParseInJObject(responseBody);

            return status;
        }

        public static HttpStatusCode GetExchangeRates(string baseServiceUrl, string fromCurrency, string toCurrency, out string response)
        {
            string request = string.Format("api/Middleware/getExchangeRates?fromCurrency={0}&toCurrency={1}", fromCurrency, toCurrency);
            var headers = new WebHeaderCollection { };

            var status = SendRequest(baseServiceUrl, request, "GET", null, headers, out response);

            return status;
        }

        public static HttpStatusCode GetPlatformTradingAccountTypes(string baseServiceUrl, out JObject response)
        {
            string request = string.Format("api/Middleware/GetPlatformTradingAccountTypes");
            string responseBody;
            var headers = new WebHeaderCollection { };

            var status = SendRequest(baseServiceUrl, request, "GET", null, headers, out responseBody);
            response = ParseInJObject(responseBody);

            return status;
        }

    }
}
