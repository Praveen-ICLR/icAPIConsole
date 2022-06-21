using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using icAPIConsole.Models.Activity;
using icAPIConsole.Core;
using Newtonsoft.Json;


namespace icAPIConsole.APIEndPoints
{
    public class ActivityAPIEndPoints
    {
        public static async Task GetActivity()
        {

            using (var client = new HttpClient())
            {
          

               ActivityGetRequest activityGetRequest = new ActivityGetRequest();
               UrlConfiguration config = new UrlConfiguration();
               


                Console.WriteLine("Enter the System Date");
                activityGetRequest.system_dt = Console.ReadLine();
                Console.WriteLine("Enter the Crosspondents");
                activityGetRequest.corr = Console.ReadLine();

                //Request Parameter
                HttpResponseMessage response = await client.GetAsync(config.BASEURL()+ "/Activity?system_dt=" + activityGetRequest.system_dt + "&corr=" + activityGetRequest.corr);


                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
               
                 
                  // Console.WriteLine(x);
                    Console.WriteLine("Activity Data fetched");
                }
                else
                {
                    Console.WriteLine("Statuscode is error");
                    Console.WriteLine(response.Content);
                    Console.WriteLine(response);

                }


            }
        }
    }
}
