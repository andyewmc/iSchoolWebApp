using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

using iSchoolWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iSchoolWebApp.Services
{
    public class GetMinors
    {
        public async Task<List<UgMinor>> getMinors()
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
                        "minors/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    
                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<UgMinor>>>(data);

                    List<UgMinor> minors = new List<UgMinor>();

                    foreach (KeyValuePair<string, List<UgMinor>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            minors.Add(item);
                            //let's go see some data
                            Console.WriteLine(item);
                        }
                    }

                    return minors;

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
