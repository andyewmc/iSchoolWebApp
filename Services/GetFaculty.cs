using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//these we had to include!
using System.Net.Http;
using System.Net.Http.Headers;
using iSchoolWebApp.Models;
using Newtonsoft.Json;


namespace iSchoolWebApp.Services
{
    public class GetFaculty
    {
        public async Task<List<Faculty>> getAllFaculty()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/api/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("people/faculty", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    //different/new code here...
                    //make json out of data
                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Faculty>>>(data);

                    //now that I have the dictionary of 'faculty':List<Faculty>
                    //first, create a LIst to put it into
                    List<Faculty> facultyList = new List<Faculty>();

                    //iterate through the data in rtnResults
                    foreach (KeyValuePair<string, List<Faculty>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            facultyList.Add(item);
                            //let's go see some data
                            Console.WriteLine(item.username);
                        }
                    }
                    return facultyList;

                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Faculty> facultyList = new List<Faculty>();
                    return facultyList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Faculty> facultyList = new List<Faculty>();
                    return facultyList;
                    //return "Exception"; ;
                }

            }

        }
    }
}
