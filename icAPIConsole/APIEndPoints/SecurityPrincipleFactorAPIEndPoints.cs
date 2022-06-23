using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using icAPIConsole.Models.SecurityPrincipleFactor;
using icAPIConsole.Core;
using Newtonsoft.Json;

namespace icAPIConsole.APIEndPoints
{
    public class SecurityPrincipleFactorAPIEndPoints
    {
        public static async Task GetSecurityPrincipleFactor()
        {

            using (var client = new HttpClient())
            {

                SecurityPrincipleFactorGetRequest securityPrincipleFactorGetRequest = new SecurityPrincipleFactorGetRequest();

                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                securityPrincipleFactorGetRequest.symbol = Console.ReadLine();

                Console.WriteLine("Enter the Symbol Number");
                Console.Write("> ");
                String? SYMBOLNUmber = Console.ReadLine();
                securityPrincipleFactorGetRequest.sym_no = config.ParseNullableInt(SYMBOLNUmber);

                Console.WriteLine("Enter the Search String");
                Console.Write("> ");
                securityPrincipleFactorGetRequest.search = Console.ReadLine();

                //Request Parameter
                HttpResponseMessage response = await client.GetAsync(config.BASEURL() + "/SecurityPrincipalFactor?symbol=" + securityPrincipleFactorGetRequest.symbol +
                    "&sym_no=" + securityPrincipleFactorGetRequest.sym_no + "&search=" + securityPrincipleFactorGetRequest.search);


                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
                    Console.WriteLine("Security Coupon Data is fetched....");
                }
                else
                {
                    Console.WriteLine("Statuscode is error");
                    Console.WriteLine(response.Content);
                    Console.WriteLine(response);

                }


            }
        }

        public static async Task PostSecurityPrincipleFactor()
        {
            using (var client = new HttpClient())
            {

                SecurityPrincipleFactorPostRequest securityPrincipleFactorPostRequest = new SecurityPrincipleFactorPostRequest();
                UrlConfiguration config = new UrlConfiguration();


                Console.WriteLine("Enter the Mode");
                Console.Write("> ");
                securityPrincipleFactorPostRequest.mode = Console.ReadLine();



                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                securityPrincipleFactorPostRequest.symbol = Console.ReadLine();

                Console.WriteLine("Enter the ID");
                Console.Write("> ");
                String? ids = Console.ReadLine();
                securityPrincipleFactorPostRequest.id = config.ParseNullableInt(ids);

                Console.WriteLine("Enter the System Date");
                Console.Write("> ");
                securityPrincipleFactorPostRequest.system_dt = Console.ReadLine();

                Console.WriteLine("Enter the Symbol Number");
                Console.Write("> ");
                String? sym_nos = Console.ReadLine();
                securityPrincipleFactorPostRequest.sym_no = config.ParseNullableInt(sym_nos);

                Console.WriteLine("Enter the Factor");
                Console.Write("> ");
                String? coupons = Console.ReadLine();
                securityPrincipleFactorPostRequest.factor = config.ParseNullableDecimal(coupons);

                Console.WriteLine("Enter the Factor Date");
                Console.Write("> ");
                securityPrincipleFactorPostRequest.factor_dt = Console.ReadLine();







                var dataAsString = JsonConvert.SerializeObject(securityPrincipleFactorPostRequest);
                var dataContent = new StringContent("[" + dataAsString + "]", Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(config.BASEURL() + "/SecurityPrincipalFactor", dataContent);

                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
                    Console.WriteLine("Security Principle Factor Loaded");
                }
                else
                {
                    var contents = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);



                }




            }
        }
    }
}
