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

        //Cancel Transactions..
        public static async Task PostTransaction()
        {

            using (var client = new HttpClient())
            {


                TransactionLoadRequest transactionLoadRequest = new TransactionLoadRequest();
                UrlConfiguration config = new UrlConfiguration();

                Console.WriteLine("Enter the Entry Type");
                Console.Write("> ");
                transactionLoadRequest.entry_type = Console.ReadLine();

                Console.WriteLine("Enter the Trade Type");
                Console.Write("> ");
                transactionLoadRequest.trd_type = Console.ReadLine();

                Console.WriteLine("Enter the System Date");
                Console.Write("> ");
                String? SYDS = Console.ReadLine();
                transactionLoadRequest.system_dt = config.ParseNullableDateTime(SYDS);

                Console.WriteLine("Enter the Entry Date");
                Console.Write("> ");
                String? ENDS = Console.ReadLine();
                transactionLoadRequest.entry_dt = config.ParseNullableDateTime(ENDS);

                Console.WriteLine("Enter the Trade Date");
                Console.Write("> ");
                String? TRDS = Console.ReadLine();
                transactionLoadRequest.trade_dt = config.ParseNullableDateTime(TRDS);

                Console.WriteLine("Enter the Settle Date");
                Console.Write("> ");
                String? STDS = Console.ReadLine();
                transactionLoadRequest.settle_dt = config.ParseNullableDateTime(STDS);

                Console.WriteLine("Enter the Execution Date");
                Console.Write("> ");
                String? ECDS = Console.ReadLine();
                transactionLoadRequest.exec_dt = config.ParseNullableDateTime(ECDS);

                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                transactionLoadRequest.symbol = Console.ReadLine();

                Console.WriteLine("Enter the Quantity");
                Console.Write("> ");
                String? Quantity = Console.ReadLine();
                transactionLoadRequest.qty = config.ParseNullableDecimal(Quantity);

                Console.WriteLine("Enter the Price Amount");
                Console.Write("> ");
                String? Price = Console.ReadLine();
                transactionLoadRequest.price = config.ParseNullableDecimal(Price);

                Console.WriteLine("Enter the G_Amount");
                Console.Write("> ");
                String? G_amount = Console.ReadLine();
                transactionLoadRequest.g_amt = config.ParseNullableDecimal(G_amount);

                Console.WriteLine("Enter the N_Amount");
                Console.Write("> ");
                String? N_amount = Console.ReadLine();
                transactionLoadRequest.n_amt = config.ParseNullableDecimal(N_amount);

                Console.WriteLine("Enter the Security Fees");
                Console.Write("> ");
                String? Sec_Fees = Console.ReadLine();
                transactionLoadRequest.sec_fee = config.ParseNullableDecimal(Sec_Fees);

                Console.WriteLine("Enter the Exchange Fees");
                Console.Write("> ");
                String? Exch_Fees = Console.ReadLine();
                transactionLoadRequest.exch_fee = config.ParseNullableDecimal(Exch_Fees);

                Console.WriteLine("Enter the Clear Fees");
                Console.Write("> ");
                String? clr_Fees = Console.ReadLine();
                transactionLoadRequest.clr_fee = config.ParseNullableDecimal(clr_Fees);

                Console.WriteLine("Enter the ECN Fees");
                Console.Write("> ");
                String? ecn_Fees = Console.ReadLine();
                transactionLoadRequest.ecn_fee = config.ParseNullableDecimal(ecn_Fees);

                Console.WriteLine("Enter the breakage Fees");
                Console.Write("> ");
                String? brk_Fees = Console.ReadLine();
                transactionLoadRequest.brk_fee = config.ParseNullableDecimal(brk_Fees);

                Console.WriteLine("Enter the OCC Fees");
                Console.Write("> ");
                String? occ_Fees = Console.ReadLine();
                transactionLoadRequest.occ_fee = config.ParseNullableDecimal(occ_Fees);

                Console.WriteLine("Enter the other Fees");
                Console.Write("> ");
                String? oth_Fees = Console.ReadLine();
                transactionLoadRequest.oth_fee = config.ParseNullableDecimal(oth_Fees);

                Console.WriteLine("Enter the Correspondent");
                Console.Write("> ");
                transactionLoadRequest.corr = Console.ReadLine();

                Console.WriteLine("Enter the office");
                Console.Write("> ");
                transactionLoadRequest.office = Console.ReadLine();

                Console.WriteLine("Enter the Account Number");
                Console.Write("> ");
                transactionLoadRequest.acct_no = Console.ReadLine();

                Console.WriteLine("Enter the Account Type");
                Console.Write("> ");
                transactionLoadRequest.acct_type = Console.ReadLine();

                Console.WriteLine("Enter the Sub Account Number");
                Console.Write("> ");
                transactionLoadRequest.sub_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the Contra_code");
                Console.Write("> ");
                transactionLoadRequest.contra_code = Console.ReadLine();

                Console.WriteLine("Enter the Contra_crosspondent");
                Console.Write("> ");
                transactionLoadRequest.contra_corr = Console.ReadLine();

                Console.WriteLine("Enter the Contra_office");
                Console.Write("> ");
                transactionLoadRequest.contra_office = Console.ReadLine();

                Console.WriteLine("Enter the Contra_acct_no");
                Console.Write("> ");
                transactionLoadRequest.contra_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the Contra_acct_type");
                Console.Write("> ");
                transactionLoadRequest.contra_acct_type = Console.ReadLine();

                Console.WriteLine("Enter the Contra_sub_acct_no");
                Console.Write("> ");
                transactionLoadRequest.contra_sub_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the Blotter Exchange Code");
                Console.Write("> ");
                transactionLoadRequest.blot_exch_cd = Console.ReadLine();

                Console.WriteLine("Enter the Blotter Clear Type");
                Console.Write("> ");
                transactionLoadRequest.blot_clr_typ = Console.ReadLine();

                Console.WriteLine("Enter the Blotter Method");
                Console.Write("> ");
                transactionLoadRequest.blot_method = Console.ReadLine();

                Console.WriteLine("Enter the Capacity");
                Console.Write("> ");
                transactionLoadRequest.capacity = Console.ReadLine();

                Console.WriteLine("Enter the Sold and Unsold");
                Console.Write("> ");
                transactionLoadRequest.sol_unsol = Console.ReadLine();

                Console.WriteLine("Enter the Trade tag");
                Console.Write("> ");
                transactionLoadRequest.trd_tag = Console.ReadLine();

                Console.WriteLine("Enter the Description");
                Console.Write("> ");
                transactionLoadRequest.descr = Console.ReadLine();

                Console.WriteLine("Enter the Login ID");
                Console.Write("> ");
                transactionLoadRequest.loginid = Console.ReadLine();

                Console.WriteLine("Enter the Memo 1");
                Console.Write("> ");
                transactionLoadRequest.memo1 = Console.ReadLine();

                Console.WriteLine("Enter the Memo 2");
                Console.Write("> ");
                transactionLoadRequest.memo2 = Console.ReadLine();

                Console.WriteLine("Enter the Memo 3");
                Console.Write("> ");
                transactionLoadRequest.memo3 = Console.ReadLine();

                Console.WriteLine("Enter the Reinvestment Code");
                Console.Write("> ");
                transactionLoadRequest.rr_cd = Console.ReadLine();

                Console.WriteLine("Enter the Tax lot");
                Console.Write("> ");
                transactionLoadRequest.tax_lot = Console.ReadLine();

                Console.WriteLine("Enter the Lot Trade Number");
                Console.Write("> ");
                String? lot_trade_Numbers = Console.ReadLine();
                transactionLoadRequest.lot_tr_no = config.ParseNullableDecimal(lot_trade_Numbers);

                Console.WriteLine("Enter the Buyer Interest");
                Console.Write("> ");
                String? buy_interests = Console.ReadLine();
                transactionLoadRequest.buy_interest = config.ParseNullableDecimal(buy_interests);

                Console.WriteLine("Enter the Financial Yield");
                Console.Write("> ");
                String? finc_yields = Console.ReadLine();
                transactionLoadRequest.finc_yield = config.ParseNullableDecimal(finc_yields);

                Console.WriteLine("Enter the RPTD Price");
                Console.Write("> ");
                String? rptd_prices = Console.ReadLine();
                transactionLoadRequest.rptd_price = config.ParseNullableDecimal(rptd_prices);

                Console.WriteLine("Enter the Sales Credit");
                Console.Write("> ");
                String? sales_credits = Console.ReadLine();
                transactionLoadRequest.sales_credit = config.ParseNullableDecimal(sales_credits);

                Console.WriteLine("Enter the Tax Lot Trade Number");
                Console.Write("> ");
                String? tax_lotTrNumber = Console.ReadLine();
                transactionLoadRequest.tax_lot_tr_no = config.ParseNullableDecimal(tax_lotTrNumber);

                Console.WriteLine("Enter the Financial Discount");
                Console.Write("> ");
                String? Finc_discounts = Console.ReadLine();
                transactionLoadRequest.finc_discount = config.ParseNullableDecimal(Finc_discounts);

                Console.WriteLine("Enter the Financial Spread");
                Console.Write("> ");
                String? finc_Spread = Console.ReadLine();
                transactionLoadRequest.finc_spread = config.ParseNullableDecimal(finc_Spread);

                Console.WriteLine("Enter the Factor");
                Console.Write("> ");
                String? factors = Console.ReadLine();
                transactionLoadRequest.factor = config.ParseNullableDecimal(factors);

                Console.WriteLine("Enter the Repo Rate");
                Console.Write("> ");
                String? repo_rates = Console.ReadLine();
                transactionLoadRequest.repo_rate = config.ParseNullableDecimal(repo_rates);

                Console.WriteLine("Enter the Factor Date");
                Console.Write("> ");
                String? factorDates = Console.ReadLine();
                transactionLoadRequest.factor_dt = config.ParseNullableDateTime(factorDates);

                Console.WriteLine("Enter the delivery Date");
                Console.Write("> ");
                String? deliveryDates = Console.ReadLine();
                transactionLoadRequest.delivery_dt = config.ParseNullableDateTime(deliveryDates);

                Console.WriteLine("Enter the Yield Type");
                Console.Write("> ");
                transactionLoadRequest.yield_type = Console.ReadLine();

                Console.WriteLine("Enter the Access Group Code");
                Console.Write("> ");
                transactionLoadRequest.ac_grp_cd = Console.ReadLine();

                Console.WriteLine("Enter the Trailer Codes");
                Console.Write("> ");
                transactionLoadRequest.trailer_codes = Console.ReadLine();

                Console.WriteLine("Enter the ad_code");
                Console.Write("> ");
                transactionLoadRequest.ad_cd = Console.ReadLine();

                Console.WriteLine("Enter the an_code");
                Console.Write("> ");
                transactionLoadRequest.an_cd = Console.ReadLine();

                Console.WriteLine("Enter the Trade Code");
                Console.Write("> ");
                transactionLoadRequest.tr_cd = Console.ReadLine();

                Console.WriteLine("Enter the Currency");
                Console.Write("> ");
                transactionLoadRequest.currency1 = Console.ReadLine();

                Console.WriteLine("Enter the Set Currency");
                Console.Write("> ");
                transactionLoadRequest.set_currency = Console.ReadLine();

                Console.WriteLine("Enter the Set Country Value");
                Console.Write("> ");
                transactionLoadRequest.set_country = Console.ReadLine();

                Console.WriteLine("Enter the Set Location Value");
                Console.Write("> ");
                transactionLoadRequest.set_location = Console.ReadLine();

                Console.WriteLine("Enter the Discretion Flag");
                Console.Write("> ");
                transactionLoadRequest.discretion_flg = Console.ReadLine();


                Console.WriteLine("Enter the Comman Flag");
                Console.Write("> ");
                transactionLoadRequest.commflag = Console.ReadLine();

                Console.WriteLine("Enter the Cancel Order Id");
                Console.Write("> ");
                transactionLoadRequest.cl_order_id = Console.ReadLine();

                Console.WriteLine("Enter the Order Id");
                Console.Write("> ");
                transactionLoadRequest.cl_order_id = Console.ReadLine();

                Console.WriteLine("Enter the Execution Id");
                Console.Write("> ");
                transactionLoadRequest.cl_order_id = Console.ReadLine();

                Console.WriteLine("Enter the Price Source");
                Console.Write("> ");
                transactionLoadRequest.price_source = Console.ReadLine();



                var dataAsString = JsonConvert.SerializeObject(transactionLoadRequest);
                Console.WriteLine(dataAsString);
                var dataContent = new StringContent("[" + dataAsString + "]", Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(config.BASEURL() + "/Transactions", dataContent);

                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
                    Console.WriteLine("Transaction Posted");
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
