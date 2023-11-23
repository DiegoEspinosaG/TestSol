using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSol_WinForms.ViewModels
{
    internal class Utilidades
    {
        public static async Task<string> Get(string resource)
        {

            try
            {

                var client = new RestClient("https://localhost:7060/");
                var request = new RestRequest(resource, Method.Get);
                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return response.Content;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al ejecutar el Get");
                return "";
            }

        }

        public static async Task<string> Post(string json, string resource)
        {

            try
            {

                var client = new RestClient("https://localhost:7060/");
                var request = new RestRequest(resource, Method.Post);
                request.AddJsonBody(json);
                request.RequestFormat = RestSharp.DataFormat.Json;
                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.Created)
                {
                    return response.Content;
                }
                else
                {
                    return response.Content;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al ejecutar el Post");
                return "";
            }

        }

        public static async Task<string> Put(string json, string resource)
        {

            try
            {

                var client = new RestClient("https://localhost:7060/");
                var request = new RestRequest(resource, Method.Put);
                //request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
                request.AddJsonBody(json);
                //request.AddParameter("id", id, ParameterType.HttpHeader);
                request.RequestFormat = RestSharp.DataFormat.Json;
                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return response.Content;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al ejecutar el Put");
                return "";
            }

        }

        public static async Task<string> Delete(string resource)
        {

            try
            {

                var client = new RestClient("https://localhost:7060/");
                var request = new RestRequest(resource, Method.Delete);
                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }
                else
                {
                    return response.Content;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al ejecutar el Delete");
                return "";
            }

        }
    }
}
