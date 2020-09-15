using System;
using System.Collections.Generic;
using RestSharp;
using System.Text.Json;
using System.IO;

namespace Library
{
    public class CallAPI
    {
        //Get List
        public static List<T> GetListContent<C, T>(params string[] parms)
            where C : class
            where T : class
        {
            string str = CreateGetRequest(SetUpURL<C>(parms));
            var x = JsonSerializer.Deserialize<List<T>>(str, Options);
            return x;
        }

        //Get Object
        public static T GetObjectContent<C, T>(params string[] parms)
            where C : class
        {
            try
            {
                string str = CreateGetRequest(SetUpURL<C>(parms));
                var x = JsonSerializer.Deserialize<T>(str , Options);
                return x;
            }
            catch
            {
                throw;
            }
            
        }

        //Post And Get Object
        public static T PostObjectAndGetObject<C,T>(object obj , params string[] parms)
        {
            try
            {
                string str = CreatePostRequest(SetUpURL<C>(parms), obj);
                var x = JsonSerializer.Deserialize<T>(str , Options);
                return x;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        //Post And Get bool
        public static bool PostObjectAndGetBool<C, T>(object obj, params string[] parms)
        {
            try
            {
                string str = CreatePostRequest(SetUpURL<C>(parms), obj);
                var x = JsonSerializer.Deserialize<bool>(str , Options);
                return x;
            }
            catch(Exception ex)
            {
                throw;
            }
        }


        static string CreateGetRequest(string url)
        {
            try
            {
                RestClient restClient = new RestClient("https://localhost:44396/api/");
                RestRequest restRequest = new RestRequest(url, Method.GET, DataFormat.Json);
                IRestResponse restResponse = restClient.Execute(restRequest);
                return restResponse.Content;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        static string CreatePostRequest(string url, object obj)
        {
            try
            {
                RestClient restClient = new RestClient("https://localhost:44396/api/");
                RestRequest restRequest = new RestRequest(url, Method.POST, DataFormat.Json);
                restRequest.AddJsonBody(obj);
                IRestResponse restResponse = restClient.Execute(restRequest);
                return restResponse.Content;
            }
            catch
            {
                throw;
            }
        }
        static string CreateVideoRequest(string url, object obj,string videoPath)
        {
            try
            {
                RestClient restClient = new RestClient("https://localhost:44396/api/");
                RestRequest restRequest = new RestRequest(url, Method.POST, DataFormat.Json);
                restRequest.AddJsonBody(obj);
                restRequest.AddFile("VideoFile", File.ReadAllBytes(videoPath), Path.GetFileName(videoPath), "application/octet-stream");
                IRestResponse restResponse = restClient.Execute(restRequest);
                return restResponse.Content;
            }
            catch
            {
                throw;
            }
        }

        public static string UploadVideo(string url)
        {
            RestClient restClient = new RestClient("https://localhost:44396/api/");
            RestRequest request = new RestRequest(url, Method.POST);
            request.AddFile("VideoFile", File.ReadAllBytes(@"C:\Users\HP\Desktop\alaa.png"), Path.GetFileName(@"C:\Users\HP\Desktop\alaa.png"), "application/octet-stream");
           // request.AddParameter("application /png", File.ReadAllBytes(@"C:\Users\HP\Desktop\alaa.png"), ParameterType.RequestBody);

            var response = restClient.Execute(request);

            return "";
        }
        static string SetUpURL<T>(params string [] parms)
        {
            string name = typeof(T).Name;
            if (name[name.Length - 1] == 'Y' || name[name.Length - 1] == 'y')
            {
                name.Remove(name.Length - 1, 1);
                name += "ie";
            }
            name += "s";
            string url =  name;
            foreach (var item in parms)
            {
                url += "/" + item;
            }
            return url;
        }

        public static JsonSerializerOptions Options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

    }
}