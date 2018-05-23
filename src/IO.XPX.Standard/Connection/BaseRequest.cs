using IO.XPX.Standard.Connection;
using IO.XPX.Standard.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace IO.XPX.Standard.Connection
{
    public class RestRequest
    {
        private string BaseURL;
        public RestRequest(string baseUrl)
        {
            this.BaseURL = baseUrl;
        }

        private GenericResponse<T> CreateAPIRequest<T>(string url , string method, QueryParam parameters = null, object body = null, Action<Stream> action = null) where T : class
        {
            try
            {
                WebRequest request = WebRequest.Create(this.BaseURL + url);
                request.ContentType = "application/json";
                request.Method = method;
                request.Timeout = 30;

                WebResponse response = request.GetResponse();

                var status = ((HttpWebResponse)response).StatusDescription;

                Stream dataStream;
                dataStream = response.GetResponseStream();

                StreamReader reader = new StreamReader(dataStream);

                var streamResponse = reader.ReadToEnd();

                reader.Close();
                dataStream.Close();
                response.Close();

                return new GenericResponse<T>() { Result = JsonConvert.DeserializeObject<T>(streamResponse) };
            }
            catch (Exception ex)
            {
                return new GenericResponse<T>() { ErrorMessage = ex.Message };
            }
        }
        public GenericResponse<T> GET<T>(string url) where T : class => CreateAPIRequest<T>(url, "GET");
        public GenericResponse<T> POST<T>(string url) where T : class => CreateAPIRequest<T>(url, "POST");
    }
}
