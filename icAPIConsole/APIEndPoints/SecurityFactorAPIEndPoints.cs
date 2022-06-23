using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using icAPIConsole.Models.SecurityFactor;
using icAPIConsole.Core;
using Newtonsoft.Json;

namespace icAPIConsole.APIEndPoints
{
    public class SecurityFactorAPIEndPoints
    {

        public static async Task GetSecurityPrincipleFactor()
        {

            using (var client = new HttpClient())
            {

                SecurityFactorGetRequest securityFactorGetRequest = new SecurityFactorGetRequest();  

                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                securityFactorGetRequest.symbol = Console.ReadLine();

                Console.WriteLine("Enter the Symbol Number");
                Console.Write("> ");
                String? SYMBOLNUmber = Console.ReadLine();
                securityFactorGetRequest.sym_no = config.ParseNullableInt(SYMBOLNUmber);

                Console.WriteLine("Enter the Factor Date");
                Console.Write("> ");
                securityFactorGetRequest.factor_dt = Console.ReadLine();

                Console.WriteLine("Enter the Search String");
                Console.Write("> ");
                securityFactorGetRequest.search = Console.ReadLine();

                //Request Parameter
                HttpResponseMessage response = await client.GetAsync(config.BASEURL() + "/SecurityFactor?symbol=" + securityFactorGetRequest.symbol +
                    "&sym_no=" + securityFactorGetRequest.sym_no + "&factor_dt=" + securityFactorGetRequest.factor_dt + "&search=" + securityFactorGetRequest.search);


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

        public static async Task PostSecurityFactor()
        {
            using (var client = new HttpClient())
            {

                SecurityFactorPostRequest securityFactorPostRequest = new SecurityFactorPostRequest();
                UrlConfiguration config = new UrlConfiguration();


                Console.WriteLine("Enter the Mode");
                Console.Write("> ");
                securityFactorPostRequest.mode = Console.ReadLine();



                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                securityFactorPostRequest.symbol = Console.ReadLine();

                Console.WriteLine("Enter the ID");
                Console.Write("> ");
                String? ids = Console.ReadLine();
                securityFactorPostRequest.id = config.ParseNullableInt(ids);

                Console.WriteLine("Enter the System Date");
                Console.Write("> ");
                securityFactorPostRequest.system_dt = Console.ReadLine();

                Console.WriteLine("Enter the Symbol Number");
                Console.Write("> ");
                String? sym_nos = Console.ReadLine();
                securityFactorPostRequest.sym_no = config.ParseNullableInt(sym_nos);

                Console.WriteLine("Enter the Factor");
                Console.Write("> ");
                String? coupons = Console.ReadLine();
                securityFactorPostRequest.factor = config.ParseNullableDecimal(coupons);

                Console.WriteLine("Enter the Factor Date");
                Console.Write("> ");
                securityFactorPostRequest.factor_dt = Console.ReadLine();







                var dataAsString = JsonConvert.SerializeObject(securityFactorPostRequest);
                var dataContent = new StringContent("[" + dataAsString + "]", Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(config.BASEURL() + "/SecurityFactor", dataContent);

                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
                    Console.WriteLine("Security Factor Loaded");
                }
                else
                {
                    Console.WriteLine("Statuscode is error");
                    Console.WriteLine(response.Content);


                }




            }
        }
    }
}
