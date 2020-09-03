using System;
using System.Collections.Generic;
using System.Text;
using RestSharp.Authenticators;
using System.Linq;
using Models.Enums;
using Newtonsoft.Json;
using RestSharp;

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
            var x = JsonConvert.DeserializeObject<List<T>>(str);
            return x;
        }

        //Get Object
        public static T GetObjectContent<C, T>(params string[] parms)
            where C : class
        {
            try
            {
                string str = CreateGetRequest(SetUpURL<C>(parms));
                var x = JsonConvert.DeserializeObject<T>(str);
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
                var x = JsonConvert.DeserializeObject<T>(str);
                return x;
            }
            catch
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
                var x = JsonConvert.DeserializeObject<bool>(str);
                return x;
            }
            catch
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
        
    }
}