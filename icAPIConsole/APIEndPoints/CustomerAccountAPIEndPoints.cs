using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using icAPIConsole.Core;
using icAPIConsole.Models.CustomerAccount;

namespace icAPIConsole.APIEndPoints
{
    public class CustomerAccountAPIEndPoints
    {
        public static async Task GetCustomerAccounts()
        {

            using (var client = new HttpClient())
            {
               

                CustomerAccountGetRequest CAGetRequest = new CustomerAccountGetRequest();
                UrlConfiguration config = new UrlConfiguration();


                Console.WriteLine("Enter the Correspondent");
                Console.Write("> ");
                CAGetRequest.corr = Console.ReadLine();
                Console.WriteLine("Enter the office");
                Console.Write("> ");
                CAGetRequest.office = Console.ReadLine();
                Console.WriteLine("Enter the Account Number");
                Console.Write("> ");
                CAGetRequest.acct_no = Console.ReadLine();
                Console.WriteLine("Enter the Sub Account Number");
                Console.Write("> ");
                CAGetRequest.sub_acct_no = Console.ReadLine();
                Console.WriteLine("Enter the Name");
                Console.Write("> ");
                CAGetRequest.name = Console.ReadLine();
                Console.WriteLine("Enter the Social Security Number");
                Console.Write("> ");
                CAGetRequest.ssn = Console.ReadLine();
                Console.WriteLine("Enter the Designated list");
                Console.Write("> ");
                CAGetRequest.desig_list = Console.ReadLine();
                Console.WriteLine("Enter the access group code");
                Console.Write("> ");
                CAGetRequest.ac_grp_cd = Console.ReadLine();
                Console.WriteLine("Enter the access code");
                Console.Write("> ");
                CAGetRequest.access_cd = Console.ReadLine();
                Console.WriteLine("Enter the Search String");
                Console.Write("> ");
                CAGetRequest.search = Console.ReadLine();

                //Request Parameter
                HttpResponseMessage response = await client.GetAsync(config.BASEURL() + "/CustomerAccounts?corr=" + CAGetRequest.corr +
                    "&office=" + CAGetRequest.office + "&acct_no=" + CAGetRequest.acct_no + "&sub_acct_no=" + CAGetRequest.sub_acct_no +
                    "&name=" + CAGetRequest.name + "&ssn=" + CAGetRequest.ssn + "&desig_list=" + CAGetRequest.desig_list + "&ac_grp_cd =" + CAGetRequest.ac_grp_cd +
                    "&access_cd=" + CAGetRequest.access_cd + "&search=" + CAGetRequest.search);


                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(contents);
                    Console.WriteLine("Customer Account Data fetched");
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
