using IO.XPX.Standard.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace IO.XPX.Standard.Facades
{
    public static class BaseRequest
    {
        private static GenericResponse<T> CreateAPIRequest<T>(string url , string method) where T : class
        {
            try
            {
                Stream dataStream;
                WebRequest request = WebRequest.Create(url);
                request.ContentType = "application/json";
                request.Method = "GET";

                WebResponse response = request.GetResponse();

                var status = ((HttpWebResponse)response).StatusDescription;

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

        public static GenericResponse<T> GET<T>(string url) where T : class => CreateAPIRequest<T>(url, "GET");
        public static GenericResponse<T> POST<T>(string url) where T : class => CreateAPIRequest<T>(url, "POST");
    }
}
