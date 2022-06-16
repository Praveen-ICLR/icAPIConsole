using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using icAPIConsole.Models.SecurityProfile;
using icAPIConsole.Core;

namespace icAPIConsole.APIEndPoints
{
    public class SecurityProfileAPIEndPoints
    {
        public static async Task GetSecurityProfile()
        {

            using (var client = new HttpClient())
            {
          
                SecurityProfileGetRequest SecProfileGetRequest = new SecurityProfileGetRequest();
                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                SecProfileGetRequest.symbol = Console.ReadLine();
                Console.WriteLine("Enter the Section Number");
                Console.Write("> ");
                SecProfileGetRequest.sec_no = Console.ReadLine();
                Console.WriteLine("Enter the Issuer Cataloger");
                Console.Write("> ");
                SecProfileGetRequest.issuer_catg = Console.ReadLine();
                Console.WriteLine("Enter the Asset Type");
                Console.Write("> ");
                SecProfileGetRequest.asset_type = Console.ReadLine();
                Console.WriteLine("Enter the Section Type");
                Console.Write("> ");
                SecProfileGetRequest.sec_type = Console.ReadLine();
                Console.WriteLine("Enter the Sub Section Type");
                Console.Write("> ");
                SecProfileGetRequest.sec_sub_type = Console.ReadLine();
                Console.WriteLine("Enter the Search String");
                Console.Write("> ");
                SecProfileGetRequest.search = Console.ReadLine();

                //Request Parameter
                HttpResponseMessage response = await client.GetAsync(config.BASEURL() + "/SecurityProfile?symbol=" + SecProfileGetRequest.symbol +
                    "&sec_no=" + SecProfileGetRequest.sec_no + "&issuer_catg=" + SecProfileGetRequest.issuer_catg + "&asset_type=" + SecProfileGetRequest.asset_type +
                    "&sec_type=" + SecProfileGetRequest.sec_type + "&sec_sub_type=" + SecProfileGetRequest.sec_sub_type + "&search=" + SecProfileGetRequest.search);


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
    }
}
