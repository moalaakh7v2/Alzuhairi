using System;
using System.Collections.Generic;
using RestSharp;
using System.Text.Json;
using System.IO;

namespace Library
{
    public class CallAPI
    {
        public static string URL = "http://moalaa7test.somee.com/api/";
        //Get List
        public static List<T> GetListContent<C, T>(params string[] parms)
            where C : class
            where T : class
        {
            try
            {
                string str = CreateGetRequest(SetUpURL<C>(parms));
                var x = JsonSerializer.Deserialize<List<T>>(str, Options);
                return x;
            }
            catch (Exception ex)
            {
                Problem problem = JsonSerializer.Deserialize<Problem>(ex.Message, Options);
                throw new Exception(problem.detail);
            }

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
            catch(Exception ex)
            {
                Problem problem = JsonSerializer.Deserialize<Problem>(ex.Message, Options);
                throw new Exception(problem.detail);
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
            catch (Exception ex)
            {
                Problem problem = JsonSerializer.Deserialize<Problem>(ex.Message, Options);
                throw new Exception(problem.detail);
            }
        }
        public static T PostFile<C, T>(string FilePath, params string[] parms)
        {
            try
            {
                string str = UploadFile(SetUpURL<C>(parms), FilePath);
                var x = JsonSerializer.Deserialize<T>(str, Options);
                return x;
            }
            catch (Exception ex)
            {
                Problem problem = JsonSerializer.Deserialize<Problem>(ex.Message, Options);
                throw new Exception(problem.detail);

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
            catch (Exception ex)
            {
                Problem problem = JsonSerializer.Deserialize<Problem>(ex.Message, Options);
                throw new Exception(problem.detail);
            }
        }


        static string CreateGetRequest(string url)
        {
            RestClient restClient = new RestClient(URL);
            RestRequest restRequest = new RestRequest(url, Method.GET, DataFormat.Json);
            IRestResponse restResponse = restClient.Execute(restRequest);
            if (restResponse.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new Exception(restResponse.Content);
            }
            else
                return restResponse.Content;
        }
        static string CreatePostRequest(string url, object obj)
        {
            RestClient restClient = new RestClient(URL);
            RestRequest restRequest = new RestRequest(url, Method.POST, DataFormat.Json);
            restRequest.AddJsonBody(obj);
            IRestResponse restResponse = restClient.Execute(restRequest);
            if (restResponse.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new Exception(restResponse.Content);
            }
            else
                return restResponse.Content;
        }

        public static string UploadFile(string url, string videoPath)
        {
            RestClient restClient = new RestClient(URL);
            RestRequest request = new RestRequest(url, Method.POST, DataFormat.Json);
            request.AddFile("FileByte", File.ReadAllBytes(videoPath), Path.GetFileName(videoPath), "application/octet-stream");
            IRestResponse response = restClient.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new Exception(response.Content);
            }
            else
                return response.Content;
        }



        static string SetUpURL<T>(params string [] parms)
        {
            string name = typeof(T).Name;
            if (name == "ResellerAndNoteBook")
                name = "Reseller";
            else if (name[name.Length - 1] == 'Y' || name[name.Length - 1] == 'y')
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
        public class Problem
        {
            public string detail { get; set; }
            public string instance { get; set; }
            public int? statusCode { get; set; }
            public string title { get; set; }
            public string type { get; set; }
        }
    }
}