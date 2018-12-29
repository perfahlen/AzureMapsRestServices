using AzureMapsToolkit.Common;
using AzureMapsToolkit.GeoJson;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http.Headers;
using AzureMapsToolkit;

namespace AzureMapsRestToolkit.Common
{
    public class BaseServices
    {
        internal string Key { get; set; }
        public BaseServices(string key)
        {
            Key = key;
        }

        internal async Task<HttpResponseMessage> GetHttpResponseMessage(string url, string data)
        {

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, url))
                {
                    using (var content = new StringContent(data, Encoding.UTF8, "application/json"))
                    {
                        request.Content = content;
                        var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

                        response.EnsureSuccessStatusCode();
                        return response;

                    }
                }
            }
        }

        string _url = string.Empty;
        internal string Url
        {
            get
            {
                return _url.Equals(string.Empty) ?
                 $"?subscription-key={Key}" : _url;
            }
            set
            {
                _url = value;
            }
        }

        internal MultiPoint GetMultipPoint(IEnumerable<Coordinate> coordinates)
        {
            double[,] points = new double[coordinates.Count(), 2];
            for (int i = 0; i < coordinates.Count(); i++)
            {
                points[i, 0] = coordinates.ElementAt(i).Longitude;
                points[i, 1] = coordinates.ElementAt(i).Latitude;
            }

            var multiPoint = new MultiPoint();
            multiPoint.Coordinates = points;

            return multiPoint;

        }

        internal IEnumerable<string> GetSearchQuery<T>(IEnumerable<T> req) where T : RequestBase
        {
            foreach (var reqItem in req)
            {
                var query = GetQuery(reqItem, false, false, '?');
                yield return query;
            }
        }

        internal string GetQuery<T>(T request, bool includeApiVersion, bool includeLanguage = true, char firstChar = '&')
            where T : RequestBase
        {
            Type type = request.GetType();

            var properties = type.GetProperties();

            var arguments = string.Empty;

            foreach (var propertyInfo in properties)
            {
                if (propertyInfo.
                    GetValue(request) != null)
                {
                    var argumentName = string.Empty;
                    var argumentValue = string.Empty;

                    var underLayingtype = Nullable.GetUnderlyingType(propertyInfo.PropertyType);

                    if (underLayingtype != null && underLayingtype.IsEnum)
                    {
                        argumentName = Char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);
                        argumentValue = (propertyInfo.GetValue(request).GetType().GetMember(propertyInfo.GetValue(request).ToString())?.FirstOrDefault().GetCustomAttributes(typeof(NameArgument), false).FirstOrDefault() as NameArgument).Name;
                    }
                    else
                    {

                        var attribute = propertyInfo.GetCustomAttributes(typeof(NameArgument), false);
                        if (attribute.Length > 0)
                            argumentName = ((NameArgument)attribute[0]).Name;

                        if (argumentName == string.Empty)
                            argumentName = Char.ToLower(propertyInfo.Name[0]) + propertyInfo.Name.Substring(1);


                        if (string.IsNullOrEmpty(argumentValue))
                            argumentValue = propertyInfo.GetValue(request).ToString();
                    }

                    arguments += $"{firstChar}{argumentName}={argumentValue}";
                    firstChar = '&';
                }
            }
            return arguments;
        }




        internal async Task<byte[]> GetByteArray(string baseAddress, string url)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseAddress);
                var content = await httpClient.GetByteArrayAsync(url);
                return content;
            }
        }

        internal async Task<Response<T>> ExecuteRequest<T, U>(string baseUrl, U req) where U : RequestBase
        {
            try
            {
                Url += GetQuery<U>(req, true);

                using (var client = GetClient(baseUrl))
                {
                    var data = await GetData<T>(client, Url);
                    var response = GetResponse<T>(data);
                    return response;
                }
            }
            catch (Exception ex)
            {
                return Response<T>.CreateErrorResponse(ex);
            }
        }

        HttpClient GetClient(string baseAddress)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        Response<T> GetResponse<T>(T t)
        {
            var res = new Response<T>
            {
                Result = t
            };
            return res;
        }

        async Task<T> GetData<T>(HttpClient client, string url)
        {
            var json = await client.GetStringAsync(url);
            var val = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
            return val;
        }

    }
}
