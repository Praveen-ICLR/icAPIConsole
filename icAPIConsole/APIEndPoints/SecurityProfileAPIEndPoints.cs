using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using icAPIConsole.Models.SecurityProfile;
using icAPIConsole.Core;
using Newtonsoft.Json;

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


        public static async Task LoadSecurityProfile(String I)
        {

            using (var client = new HttpClient())
            {

                SecuirtyProfileLoadRequest secuirtyProfileLoadRequest = new SecuirtyProfileLoadRequest();
                UrlConfiguration config = new UrlConfiguration();


                Console.WriteLine("Enter the Change Indicator");
                Console.Write("> ");
                secuirtyProfileLoadRequest.chgind = Console.ReadLine();

                Console.WriteLine("Enter the Symbol");
                Console.Write("> ");
                secuirtyProfileLoadRequest.symbol = Console.ReadLine();

                Console.WriteLine("Enter the Assest Type");
                Console.Write("> ");
                secuirtyProfileLoadRequest.asset_type = Console.ReadLine();

                Console.WriteLine("Enter the Section Type");
                Console.Write("> ");
                secuirtyProfileLoadRequest.sec_type = Console.ReadLine();

                Console.WriteLine("Enter the Section Number");
                Console.Write("> ");
                secuirtyProfileLoadRequest.sec_no = Console.ReadLine();

                Console.WriteLine("Enter the Description");
                Console.Write("> ");
                secuirtyProfileLoadRequest.descr = Console.ReadLine();

                Console.WriteLine("Enter the Section Sub Type");
                Console.Write("> ");
                secuirtyProfileLoadRequest.sec_sub_type = Console.ReadLine();

                Console.WriteLine("Enter the Customer IP");
                Console.Write("> ");
                secuirtyProfileLoadRequest.cusip = Console.ReadLine();

                Console.WriteLine("Enter the sedol");
                Console.Write("> ");
                secuirtyProfileLoadRequest.sedol = Console.ReadLine();

                Console.WriteLine("Enter the ISIN");
                Console.Write("> ");
                secuirtyProfileLoadRequest.isin = Console.ReadLine();

                Console.WriteLine("Enter the Issuer Catgoery");
                Console.Write("> ");
                secuirtyProfileLoadRequest.issuer_catg = Console.ReadLine();

                Console.WriteLine("Enter the Customer Symbol");
                Console.Write("> ");
                secuirtyProfileLoadRequest.chgind = Console.ReadLine();

                Console.WriteLine("Enter the Exchange Value");
                Console.Write("> ");
                secuirtyProfileLoadRequest.exchange = Console.ReadLine();

                Console.WriteLine("Enter the Alternative Symbol");
                Console.Write("> ");
                secuirtyProfileLoadRequest.alt_symbol2 = Console.ReadLine();

                Console.WriteLine("Enter the Prem_multi");
                Console.Write("> ");
                string? PMS = Console.ReadLine();
                secuirtyProfileLoadRequest.prem_mult = config.ParseNullableshort(PMS);

                Console.WriteLine("Enter the marginable value");
                Console.Write("> ");
                secuirtyProfileLoadRequest.marginable = Console.ReadLine();

                Console.WriteLine("Enter the Under Symbol");
                Console.Write("> ");
                secuirtyProfileLoadRequest.under_symbol = Console.ReadLine();

                Console.WriteLine("Enter the Call Put");
                Console.Write("> ");
                secuirtyProfileLoadRequest.put_call = Console.ReadLine();

                Console.WriteLine("Enter the Strike Price");
                Console.Write("> ");
                String? SPS = Console.ReadLine();
                secuirtyProfileLoadRequest.strike_price = config.ParseNullableDecimal(SPS);

                Console.WriteLine("Enter the Expiration Date");
                Console.Write("> ");
                String? EXDS = Console.ReadLine();
                secuirtyProfileLoadRequest.expire_dt = config.ParseNullableDateTime(EXDS);

                Console.WriteLine("Enter the Status");
                Console.Write("> ");
                secuirtyProfileLoadRequest.status = Console.ReadLine();

                Console.WriteLine("Enter the Federal L Rate");
                Console.Write("> ");
                String? FLRS = Console.ReadLine();  
                secuirtyProfileLoadRequest.fed_l_rate = config.ParseNullableDecimal(FLRS);

                Console.WriteLine("Enter the Federal S Rate");
                Console.Write("> ");
                String? FSRS = Console.ReadLine();
                secuirtyProfileLoadRequest.fed_s_rate = config.ParseNullableDecimal(FSRS);

                Console.WriteLine("Enter the Exchange L Rate");
                Console.Write("> ");
                String? ELRS = Console.ReadLine();
                secuirtyProfileLoadRequest.exch_l_rate = config.ParseNullableDecimal(ELRS);

                Console.WriteLine("Enter the Exchange S Rate");
                Console.Write("> ");
                String? ESRS = Console.ReadLine();
                secuirtyProfileLoadRequest.exch_s_rate = config.ParseNullableDecimal(ESRS);

                Console.WriteLine("Enter the House L Rate");
                Console.Write("> ");
                String? HLRS = Console.ReadLine();
                secuirtyProfileLoadRequest.house_l_rate = config.ParseNullableDecimal(HLRS);

                Console.WriteLine("Enter the House S Rate");
                Console.Write("> ");
                String? HSRS = Console.ReadLine();
                secuirtyProfileLoadRequest.house_s_rate = config.ParseNullableDecimal(HSRS);

                Console.WriteLine("Enter the PM_EL_RAte");
                Console.Write("> ");
                String? PMERS = Console.ReadLine();
                secuirtyProfileLoadRequest.pm_el_rate = config.ParseNullableDecimal(PMERS);

                Console.WriteLine("Enter the PM_ES_RAte");
                Console.Write("> ");
                String? PMESRS = Console.ReadLine();
                secuirtyProfileLoadRequest.pm_es_rate = config.ParseNullableDecimal(PMESRS);

                Console.WriteLine("Enter the PM_HL_RAte");
                Console.Write("> ");
                String? PMHRS = Console.ReadLine();
                secuirtyProfileLoadRequest.pm_hl_rate = config.ParseNullableDecimal(PMHRS);

                Console.WriteLine("Enter the PM_HS_RAte");
                Console.Write("> ");
                String? PMHSRS = Console.ReadLine();
                secuirtyProfileLoadRequest.pm_hs_rate = config.ParseNullableDecimal(PMHSRS);

                Console.WriteLine("Enter the pm_hedge_hl_rate");
                Console.Write("> ");
                String? PMHedl = Console.ReadLine();
                secuirtyProfileLoadRequest.pm_hedge_hl_rate = config.ParseNullableDecimal(PMHedl);

                Console.WriteLine("Enter the PM_EL_RAte");
                Console.Write("> ");
                String? PMHedS = Console.ReadLine();
                secuirtyProfileLoadRequest.pm_hedge_hs_rate = config.ParseNullableDecimal(PMHedS);

                Console.WriteLine("Enter the PM Production Group");
                Console.Write("> ");
                secuirtyProfileLoadRequest.pm_prod_grp = Console.ReadLine();

                Console.WriteLine("Enter the PM Volatility");
                Console.Write("> ");
                String? PMVolatileS = Console.ReadLine();
                secuirtyProfileLoadRequest.pm_volatility = config.ParseNullableshort(PMVolatileS);

                Console.WriteLine("Enter the Sic Code");
                Console.Write("> ");
                secuirtyProfileLoadRequest.sic_cd = Console.ReadLine();

                Console.WriteLine("Enter the FTBR Trade Flag");
                Console.Write("> ");
                secuirtyProfileLoadRequest.ftbr_trd_flg = Console.ReadLine();

                Console.WriteLine("Enter the FTBR Section Tier");
                Console.Write("> ");
                secuirtyProfileLoadRequest.ftbr_sec_tier = Console.ReadLine();

                Console.WriteLine("Enter the Settlement Days");
                Console.Write("> ");
                String? settleDayss = Console.ReadLine();
                secuirtyProfileLoadRequest.settle_days = config.ParseNullableByte(settleDayss);

                Console.WriteLine("Enter the Redemeption Days");
                Console.Write("> ");
                String? redemeptiondayss = Console.ReadLine();  
                secuirtyProfileLoadRequest.redmp_days = config.ParseNullableshort(redemeptiondayss);

                Console.WriteLine("Enter the Redemption Fees");
                Console.Write("> ");
                String? RedemptionFeess = Console.ReadLine();
                secuirtyProfileLoadRequest.redmp_fee = config.ParseNullableDecimal(RedemptionFeess);

                Console.WriteLine("Enter the Reason for Inactive");
                Console.Write("> ");
                secuirtyProfileLoadRequest.inactive_reason = Console.ReadLine();

                Console.WriteLine("Enter the Coupon Number");
                Console.Write("> ");
                String? Coupons = Console.ReadLine();
                secuirtyProfileLoadRequest.coupon = config.ParseNullableDecimal(Coupons);

                Console.WriteLine("Enter the Coupon Type");
                Console.Write("> ");
                secuirtyProfileLoadRequest.coupon_type = Console.ReadLine();

                Console.WriteLine("Enter the Payment Frequency");
                Console.Write("> ");
                String? PFS = Console.ReadLine();
                secuirtyProfileLoadRequest.pay_freq = config.ParseNullableByte(PFS);

                Console.WriteLine("Enter the Mature Date");
                Console.Write("> ");
                String? MDS = Console.ReadLine();
                secuirtyProfileLoadRequest.mature_dt = config.ParseNullableDateTime(MDS);

                Console.WriteLine("Enter the Issue Date");
                Console.Write("> ");
                String? IDS = Console.ReadLine();
                secuirtyProfileLoadRequest.issue_dt = config.ParseNullableDateTime(IDS);

                Console.WriteLine("Enter the Dated Date");
                Console.Write("> ");
                String? dateDS = Console.ReadLine();
                secuirtyProfileLoadRequest.dated_dt = config.ParseNullableDateTime(dateDS);

                Console.WriteLine("Enter the First Coupon Date");
                Console.Write("> ");
                String? FCDS = Console.ReadLine();
                secuirtyProfileLoadRequest.first_coupon = config.ParseNullableDateTime(FCDS);

                Console.WriteLine("Enter the Last Coupon Date");
                Console.Write("> ");
                String? LCDS = Console.ReadLine();
                secuirtyProfileLoadRequest.last_coupon = config.ParseNullableDateTime(LCDS);

                Console.WriteLine("Enter the Next Coupon Date");
                Console.Write("> ");
                String? NCDS = Console.ReadLine();
                secuirtyProfileLoadRequest.next_coupon = config.ParseNullableDateTime(NCDS);

                Console.WriteLine("Enter the Previous Coupon Date");
                Console.Write("> ");
                String? PCDS = Console.ReadLine();
                secuirtyProfileLoadRequest.prev_coupon = config.ParseNullableDateTime(PCDS);

                Console.WriteLine("Enter the Taxables");
                Console.Write("> ");
                secuirtyProfileLoadRequest.taxable = Console.ReadLine();

                Console.WriteLine("Enter the Call Date1");
                Console.Write("> ");
                String? CallDS1 = Console.ReadLine();
                secuirtyProfileLoadRequest.call_dt1 = config.ParseNullableDateTime(CallDS1);

                Console.WriteLine("Enter the Call Rate1");
                Console.Write("> ");
                String? CallRS1 = Console.ReadLine();
                secuirtyProfileLoadRequest.call_rate1 = config.ParseNullableDecimal(CallRS1);

                Console.WriteLine("Enter the Call Date2");
                Console.Write("> ");
                String? CallDS2 = Console.ReadLine();
                secuirtyProfileLoadRequest.call_dt2 = config.ParseNullableDateTime(CallDS2);

                Console.WriteLine("Enter the Call Rate2");
                Console.Write("> ");
                String? CallRS2 = Console.ReadLine();
                secuirtyProfileLoadRequest.call_rate2 = config.ParseNullableDecimal(CallRS2);

                Console.WriteLine("Enter the Call Date3");
                Console.Write("> ");
                String? CallDS3 = Console.ReadLine();
                secuirtyProfileLoadRequest.call_dt3 = config.ParseNullableDateTime(CallDS3);

                Console.WriteLine("Enter the Call Rate3");
                Console.Write("> ");
                String? CallRS3 = Console.ReadLine();
                secuirtyProfileLoadRequest.call_rate3 = config.ParseNullableDecimal(CallRS3);

                Console.WriteLine("Enter the Put Date1");
                Console.Write("> ");
                String? PutDS1 = Console.ReadLine();
                secuirtyProfileLoadRequest.put_dt1 = config.ParseNullableDateTime(PutDS1);

                Console.WriteLine("Enter the Put Rate1");
                Console.Write("> ");
                String? PutRS1 = Console.ReadLine();
                secuirtyProfileLoadRequest.put_rate1 = config.ParseNullableDecimal(PutRS1);

                Console.WriteLine("Enter the put Date2");
                Console.Write("> ");
                String? putDS2 = Console.ReadLine();
                secuirtyProfileLoadRequest.put_dt2 = config.ParseNullableDateTime(putDS2);

                Console.WriteLine("Enter the put Rate2");
                Console.Write("> ");
                String? putRS2 = Console.ReadLine();
                secuirtyProfileLoadRequest.put_rate2 = config.ParseNullableDecimal(putRS2);

                Console.WriteLine("Enter the put Date3");
                Console.Write("> ");
                String? putDS3 = Console.ReadLine();
                secuirtyProfileLoadRequest.put_dt3 = config.ParseNullableDateTime(putDS3);

                Console.WriteLine("Enter the put Rate3");
                Console.Write("> ");
                String? putRS3 = Console.ReadLine();
                secuirtyProfileLoadRequest.put_rate3 = config.ParseNullableDecimal(putRS3);

                Console.WriteLine("Enter the Section Charge");
                Console.Write("> ");
                secuirtyProfileLoadRequest.sec_charge = Console.ReadLine();

                Console.WriteLine("Enter the Country");
                Console.Write("> ");
                secuirtyProfileLoadRequest.country = Console.ReadLine();

                Console.WriteLine("Enter the Wi");
                Console.Write("> ");
                secuirtyProfileLoadRequest.wi = Console.ReadLine();

                Console.WriteLine("Enter the Wi Date");
                Console.Write("> ");
                String? WiDates = Console.ReadLine();
                secuirtyProfileLoadRequest.wi_dt = config.ParseNullableDateTime(WiDates);

                Console.WriteLine("Enter the mfdiv_accr");
                Console.Write("> ");
                secuirtyProfileLoadRequest.mfdiv_accr = Console.ReadLine();

                Console.WriteLine("Enter the mfdiv_buy_accr");
                Console.Write("> ");
                String? MFBuyAccrs = Console.ReadLine();
                secuirtyProfileLoadRequest.mfdiv_buy_accr = config.ParseNullableshort(MFBuyAccrs);

            

                Console.WriteLine("Enter the mfdiv_sell_accr");
                Console.Write("> ");
                String? MFSellAccrs = Console.ReadLine();
                secuirtyProfileLoadRequest.mfdiv_sell_accr = config.ParseNullableshort(MFSellAccrs);

                Console.WriteLine("Enter the contract_shrs");
                Console.Write("> ");
                String? ContactShrs = Console.ReadLine();
                secuirtyProfileLoadRequest.contract_shrs = config.ParseNullableshort(ContactShrs);

                Console.WriteLine("Enter the Issuer Number");
                Console.Write("> ");
                String? IssNums = Console.ReadLine();
                secuirtyProfileLoadRequest.issuer_no = config.ParseNullableshort(IssNums);

                Console.WriteLine("Enter the Rating Number");
                Console.Write("> ");
                String? RatingNums = Console.ReadLine();
                secuirtyProfileLoadRequest.rating_no = config.ParseNullableshort(RatingNums);

                Console.WriteLine("Enter the Rating Number 2");
                Console.Write("> ");
                String? RatingNums2 = Console.ReadLine();
                secuirtyProfileLoadRequest.rating_no2 = config.ParseNullableshort(RatingNums2);

                Console.WriteLine("Enter the Rating Number 3");
                Console.Write("> ");
                String? RatingNums3 = Console.ReadLine();
                secuirtyProfileLoadRequest.rating_no3 = config.ParseNullableshort(RatingNums3);

                Console.WriteLine("Enter the Currency");
                Console.Write("> ");
                secuirtyProfileLoadRequest.currency = Console.ReadLine();

                Console.WriteLine("Enter the Penny Pilot");
                Console.Write("> ");
                secuirtyProfileLoadRequest.penny_pilot = Console.ReadLine();

                Console.WriteLine("Enter the eq_hard2brw");
                Console.Write("> ");
                secuirtyProfileLoadRequest.eq_hard2brw = Console.ReadLine();

                Console.WriteLine("Enter the Sweep Destination");
                Console.Write("> ");
                secuirtyProfileLoadRequest.sweep_dest = Console.ReadLine();

                Console.WriteLine("Enter the Sweep Symbol");
                Console.Write("> ");
                secuirtyProfileLoadRequest.sweep_sym = Console.ReadLine();

                Console.WriteLine("Enter the Accuracy Basis");
                Console.Write("> ");
                secuirtyProfileLoadRequest.accr_basis = Console.ReadLine();

                Console.WriteLine("Enter the Trace eligibility");
                Console.Write("> ");
                secuirtyProfileLoadRequest.trace_elig = Console.ReadLine();

                Console.WriteLine("Enter the Trace Date");
                Console.Write("> ");
                String? TDS = Console.ReadLine();
                secuirtyProfileLoadRequest.trace_dt = config.ParseNullableDateTime(TDS);

                Console.WriteLine("Enter the Trace Status");
                Console.Write("> ");
                secuirtyProfileLoadRequest.trace_status = Console.ReadLine();

                Console.WriteLine("Enter the Mic");
                Console.Write("> ");
                secuirtyProfileLoadRequest.mic = Console.ReadLine();

                Console.WriteLine("Enter the Parent Country Code");
                Console.Write("> ");
                secuirtyProfileLoadRequest.parent_ctry_cd = Console.ReadLine();

                Console.WriteLine("Enter the Override Rate");
                Console.Write("> ");
                String? OverrideRates = Console.ReadLine();
                secuirtyProfileLoadRequest.override_rate = config.ParseNullableDecimal(OverrideRates);

                Console.WriteLine("Enter the Federal Tax");
                Console.Write("> ");
                secuirtyProfileLoadRequest.fed_taxable = Console.ReadLine();

                Console.WriteLine("Enter the State tax");
                Console.Write("> ");
                secuirtyProfileLoadRequest.state_taxable = Console.ReadLine();

                Console.WriteLine("Enter the Firm Section Type");
                Console.Write("> ");
                secuirtyProfileLoadRequest.firm_sec_type = Console.ReadLine();

                Console.WriteLine("Enter the Cov & Uncov");
                Console.Write("> ");
                secuirtyProfileLoadRequest.cov_uncov = Console.ReadLine();

                Console.WriteLine("Enter the Contra Cusip Flag");
                Console.Write("> ");
                secuirtyProfileLoadRequest.contra_cusip_flg = Console.ReadLine();

                Console.WriteLine("Enter the Master Cusip");
                Console.Write("> ");
                secuirtyProfileLoadRequest.master_cusip = Console.ReadLine();





                var dataAsString = JsonConvert.SerializeObject(secuirtyProfileLoadRequest);
                var dataContent = new StringContent(dataAsString, Encoding.UTF8, "application/json");
                if (I == "C")
                {
                    HttpResponseMessage response = await client.PutAsync(config.BASEURL() + "/SecurityProfile", dataContent);

                    if (response.IsSuccessStatusCode)
                    {
                        Uri? ncrUrl = response.Headers.Location;
                        var contents = await response.Content.ReadAsStringAsync();
                        //  var responsebody = JsonConvert.SerializeObject(contents);
                        Console.WriteLine(contents);
                        Console.WriteLine("Security Profile Loaded");
                    }
                    else
                    {
                        Console.WriteLine("Statuscode is error");
                        Console.WriteLine(response.Content);

                    }
                }

                else if(I == "B")
                {
                    HttpResponseMessage response = await client.PostAsync(config.BASEURL() + "/SecurityProfile", dataContent);

                    if (response.IsSuccessStatusCode)
                    {
                        Uri? ncrUrl = response.Headers.Location;
                        var contents = await response.Content.ReadAsStringAsync();
                        //  var responsebody = JsonConvert.SerializeObject(contents);
                        Console.WriteLine(contents);
                        Console.WriteLine("Security Profile Loaded");
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
}
