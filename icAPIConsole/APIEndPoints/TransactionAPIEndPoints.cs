using icAPIConsole.Core;
using icAPIConsole.Models.Transactions;
using Newtonsoft.Json;
using System.Text;

namespace icAPIConsole.APIEndPoints
{
    public class TransactionAPIEndPoints
    {
        //Cancel Transactions..
        public static async Task CancelTransaction()
        {

            using (var client = new HttpClient())
            {


                TransactionsCancelRequest TCrequest = new TransactionsCancelRequest();
                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the Trade Number ");
                Console.Write("> ");
                String? trnos = Console.ReadLine();
                TCrequest.tr_no = config.ParseNullableDecimal(trnos);

                Console.WriteLine("Enter the System Date");
                Console.Write("> ");
                TCrequest.system_dt = Console.ReadLine();

                Console.WriteLine("Enter the Trade Tag");
                Console.Write("> ");
                TCrequest.trd_tag = Console.ReadLine();

                Console.WriteLine("Enter the Cancel Order id");
                Console.Write("> ");
                TCrequest.cl_order_id = Console.ReadLine();

                Console.WriteLine("Enter the Cancel Resason");
                Console.Write("> ");
                TCrequest.cncl_reason = Console.ReadLine();

                Console.WriteLine("Enter the ib_cancel");
                Console.Write("> ");
                TCrequest.ib_cancel = Console.ReadLine();




                var dataAsString = JsonConvert.SerializeObject(TCrequest);
                Console.WriteLine(dataAsString);
                var dataContent = new StringContent(dataAsString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(config.BASEURL() + "/Transactions/Cancel", dataContent);

                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
                    Console.WriteLine("Transaction Cancelled");
                }
                else
                {
                    Console.WriteLine("Statuscode is error");
                    Console.WriteLine(response.Content);
                 
                }


            }
        }

        //Cancel Transactions..
        public static async Task CancelAllTransaction()
        {

            using (var client = new HttpClient())
            {


                TransactionsCancelAllRequest TACrequest = new TransactionsCancelAllRequest();
                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the System String");
                Console.Write("> ");
                TACrequest.sysStr = Console.ReadLine();

                Console.WriteLine("Enter the Trade Tag");
                Console.Write("> ");
                TACrequest.trdTag = Console.ReadLine();




                var dataAsString = JsonConvert.SerializeObject(TACrequest);
                Console.WriteLine(dataAsString);
                var dataContent = new StringContent(dataAsString, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(config.BASEURL() + "/Transactions/CancelAll", dataContent);

                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
                    Console.WriteLine("All Transaction Cancelled");
                }
                else
                {
                    Console.WriteLine("Statuscode is error");
                    Console.WriteLine(response.Content);

                }


            }
        }

        public static async Task GetTransaction()
        {

            using (var client = new HttpClient())
            {


                TransactionGetRequest transactionGetRequest = new TransactionGetRequest();
                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the Trade Number");
                Console.Write("> ");
                String? trno = Console.ReadLine();
                transactionGetRequest.tr_no = config.ParseNullableDecimal(trno);

                Console.WriteLine("Enter the Type List");
                Console.Write("> ");
                transactionGetRequest.etype_list = Console.ReadLine();

                Console.WriteLine("Enter the Corresponsent");
                Console.Write("> ");
                transactionGetRequest.corr = Console.ReadLine();

                Console.WriteLine("Enter the account number");
                Console.Write("> ");
                transactionGetRequest.acct_no = Console.ReadLine();

                Console.WriteLine("Enter the office");
                Console.Write("> ");
                transactionGetRequest.office = Console.ReadLine();

                Console.WriteLine("Enter the account type");
                Console.Write("> ");
                transactionGetRequest.acct_type = Console.ReadLine();

                Console.WriteLine("Enter the Sub Account Number");
                Console.Write("> ");
                transactionGetRequest.sub_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                transactionGetRequest.symbol = Console.ReadLine();

                Console.WriteLine("Enter the Quantity");
                Console.Write("> ");
                String? quantity = Console.ReadLine();
                transactionGetRequest.qty = config.ParseNullableDecimal(quantity);

                Console.WriteLine("Enter the Price");
                Console.Write("> ");
                String? pric = Console.ReadLine();
                transactionGetRequest.price = config.ParseNullableDecimal(pric);

                Console.WriteLine("Enter the Amount");
                Console.Write("> ");
                String? amt = Console.ReadLine();
                transactionGetRequest.n_amt = config.ParseNullableDecimal(amt);

                Console.WriteLine("Enter the Contra Code");
                Console.Write("> ");
                transactionGetRequest.contra_code = Console.ReadLine();

                Console.WriteLine("Enter the Exchange Code");
                Console.Write("> ");
                transactionGetRequest.blot_exch_cd = Console.ReadLine();


                Console.WriteLine("Enter the Clear Type");
                Console.Write("> ");
                transactionGetRequest.blot_clr_typ = Console.ReadLine();

                Console.WriteLine("Enter the Method");
                Console.Write("> ");
                transactionGetRequest.blot_method = Console.ReadLine();

                Console.WriteLine("Enter the fees type");
                Console.Write("> ");
                transactionGetRequest.feetyp = Console.ReadLine();

                Console.WriteLine("Enter the ftdt");
                Console.Write("> ");
                transactionGetRequest.ftdt = Console.ReadLine();


                Console.WriteLine("Enter the ttdt");
                Console.Write("> ");
                transactionGetRequest.ttdt = Console.ReadLine();

                Console.WriteLine("Enter the fsdt");
                Console.Write("> ");
                transactionGetRequest.fsdt = Console.ReadLine();

                Console.WriteLine("Enter the tsdt");
                Console.Write("> ");
                transactionGetRequest.tsdt = Console.ReadLine();

                Console.WriteLine("Enter the fxdt");
                Console.Write("> ");
                transactionGetRequest.fxdt = Console.ReadLine();

                Console.WriteLine("Enter the txdt");
                Console.Write("> ");
                transactionGetRequest.txdt = Console.ReadLine();

                Console.WriteLine("Enter the side");
                Console.Write("> ");
                transactionGetRequest.side = Console.ReadLine();

                Console.WriteLine("Enter the settle");
                Console.Write("> ");
                transactionGetRequest.settle = Console.ReadLine();

                Console.WriteLine("Enter the rr_cd");
                Console.Write("> ");
                transactionGetRequest.rr_cd = Console.ReadLine();

                Console.WriteLine("Enter the c_corr");
                Console.Write("> ");
                transactionGetRequest.c_corr = Console.ReadLine();

                Console.WriteLine("Enter the c_office");
                Console.Write("> ");
                transactionGetRequest.c_office = Console.ReadLine();

                Console.WriteLine("Enter the c_acct_no");
                Console.Write("> ");
                transactionGetRequest.c_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the c_acct_type");
                Console.Write("> ");
                transactionGetRequest.c_acct_type = Console.ReadLine();

                Console.WriteLine("Enter the c_sub_acct_no");
                Console.Write("> ");
                transactionGetRequest.c_sub_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the loginid");
                Console.Write("> ");
                transactionGetRequest.loginid = Console.ReadLine();

                Console.WriteLine("Enter the Trade Tag");
                Console.Write("> ");
                transactionGetRequest.trd_tag = Console.ReadLine();

                Console.WriteLine("Enter the exclude_login");
                Console.Write("> ");
                transactionGetRequest.exclude_login = Console.ReadLine();

                Console.WriteLine("Enter the currency");
                Console.Write("> ");
                transactionGetRequest.currency = Console.ReadLine();

                Console.WriteLine("Enter the access group code");
                Console.Write("> ");
                transactionGetRequest.ac_grp_cd = Console.ReadLine();

                Console.WriteLine("Enter the capacity");
                Console.Write("> ");
                transactionGetRequest.capacity = Console.ReadLine();

                Console.WriteLine("Enter the batch number");
                Console.Write("> ");
                String? bno = Console.ReadLine();
                transactionGetRequest.batchno = config.ParseNullableInt(bno);

                Console.WriteLine("Enter the w8w9");
                Console.Write("> ");
                transactionGetRequest.w8w9 = Console.ReadLine();

                Console.WriteLine("Enter the Clear order id");
                Console.Write("> ");
                transactionGetRequest.cl_order_id = Console.ReadLine();





                HttpResponseMessage response = await client.GetAsync(config.BASEURL() + "/Transactions?tr_no=" + transactionGetRequest.tr_no +
               "&etype_list=" + transactionGetRequest.etype_list +
               "&corr=" + transactionGetRequest.corr +
               "&office=" + transactionGetRequest.office +
               "&acct_no=" + transactionGetRequest.acct_no +
               "&acct_type=" + transactionGetRequest.acct_type +
               "&sub_acct_no=" + transactionGetRequest.sub_acct_no +
               "&symbol=" + transactionGetRequest.symbol +
               "&qty=" + transactionGetRequest.qty +
               "&price=" + transactionGetRequest.price +
               "&n_amt=" + transactionGetRequest.n_amt +
               "&contra_code=" + transactionGetRequest.contra_code +
               "&blot_exch_cd=" + transactionGetRequest.blot_exch_cd +
               "&blot_clr_typ=" + transactionGetRequest.blot_clr_typ +
               "&blot_method=" + transactionGetRequest.blot_method +
               "&feetyp =" + transactionGetRequest.feetyp +
               "&ftdt=" + transactionGetRequest.ftdt +
               "&ttdt=" + transactionGetRequest.ttdt +
               "&fsdt=" + transactionGetRequest.fsdt +
               "&tsdt=" + transactionGetRequest.tsdt +
               "&fxdt=" + transactionGetRequest.fxdt +
               "&txdt=" + transactionGetRequest.txdt +
               "&side=" + transactionGetRequest.side +
               "&settle=" + transactionGetRequest.settle +
               "&rr_cd=" + transactionGetRequest.rr_cd +
               "&c_corr=" + transactionGetRequest.c_corr +
               "&c_office =" + transactionGetRequest.c_office +
               "&c_acct_no=" + transactionGetRequest.c_acct_no +
               "&c_acct_type=" + transactionGetRequest.c_acct_type +
               "&c_sub_acct_no=" + transactionGetRequest.c_sub_acct_no +
               "&loginid=" + transactionGetRequest.loginid +
               "&trd_tag=" + transactionGetRequest.trd_tag +
               "&exclude_login=" + transactionGetRequest.exclude_login +
               "&currency=" + transactionGetRequest.currency +
               "&ac_grp_cd=" + transactionGetRequest.ac_grp_cd +
               "&capacity=" + transactionGetRequest.capacity +
               "&batchno=" + transactionGetRequest.batchno +
               "&w8w9=" + transactionGetRequest.w8w9 +
               "&cl_order_id=" + transactionGetRequest.cl_order_id);


                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(contents);
                  
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
                    Console.WriteLine("Transaction Data fetched");
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
