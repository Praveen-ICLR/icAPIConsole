using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using icAPIConsole.Models.EOD;
using icAPIConsole.Core;

namespace icAPIConsole.APIEndPoints
{
    public class EODAPIEndPoints
    {
       
        //EOD Cash Get Request
        public static async Task EODCashGetRequest()
        {
            using(var client = new HttpClient())
            {
                EODGetRequest eODGetRequest = new EODGetRequest();
                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the System Date");
                Console.Write("> ");
                eODGetRequest.system_dt = Console.ReadLine();
                Console.WriteLine("Enter the Crosspondent");
                Console.Write("> ");
                eODGetRequest.corr = Console.ReadLine();
                Console.WriteLine("Enter the Subflag");
                Console.Write("> ");
                eODGetRequest.sub_flag = Console.ReadLine();
                Console.WriteLine("Enter the Search String");
                Console.Write("> ");
                eODGetRequest.search = Console.ReadLine();

               

                //Request Parameter
                HttpResponseMessage response = await client.GetAsync(config.BASEURL() + "/EOD/Cash?system_dt=" +
                    eODGetRequest.system_dt + "&corr=" + eODGetRequest.corr + "&sub_flag=" + eODGetRequest.sub_flag + "&search=" + eODGetRequest.search);


                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(contents);
                    Console.WriteLine("EOD Data fetched");
                }
                else
                {
                    Console.WriteLine("Statuscode is error");
                    Console.WriteLine(response.Content);
                    Console.WriteLine(response);

                }



            }
        }

        public static async Task EODPositionGetRequest()
        {
            using (var client = new HttpClient())
            {
                EODGetRequest eODGetRequest = new EODGetRequest();
                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the System Date");
                Console.Write("> ");
                eODGetRequest.system_dt = Console.ReadLine();
                Console.WriteLine("Enter the Crosspondent");
                Console.Write("> ");
                eODGetRequest.corr = Console.ReadLine();
                Console.WriteLine("Enter the Subflag");
                Console.Write("> ");
                eODGetRequest.sub_flag = Console.ReadLine();
                Console.WriteLine("Enter the Search String");
                Console.Write("> ");
                eODGetRequest.search = Console.ReadLine();



                //Request Parameter
                HttpResponseMessage response = await client.GetAsync(config.BASEURL() + "/EOD/Position?system_dt=" +
                    eODGetRequest.system_dt + "&corr=" + eODGetRequest.corr + "&sub_flag=" + eODGetRequest.sub_flag + "&search=" + eODGetRequest.search);


                if (response.IsSuccessStatusCode)
                {
                    Uri ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(contents);
                    Console.WriteLine("EOD Data fetched");
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
