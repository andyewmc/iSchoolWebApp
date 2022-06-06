using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using iSchoolWebApp.Models;
using Newtonsoft.Json;

namespace iSchoolWebApp.Services
{
    public class Undergrad
    {
        public async Task<List<Undergraduate>> getUndergrad()
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
                        "degrees/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    //turn it into JSON and cast into 
                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Undergraduate>>> (data);
                    List<Undergraduate> undergradList = new List<Undergraduate>();

                    foreach (KeyValuePair<string, List<Undergraduate>> kvp in rtnResults) {
                        foreach (var item in kvp.Value)
                        {
                            undergradList.Add(item);
                        }
                    }
                    return undergradList;


                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    Undergraduate undergraduate = new Undergraduate();
                    return null;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    Undergraduate undergraduate = new Undergraduate();
                    return null;
                }


            }

        }


    }


}
