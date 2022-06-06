using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using iSchoolWebApp.Models;
using Newtonsoft.Json;

namespace iSchoolWebApp.Services
{
    public class GetEmployment
    {
        public GetEmployment()
        { //make a method to get each of the things indiidually 
        }

        //build top of site first
        public async Task<Introduction> GetIntro()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync(
                        "employment/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    //turn it into JSON and cast into <About>
                    var rtnResults = JsonConvert.DeserializeObject<Introduction>(data);
                    //don't need - it is already an About object...
                    //since there is only one About
                    //About abt = new About();
                    //abt = rtnResults;
                    
                    return rtnResults;

                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    Console.Write(msg);
                    return null;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    Console.Write(msg);
                    return null;
                }


            }
        }


        public async Task<DegreeStatistics> GetDegreeStats()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync(
                        "employment/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    //turn it into JSON and cast into <About>
                    var rtnResults = JsonConvert.DeserializeObject<DegreeStatistics>(data);
                    //don't need - it is already an About object...
                    //since there is only one About
                    //About abt = new About();
                    //abt = rtnResults;

                    return rtnResults;

                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    Console.Write(msg);
                    return null;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    Console.Write(msg);
                    return null;
                }


            }
        }

        public async Task<Employers> GetEmployers()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync(
                        "employment/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    //turn it into JSON and cast into <About>
                    var rtnResults = JsonConvert.DeserializeObject<Employers>(data);
                    //don't need - it is already an About object...
                    //since there is only one About
                    //About abt = new About();
                    //abt = rtnResults;

                    return rtnResults;

                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    Console.Write(msg);
                    return null;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    Console.Write(msg);
                    return null;
                }


            }
        }

        public async Task<CoopTable> GetCoop()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = new HttpResponseMessage();
                    response = await client.GetAsync(
                        "employment/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    //turn it into JSON and cast into <About>
                    var rtnResults = JsonConvert.DeserializeObject<CoopTable>(data);
                    //don't need - it is already an About object...
                    //since there is only one About
                    //About abt = new About();
                    //abt = rtnResults;

                    return rtnResults;

                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    Console.Write(msg);
                    return null;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    Console.Write(msg);
                    return null;
                }


            }
        }
    }
}
