using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using iSchoolWebApp.Models;
using Newtonsoft.Json;

namespace iSchoolWebApp.Services
{
    public class GetCourses
    {
        public async Task<List<Course>> getCourses()
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
                        "course/", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    //turn it into JSON and cast into <About>
                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Course>>>(data);

                    List<Course> courseList = new List<Course>();

                    foreach (KeyValuePair<string, List<Course>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            courseList.Add(item);
                            //let's go see some data
                            Console.WriteLine(item);
                        }
                    }
                    return courseList;

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
