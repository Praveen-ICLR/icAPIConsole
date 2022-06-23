using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using icAPIConsole.Models.SecurityCoupon;
using icAPIConsole.Core;
using Newtonsoft.Json;

namespace icAPIConsole.APIEndPoints
{
    public class SecurityCouponAPIEndPoints
    {

        public static async Task GetSecurityCoupon()
        {

            using (var client = new HttpClient())
            {

                SecurityCouponGetRequest securityCouponGetRequest = new SecurityCouponGetRequest();

                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                securityCouponGetRequest.symbol = Console.ReadLine();

                Console.WriteLine("Enter the Symbol Number");
                Console.Write("> ");
                String? SYMBOLNUmber = Console.ReadLine();
                securityCouponGetRequest.sym_no= config.ParseNullableInt(SYMBOLNUmber);
               
                Console.WriteLine("Enter the Search String");
                Console.Write("> ");
                securityCouponGetRequest.search = Console.ReadLine();

                //Request Parameter
                HttpResponseMessage response = await client.GetAsync(config.BASEURL() + "/SecurityCoupon?symbol=" + securityCouponGetRequest.symbol +
                    "&sym_no=" + securityCouponGetRequest.sym_no  + "&search=" + securityCouponGetRequest.search);


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

        public static async Task PostSecurityCoupon()
        {
            using (var client = new HttpClient())
            {

                SecurityCouponPostRequest securityCouponPostRequest = new SecurityCouponPostRequest();
                UrlConfiguration config = new UrlConfiguration();


                Console.WriteLine("Enter the Mode");
                Console.Write("> ");
                securityCouponPostRequest.mode = Console.ReadLine();

              

                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                securityCouponPostRequest.symbol = Console.ReadLine();

                Console.WriteLine("Enter the ID");
                Console.Write("> ");
                String? ids = Console.ReadLine();
                securityCouponPostRequest.id = config.ParseNullableInt(ids);

                Console.WriteLine("Enter the System Date");
                Console.Write("> ");
               // securityCouponPostRequest.system_dt = Console.ReadLine();
                  String? SDATES = Console.ReadLine();
                  securityCouponPostRequest.system_dt = config.ParseNullableDateTime(SDATES);

                Console.WriteLine("Enter the Symbol Number");
                Console.Write("> ");
                String? sym_nos = Console.ReadLine();
                securityCouponPostRequest.sym_no = config.ParseNullableInt(sym_nos);

                Console.WriteLine("Enter the Coupon");
                Console.Write("> ");
                String? coupons = Console.ReadLine();
                securityCouponPostRequest.coupon = config.ParseNullableDecimal(coupons);

                Console.WriteLine("Enter the Effective Coupon Date ");
                Console.Write("> ");
                //securityCouponPostRequest.eff_coupon_dt = Console.ReadLine();
                String? EffectiveDATES = Console.ReadLine();
                  securityCouponPostRequest.eff_coupon_dt = config.ParseNullableDateTime(EffectiveDATES);






                var dataAsString = JsonConvert.SerializeObject(securityCouponPostRequest, Formatting.Indented);
               
                var dataContent = new StringContent("["+dataAsString+"]", Encoding.UTF8, "application/json");

                Console.WriteLine(dataAsString);
                
                    HttpResponseMessage response = await client.PostAsync(config.BASEURL() + "/SecurityCoupon", dataContent);

                    if (response.IsSuccessStatusCode)
                    {
                        Uri? ncrUrl = response.Headers.Location;
                        var contents = await response.Content.ReadAsStringAsync();
                        var obj = JsonConvert.DeserializeObject(contents);
                        var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                        Console.WriteLine(JS);
                        Console.WriteLine("Security Profile Loaded");
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
