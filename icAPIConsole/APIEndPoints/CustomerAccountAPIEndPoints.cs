using icAPIConsole.Core;
using icAPIConsole.Models.CustomerAccount;
using Newtonsoft.Json;
using System.Text;
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
                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
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


        //Add a Customer Account 
        public static async Task AddCustomerAccount()
        {

            using (var client = new HttpClient())
            {

                CustomerAccountLoadRequest customerAccountLoadRequest = new CustomerAccountLoadRequest();
                UrlConfiguration config = new UrlConfiguration();


                #region "cust_profile fields"
                Console.WriteLine("Enter the Correspondent");
                Console.Write("> ");
                customerAccountLoadRequest.corr = Console.ReadLine();

                Console.WriteLine("Enter the Office");
                Console.Write("> ");
                customerAccountLoadRequest.office = Console.ReadLine();

                Console.WriteLine("Enter the Account Number");
                Console.Write("> ");
                customerAccountLoadRequest.acct_no = Console.ReadLine();

                Console.WriteLine("Enter the Account Name");
                Console.Write("> ");
                customerAccountLoadRequest.acct_name = Console.ReadLine();

                Console.WriteLine("Enter the Short Name");
                Console.Write("> ");
                customerAccountLoadRequest.short_name = Console.ReadLine();

                Console.WriteLine("Enter the Port Track");
                Console.Write("> ");
                customerAccountLoadRequest.port_track = Console.ReadLine();

                Console.WriteLine("Enter the Designator");
                Console.Write("> ");
                customerAccountLoadRequest.designator = Console.ReadLine();

                Console.WriteLine("Enter the cost of Designator");
                Console.Write("> ");
                customerAccountLoadRequest.cost_desig = Console.ReadLine();

                Console.WriteLine("Enter the Tax Lot");
                Console.Write("> ");
                customerAccountLoadRequest.tax_lot = Console.ReadLine();

                Console.WriteLine("Enter the Capacity");
                Console.Write("> ");
                customerAccountLoadRequest.capacity = Console.ReadLine();

                Console.WriteLine("Enter the Sold & Unsold");
                Console.Write("> ");
                customerAccountLoadRequest.sol_unsol = Console.ReadLine();

                Console.WriteLine("Enter the RR Code");
                Console.Write("> ");
                customerAccountLoadRequest.rr_cd = Console.ReadLine();

                Console.WriteLine("Enter the AD code");
                Console.Write("> ");
                customerAccountLoadRequest.ad_cd = Console.ReadLine();

                Console.WriteLine("Enter the AN code");
                Console.Write("> ");
                customerAccountLoadRequest.an_cd = Console.ReadLine();

                Console.WriteLine("Enter the PM code");
                Console.Write("> ");
                customerAccountLoadRequest.pm_cd = Console.ReadLine();

                Console.WriteLine("Enter the Account Group Code");
                Console.Write("> ");
                customerAccountLoadRequest.ac_grp_cd = Console.ReadLine();

                Console.WriteLine("Enter the Currency");
                Console.Write("> ");
                customerAccountLoadRequest.currency = Console.ReadLine();

                Console.WriteLine("Enter the Legal Entity");
                Console.Write("> ");
                customerAccountLoadRequest.legal_entity = Console.ReadLine();

                Console.WriteLine("Enter the Classification");
                Console.Write("> ");
                customerAccountLoadRequest.classification = Console.ReadLine();

                Console.WriteLine("Enter the Social Security Number");
                Console.Write("> ");
                customerAccountLoadRequest.ssn = Console.ReadLine();

                Console.WriteLine("Enter the Security Charge");
                Console.Write("> ");
                customerAccountLoadRequest.sec_charge = Console.ReadLine();

                Console.WriteLine("Enter the CA Fraction");
                Console.Write("> ");
                customerAccountLoadRequest.ca_frac = Console.ReadLine();

                Console.WriteLine("Enter the W8 date");
                Console.Write("> ");
                String? SDT = Console.ReadLine();
                customerAccountLoadRequest.w8_dt = config.ParseNullableDateTime(SDT);

                Console.WriteLine("Enter the Employee");
                Console.Write("> ");
                customerAccountLoadRequest.employee = Console.ReadLine();

                Console.WriteLine("Enter the Firm of the Employee");
                Console.Write("> ");
                customerAccountLoadRequest.employee = Console.ReadLine();

                Console.WriteLine("Enter the Marital Status");
                Console.Write("> ");
                customerAccountLoadRequest.marital_status = Console.ReadLine();

                Console.WriteLine("Enter Number of Dependants ");
                Console.Write("> ");
                String? dependants = Console.ReadLine();
                customerAccountLoadRequest.dependants = config.ParseNullableByte(dependants);

                Console.WriteLine("Enter the Date of Birth");
                Console.Write("> ");
                String? DOBS = Console.ReadLine();
                customerAccountLoadRequest.dob = config.ParseNullableDateTime(DOBS);

                Console.WriteLine("Enter the Nasd of Employee");
                Console.Write("> ");
                customerAccountLoadRequest.nasd_emp = Console.ReadLine();

                Console.WriteLine("Enter the Nasd of Spouse");
                Console.Write("> ");
                customerAccountLoadRequest.nasd_spouse = Console.ReadLine();

                Console.WriteLine("Enter the Larger Trader ID");
                Console.Write("> ");
                customerAccountLoadRequest.large_trader_id = Console.ReadLine();

                Console.WriteLine("Enter the Reason for Inactive");
                Console.Write("> ");
                customerAccountLoadRequest.inactive_reason = Console.ReadLine();

                Console.WriteLine("Enter the Start Date");
                Console.Write("> ");
                String? StDt = Console.ReadLine();
                customerAccountLoadRequest.stat_st_dt = config.ParseNullableDateTime(StDt);

                Console.WriteLine("Enter the End Date");
                Console.Write("> ");
                String? EtDt = Console.ReadLine();
                customerAccountLoadRequest.stat_en_dt = config.ParseNullableDateTime(EtDt);

                Console.WriteLine("Enter the INV objective");
                Console.Write("> ");
                customerAccountLoadRequest.inv_objective = Console.ReadLine();

                Console.WriteLine("Enter the Risk Tolerance");
                Console.Write("> ");
                customerAccountLoadRequest.risk_tolerence = Console.ReadLine();

                Console.WriteLine("Enter the Financial Data");
                Console.Write("> ");
                customerAccountLoadRequest.fncl_data = Console.ReadLine();

                Console.WriteLine("Enter the JT Financial Data");
                Console.Write("> ");
                customerAccountLoadRequest.jt_fncl_data = Console.ReadLine();

                Console.WriteLine("Enter the Tax Bracket");
                Console.Write("> ");
                String? TBS = Console.ReadLine();
                customerAccountLoadRequest.tax_bracket = config.ParseNullableByte(TBS);

                Console.WriteLine("Enter the Stock Level");
                Console.Write("> ");
                customerAccountLoadRequest.level_stocks = Console.ReadLine();

                Console.WriteLine("Enter the Stock Year");
                Console.Write("> ");
                String? STYS = Console.ReadLine();
                customerAccountLoadRequest.years_stocks = config.ParseNullableByte(STYS);

                Console.WriteLine("Enter the Option Level");
                Console.Write("> ");
                customerAccountLoadRequest.level_options = Console.ReadLine();

                Console.WriteLine("Enter the Years of Option");
                Console.Write("> ");
                String? YOS = Console.ReadLine();
                customerAccountLoadRequest.years_options = config.ParseNullableByte(YOS);

                Console.WriteLine("Enter the Account of the firms");
                Console.Write("> ");
                customerAccountLoadRequest.acct_oth_firms = Console.ReadLine();

                Console.WriteLine("Enter the Dir shr dec");
                Console.Write("> ");
                customerAccountLoadRequest.dir_shr_dec = Console.ReadLine();

                Console.WriteLine("Enter the Margin on the file");
                Console.Write("> ");
                customerAccountLoadRequest.mrgn_on_file = Console.ReadLine();

                Console.WriteLine("Enter the option on the file");
                Console.Write("> ");
                customerAccountLoadRequest.optn_on_file = Console.ReadLine();

                Console.WriteLine("Enter the Average Price");
                Console.Write("> ");
                customerAccountLoadRequest.avg_price = Console.ReadLine();

                Console.WriteLine("Enter the Program Trading");
                Console.Write("> ");
                customerAccountLoadRequest.prg_trading = Console.ReadLine();

                Console.WriteLine("Enter the Index Arbitrage");
                Console.Write("> ");
                customerAccountLoadRequest.index_arbitrage = Console.ReadLine();

                Console.WriteLine("Enter the Bill Source Level");
                Console.Write("> ");
                customerAccountLoadRequest.bill_srvc_lvl = Console.ReadLine();

                Console.WriteLine("Enter the Div Reinv");
                Console.Write("> ");
                customerAccountLoadRequest.div_reinv = Console.ReadLine();

                Console.WriteLine("Enter the In Account Number");
                Console.Write("> ");
                customerAccountLoadRequest.in_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the Out Account Number");
                Console.Write("> ");
                customerAccountLoadRequest.office = Console.ReadLine();

                Console.WriteLine("Enter the Social secuirty Number Type");
                Console.Write("> ");
                customerAccountLoadRequest.ssn_type = Console.ReadLine();

                Console.WriteLine("Enter the GIIN");
                Console.Write("> ");
                customerAccountLoadRequest.giin = Console.ReadLine();

                Console.WriteLine("Enter the Federal Tax Number");
                Console.Write("> ");
                customerAccountLoadRequest.ftn = Console.ReadLine();

                Console.WriteLine("Enter the FDID");
                Console.Write("> ");
                customerAccountLoadRequest.FDID = Console.ReadLine();

                #endregion "cust_profile fields"

                #region "cust_details fields"
                Console.WriteLine("Enter the Salute");
                Console.Write("> ");
                customerAccountLoadRequest.salute = Console.ReadLine();

                Console.WriteLine("Enter the Contact FirstName");
                Console.Write("> ");
                customerAccountLoadRequest.contactf = Console.ReadLine();

                Console.WriteLine("Enter the Contact Lastname");
                Console.Write("> ");
                customerAccountLoadRequest.contactl = Console.ReadLine();

                Console.WriteLine("Enter the Initial");
                Console.Write("> ");
                customerAccountLoadRequest.m_initial = Console.ReadLine();

                Console.WriteLine("Enter the W8W9");
                Console.Write("> ");
                customerAccountLoadRequest.w8w9 = Console.ReadLine();

                Console.WriteLine("Enter the W8W9 Type");
                Console.Write("> ");
                customerAccountLoadRequest.w8w9type = Console.ReadLine();

                Console.WriteLine("Enter the W8 Record Code");
                Console.Write("> ");
                customerAccountLoadRequest.w8rec_cd = Console.ReadLine();

                Console.WriteLine("Enter the Backup Withold");
                Console.Write("> ");
                customerAccountLoadRequest.bkup_withhold = Console.ReadLine();

                Console.WriteLine("Enter the Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.add1 = Console.ReadLine();

                Console.WriteLine("Enter the Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.add2 = Console.ReadLine();

                Console.WriteLine("Enter the Address 3");
                Console.Write("> ");
                customerAccountLoadRequest.add3 = Console.ReadLine();

                Console.WriteLine("Enter the City");
                Console.Write("> ");
                customerAccountLoadRequest.city = Console.ReadLine();

                Console.WriteLine("Enter the State Code");
                Console.Write("> ");
                customerAccountLoadRequest.st_cd = Console.ReadLine();

                Console.WriteLine("Enter the ZIP");
                Console.Write("> ");
                customerAccountLoadRequest.zip = Console.ReadLine();

                Console.WriteLine("Enter the Country");
                Console.Write("> ");
                customerAccountLoadRequest.country = Console.ReadLine();

                Console.WriteLine("Enter the phone");
                Console.Write("> ");
                customerAccountLoadRequest.phone = Console.ReadLine();

                Console.WriteLine("Enter the Fax");
                Console.Write("> ");
                customerAccountLoadRequest.fax = Console.ReadLine();

                Console.WriteLine("Enter the Email");
                Console.Write("> ");
                customerAccountLoadRequest.email = Console.ReadLine();

                Console.WriteLine("Enter the Citizenship");
                Console.Write("> ");
                customerAccountLoadRequest.citizenship = Console.ReadLine();

                Console.WriteLine("Enter the Tax Country");
                Console.Write("> ");
                customerAccountLoadRequest.tax_country = Console.ReadLine();

                Console.WriteLine("Enter the Mail Flag");
                Console.Write("> ");
                customerAccountLoadRequest.mail_flg = Console.ReadLine();

                Console.WriteLine("Enter the Mail Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.mail_add1 = Console.ReadLine();

                Console.WriteLine("Enter the Mail Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.mail_add2 = Console.ReadLine();

                Console.WriteLine("Enter the Mail Address 3");
                Console.Write("> ");
                customerAccountLoadRequest.mail_add3 = Console.ReadLine();

                Console.WriteLine("Enter the Mail City");
                Console.Write("> ");
                customerAccountLoadRequest.mail_city = Console.ReadLine();

                Console.WriteLine("Enter the Mail State Code");
                Console.Write("> ");
                customerAccountLoadRequest.mail_st_cd = Console.ReadLine();

                Console.WriteLine("Enter the Mail Zip");
                Console.Write("> ");
                customerAccountLoadRequest.mail_zip = Console.ReadLine();

                Console.WriteLine("Enter the Mail Country");
                Console.Write("> ");
                customerAccountLoadRequest.mail_country = Console.ReadLine();

                Console.WriteLine("Enter the Custodian");
                Console.Write("> ");
                customerAccountLoadRequest.custodian = Console.ReadLine();

                Console.WriteLine("Enter the Guarantee");
                Console.Write("> ");
                customerAccountLoadRequest.guarantee = Console.ReadLine();

                Console.WriteLine("Enter the Employer Name");
                Console.Write("> ");
                customerAccountLoadRequest.employer = Console.ReadLine();

                Console.WriteLine("Enter the Employer Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.emp_add1 = Console.ReadLine();

                Console.WriteLine("Enter the Employer Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.emp_add2 = Console.ReadLine();

                Console.WriteLine("Enter the Employer Address 3");
                Console.Write("> ");
                customerAccountLoadRequest.emp_add3 = Console.ReadLine();

                Console.WriteLine("Enter the Credit Adjustment");
                Console.Write("> ");
                String? CAS = Console.ReadLine();
                customerAccountLoadRequest.credit_adj = config.ParseNullableDecimal(CAS);

                Console.WriteLine("Enter the Debit Adjustment");
                Console.Write("> ");
                String? DAS = Console.ReadLine();
                customerAccountLoadRequest.debit_adj = config.ParseNullableDecimal(DAS);

                Console.WriteLine("Enter the Joint Name");
                Console.Write("> ");
                customerAccountLoadRequest.jt_name = Console.ReadLine();

                Console.WriteLine("Enter the Joint FirstName");
                Console.Write("> ");
                customerAccountLoadRequest.jt_fname = Console.ReadLine();

                Console.WriteLine("Enter the Joint Initial");
                Console.Write("> ");
                customerAccountLoadRequest.jt_m_initial = Console.ReadLine();

                Console.WriteLine("Enter the Joint Last Name");
                Console.Write("> ");
                customerAccountLoadRequest.jt_lname = Console.ReadLine();

                Console.WriteLine("Enter the Joint Social Security NUmber");
                Console.Write("> ");
                customerAccountLoadRequest.jt_ssn = Console.ReadLine();

                Console.WriteLine("Enter the Joint MNR relation");
                Console.Write("> ");
                customerAccountLoadRequest.jt_mnr_relation = Console.ReadLine();

                Console.WriteLine("Enter the Joint MNR DOB");
                Console.Write("> ");
                String? JTDOB = Console.ReadLine();
                customerAccountLoadRequest.jt_mnr_dob = config.ParseNullableDateTime(JTDOB);

                Console.WriteLine("Enter the Joint MNR Citizen");
                Console.Write("> ");
                customerAccountLoadRequest.jt_mnr_citizen = Console.ReadLine();

                Console.WriteLine("Enter the Joint MNR w8");
                Console.Write("> ");
                customerAccountLoadRequest.jt_mnr_w8 = Console.ReadLine();

                Console.WriteLine("Enter the Joint Employer Name");
                Console.Write("> ");
                customerAccountLoadRequest.jt_empr_name = Console.ReadLine();

                Console.WriteLine("Enter the Joint Employer Address");
                Console.Write("> ");
                customerAccountLoadRequest.jt_empr_addr = Console.ReadLine();

                Console.WriteLine("Enter the Other Firms");
                Console.Write("> ");
                customerAccountLoadRequest.oth_firms = Console.ReadLine();

                Console.WriteLine("Enter the Dir SHR Dec");
                Console.Write("> ");
                customerAccountLoadRequest.dir_shr_dec_dtl = Console.ReadLine();

                Console.WriteLine("Enter the CPA Name");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_name = Console.ReadLine();

                Console.WriteLine("Enter the CPA Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_addr1 = Console.ReadLine();

                Console.WriteLine("Enter the CPA Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_addr2 = Console.ReadLine();

                Console.WriteLine("Enter the CPA Phone");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_phone = Console.ReadLine();

                Console.WriteLine("Enter the CPA Email");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_email = Console.ReadLine();

                Console.WriteLine("Enter the CPA Contact");
                Console.Write("> ");
                customerAccountLoadRequest.contact_cpa = Console.ReadLine();

                Console.WriteLine("Enter the Att NAme");
                Console.Write("> ");
                customerAccountLoadRequest.att_name = Console.ReadLine();

                Console.WriteLine("Enter the Att Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.att_addr1 = Console.ReadLine();

                Console.WriteLine("Enter the Att Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.att_addr2 = Console.ReadLine();

                Console.WriteLine("Enter the Att Email");
                Console.Write("> ");
                customerAccountLoadRequest.att_email = Console.ReadLine();

                Console.WriteLine("Enter the ATT Contact");
                Console.Write("> ");
                customerAccountLoadRequest.contact_att = Console.ReadLine();

                Console.WriteLine("Enter the ID Type");
                Console.Write("> ");
                customerAccountLoadRequest.id_type = Console.ReadLine();

                Console.WriteLine("Enter the ID Number");
                Console.Write("> ");
                customerAccountLoadRequest.id_num = Console.ReadLine();

                Console.WriteLine("Enter the ID Place");
                Console.Write("> ");
                customerAccountLoadRequest.id_place = Console.ReadLine();

                Console.WriteLine("Enter the Annual Income");
                Console.Write("> ");
                String? AIS = Console.ReadLine();
                customerAccountLoadRequest.annual_inc = config.ParseNullableInt(AIS);

                Console.WriteLine("Enter the Net Worth");
                Console.Write("> ");
                String? NWS = Console.ReadLine();
                customerAccountLoadRequest.net_worth = config.ParseNullableInt(NWS);

                Console.WriteLine("Enter the Liquid Net worth");
                Console.Write("> ");
                String? LNWS = Console.ReadLine();
                customerAccountLoadRequest.net_worth_liq = config.ParseNullableInt(LNWS);


                Console.WriteLine("Enter the Post pl");
                Console.Write("> ");
                customerAccountLoadRequest.post_pl = Console.ReadLine();

                Console.WriteLine("Enter the Sweep mny market");
                Console.Write("> ");
                customerAccountLoadRequest.sweep_mny_mkt = Console.ReadLine();

                Console.WriteLine("Enter the Cr_int Rate");
                Console.Write("> ");
                String? crintrates = Console.ReadLine();
                customerAccountLoadRequest.cr_int_rate = config.ParseNullableDecimal(crintrates);


                Console.WriteLine("Enter the DB_int Rate");
                Console.Write("> ");
                String? dbintrates = Console.ReadLine();
                customerAccountLoadRequest.db_int_rate = config.ParseNullableDecimal(dbintrates);

                Console.WriteLine("Enter the Tefra");
                Console.Write("> ");
                customerAccountLoadRequest.tefra = Console.ReadLine();

                Console.WriteLine("Enter the Dtbp Ratio");
                Console.Write("> ");
                String? dtbps = Console.ReadLine();
                customerAccountLoadRequest.dtbp_ratio = config.ParseNullableDecimal(dtbps);

                Console.WriteLine("Enter the PM Dtbp Ratio");
                Console.Write("> ");
                String? PMdtbps = Console.ReadLine();
                customerAccountLoadRequest.pm_dtbp_ratio = config.ParseNullableDecimal(PMdtbps);

                Console.WriteLine("Enter the Option level");
                Console.Write("> ");
                customerAccountLoadRequest.optn_level = Console.ReadLine();

                Console.WriteLine("Enter the Start date");
                Console.Write("> ");
                String? StartDateS = Console.ReadLine();
                customerAccountLoadRequest.start_dt = config.ParseNullableDateTime(StartDateS);

                Console.WriteLine("Enter the OPT Designator");
                Console.Write("> ");
                customerAccountLoadRequest.opt_designator = Console.ReadLine();

                Console.WriteLine("Enter the EQ Clear Process Ind");
                Console.Write("> ");
                customerAccountLoadRequest.eq_clear_process_ind = Console.ReadLine();

                Console.WriteLine("Enter the OPT Clear Process Ind");
                Console.Write("> ");
                customerAccountLoadRequest.opt_clear_process_ind = Console.ReadLine();

                Console.WriteLine("Enter the MF Clear Process Ind");
                Console.Write("> ");
                customerAccountLoadRequest.mf_clear_process_ind = Console.ReadLine();

                Console.WriteLine("Enter the FI Clear Process Ind");
                Console.Write("> ");
                customerAccountLoadRequest.fi_clear_process_ind = Console.ReadLine();

                Console.WriteLine("Enter the Fed_l_rate");
                Console.Write("> ");
                String? fedlrates = Console.ReadLine();
                customerAccountLoadRequest.fed_l_rate = config.ParseNullableDecimal(fedlrates);

                Console.WriteLine("Enter the Fed_s_rate");
                Console.Write("> ");
                String? fedsrates = Console.ReadLine();
                customerAccountLoadRequest.fed_s_rate = config.ParseNullableDecimal(fedsrates);

                Console.WriteLine("Enter the Exchange l rate");
                Console.Write("> ");
                String? exclrate = Console.ReadLine();
                customerAccountLoadRequest.exch_l_rate = config.ParseNullableDecimal(exclrate);

                Console.WriteLine("Enter the Exchange S rate");
                Console.Write("> ");
                String? excsrate = Console.ReadLine();
                customerAccountLoadRequest.exch_s_rate = config.ParseNullableDecimal(excsrate);

                Console.WriteLine("Enter the House l rate");
                Console.Write("> ");
                String? houslrate = Console.ReadLine();
                customerAccountLoadRequest.house_l_rate = config.ParseNullableDecimal(houslrate);

                Console.WriteLine("Enter the House S rate");
                Console.Write("> ");
                String? houssrate = Console.ReadLine();
                customerAccountLoadRequest.house_s_rate = config.ParseNullableDecimal(houssrate);

                Console.WriteLine("Enter the Statement Mail");
                Console.Write("> ");
                customerAccountLoadRequest.stmnt_mail = Console.ReadLine();

                Console.WriteLine("Enter the Statement Copy");
                Console.Write("> ");
                String? StCS = Console.ReadLine();
                customerAccountLoadRequest.stmnt_copy = config.ParseNullableByte(StCS);

                Console.WriteLine("Enter the Confirm MAil");
                Console.Write("> ");
                customerAccountLoadRequest.cnfrm_mail = Console.ReadLine();

                Console.WriteLine("Enter the Confirm Copy");
                Console.Write("> ");
                String? ConCS = Console.ReadLine();
                customerAccountLoadRequest.cnfrm_copy = config.ParseNullableByte(ConCS);

                Console.WriteLine("Enter the Proxy OPTOUT");
                Console.Write("> ");
                customerAccountLoadRequest.proxy_optout = Console.ReadLine();

                Console.WriteLine("Enter the lei");
                Console.Write("> ");
                customerAccountLoadRequest.lei = Console.ReadLine();

                Console.WriteLine("Enter the ltid_1");
                Console.Write("> ");
                customerAccountLoadRequest.ltid_1 = Console.ReadLine();

                Console.WriteLine("Enter the ltid_2");
                Console.Write("> ");
                customerAccountLoadRequest.ltid_2 = Console.ReadLine();

                Console.WriteLine("Enter the ltid_3");
                Console.Write("> ");
                customerAccountLoadRequest.ltid_3 = Console.ReadLine();

                Console.WriteLine("Enter the marigin ltid");
                Console.Write("> ");
                customerAccountLoadRequest.mltid = Console.ReadLine();

                Console.WriteLine("Enter the Trading Limit");
                Console.Write("> ");
                String? tls = Console.ReadLine();
                customerAccountLoadRequest.trading_limit = config.ParseNullableDecimal(tls);

                Console.WriteLine("Enter the Rule 2111");
                Console.Write("> ");
                customerAccountLoadRequest.rule_2111 = Console.ReadLine();

                Console.WriteLine("Enter the Business Type");
                Console.Write("> ");
                customerAccountLoadRequest.business_type = Console.ReadLine();

                Console.WriteLine("Enter the Fixed Income level");
                Console.Write("> ");
                customerAccountLoadRequest.level_fixedinc = Console.ReadLine();

                Console.WriteLine("Enter the Fixed Income Years");
                Console.Write("> ");
                String? FIYS = Console.ReadLine();
                customerAccountLoadRequest.years_fixedinc = config.ParseNullableByte(FIYS);

                Console.WriteLine("Enter the Time Horizon");
                Console.Write("> ");
                customerAccountLoadRequest.time_horizon = Console.ReadLine();

                Console.WriteLine("Enter the liquid Needs");
                Console.Write("> ");
                customerAccountLoadRequest.liq_needs = Console.ReadLine();

                Console.WriteLine("Enter the Sweep Destination");
                Console.Write("> ");
                customerAccountLoadRequest.sweep_dest = Console.ReadLine();

                Console.WriteLine("Enter the Sweep SYM");
                Console.Write("> ");
                customerAccountLoadRequest.sweep_sym = Console.ReadLine();

                Console.WriteLine("Enter the Ho min equity");
                Console.Write("> ");
                String? HMES = Console.ReadLine();
                customerAccountLoadRequest.ho_min_equity = config.ParseNullableDecimal(HMES);

                Console.WriteLine("Enter the Tax Blend rate");
                Console.Write("> ");
                String? TBRS = Console.ReadLine();
                customerAccountLoadRequest.tax_blend_rate = config.ParseNullableDecimal(TBRS);

                Console.WriteLine("Enter the Deceased date");
                Console.Write("> ");
                String? decDateS = Console.ReadLine();
                customerAccountLoadRequest.deceased_dt = config.ParseNullableDateTime(decDateS);

                Console.WriteLine("Enter the Account Close date");
                Console.Write("> ");
                String? ACDateS = Console.ReadLine();
                customerAccountLoadRequest.acct_close_dt = config.ParseNullableDateTime(ACDateS);

                Console.WriteLine("Enter the fi_fed_l_rate");
                Console.Write("> ");
                String? fifedls = Console.ReadLine();
                customerAccountLoadRequest.fi_fed_l_rate = config.ParseNullableDecimal(fifedls);

                Console.WriteLine("Enter the fi_fed_s_rate");
                Console.Write("> ");
                String? fifedlss = Console.ReadLine();
                customerAccountLoadRequest.fi_fed_s_rate = config.ParseNullableDecimal(fifedlss);

                Console.WriteLine("Enter the fi_exch_l_rate");
                Console.Write("> ");
                String? fiexhls = Console.ReadLine();
                customerAccountLoadRequest.fi_exch_l_rate = config.ParseNullableDecimal(fiexhls);

                Console.WriteLine("Enter the fi_exch_s_rate");
                Console.Write("> ");
                String? fiexhss = Console.ReadLine();
                customerAccountLoadRequest.fi_exch_s_rate = config.ParseNullableDecimal(fiexhss);

                Console.WriteLine("Enter the fi_house_l_rate");
                Console.Write("> ");
                String? fhols = Console.ReadLine();
                customerAccountLoadRequest.fi_house_l_rate = config.ParseNullableDecimal(fhols);

                Console.WriteLine("Enter the fi_house_s_rate");
                Console.Write("> ");
                String? fhsr = Console.ReadLine();
                customerAccountLoadRequest.fi_house_s_rate = config.ParseNullableDecimal(fhsr);

                Console.WriteLine("Enter the ira_distrb_amt");
                Console.Write("> ");
                String? irdias = Console.ReadLine();
                customerAccountLoadRequest.ira_distrb_amt = config.ParseNullableDecimal(irdias);

                Console.WriteLine("Enter the ira_fed_tax");
                Console.Write("> ");
                String? ifedts = Console.ReadLine();
                customerAccountLoadRequest.ira_fed_tax = config.ParseNullableDecimal(ifedts);

                Console.WriteLine("Enter the ira_state_tax");
                Console.Write("> ");
                String? istatts = Console.ReadLine();
                customerAccountLoadRequest.ira_state_tax = config.ParseNullableDecimal(istatts);



                Console.WriteLine("Enter the IR Period");
                Console.Write("> ");
                customerAccountLoadRequest.ira_period = Console.ReadLine();

                Console.WriteLine("Enter the IRA State code");
                Console.Write("> ");
                customerAccountLoadRequest.ira_st_cd = Console.ReadLine();

                Console.WriteLine("Enter the sh_seg_offset");
                Console.Write("> ");
                customerAccountLoadRequest.sh_seg_offset = Console.ReadLine();

                Console.WriteLine("Enter the escrow_acct_type");
                Console.Write("> ");
                customerAccountLoadRequest.escrow_acct_type = Console.ReadLine();

                Console.WriteLine("Enter the mail_irs_forms");
                Console.Write("> ");
                customerAccountLoadRequest.mail_irs_forms = Console.ReadLine();

                Console.WriteLine("Enter the intraday_cnfrm");
                Console.Write("> ");
                customerAccountLoadRequest.intraday_cnfrm = Console.ReadLine();

                Console.WriteLine("Enter the intraday_emails");
                Console.Write("> ");
                customerAccountLoadRequest.intraday_emails = Console.ReadLine();

                Console.WriteLine("Enter the intraday_fax");
                Console.Write("> ");
                customerAccountLoadRequest.salute = Console.ReadLine();

                Console.WriteLine("Enter the intraday_fax");
                Console.Write("> ");
                customerAccountLoadRequest.salute = Console.ReadLine();

                Console.WriteLine("Enter the Employee Status");
                Console.Write("> ");
                customerAccountLoadRequest.emp_status = Console.ReadLine();

                Console.WriteLine("Enter the Employee Title");
                Console.Write("> ");
                customerAccountLoadRequest.emp_title = Console.ReadLine();

                Console.WriteLine("Enter the Joint Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.jt_add1 = Console.ReadLine();

                Console.WriteLine("Enter the Joint Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.jt_add2 = Console.ReadLine();

                Console.WriteLine("Enter the Joint Address 3");
                Console.Write("> ");
                customerAccountLoadRequest.jt_add3 = Console.ReadLine();

                Console.WriteLine("Enter the Joint City");
                Console.Write("> ");
                customerAccountLoadRequest.jt_city = Console.ReadLine();

                Console.WriteLine("Enter the Joint State code");
                Console.Write("> ");
                customerAccountLoadRequest.jt_st_cd = Console.ReadLine();

                Console.WriteLine("Enter the Joint Zip");
                Console.Write("> ");
                customerAccountLoadRequest.jt_zip = Console.ReadLine();

                Console.WriteLine("Enter the Joint Country");
                Console.Write("> ");
                customerAccountLoadRequest.jt_country = Console.ReadLine();

                Console.WriteLine("Enter the Joint Employer Status");
                Console.Write("> ");
                customerAccountLoadRequest.jt_empr_status = Console.ReadLine();

                Console.WriteLine("Enter the Joint Employee Title");
                Console.Write("> ");
                customerAccountLoadRequest.jt_empr_title = Console.ReadLine();

                Console.WriteLine("Enter the Trust date");
                Console.Write("> ");
                String? trustDateS = Console.ReadLine();
                customerAccountLoadRequest.trust_dt = config.ParseNullableDateTime(trustDateS);


                Console.WriteLine("Enter the Trust Net Income");
                Console.Write("> ");
                String? tnis = Console.ReadLine();
                customerAccountLoadRequest.trust_net_inc = config.ParseNullableInt(tnis);

                Console.WriteLine("Enter the Trust liquid Net Worth");
                Console.Write("> ");
                String? tlNWS = Console.ReadLine();
                customerAccountLoadRequest.trust_net_liq = config.ParseNullableInt(tlNWS);

                Console.WriteLine("Enter the oth_brk_emp");
                Console.Write("> ");
                customerAccountLoadRequest.oth_brk_emp = Console.ReadLine();

                Console.WriteLine("Enter the valid_w8w9");
                Console.Write("> ");
                customerAccountLoadRequest.valid_w8w9 = Console.ReadLine();

                Console.WriteLine("Enter the fatca");
                Console.Write("> ");
                customerAccountLoadRequest.fatca = Console.ReadLine();

                Console.WriteLine("Enter the Override Rate");
                Console.Write("> ");
                String? ORRS = Console.ReadLine();
                customerAccountLoadRequest.override_rate = config.ParseNullableDecimal(tlNWS);


                Console.WriteLine("Enter the rpt_8966");
                Console.Write("> ");
                customerAccountLoadRequest.rpt_8966 = Console.ReadLine();

                Console.WriteLine("Enter the tax_type_ch4");
                Console.Write("> ");
                customerAccountLoadRequest.tax_type_ch4 = Console.ReadLine();

                Console.WriteLine("Enter the w8_ch3");
                Console.Write("> ");
                customerAccountLoadRequest.w8_ch3 = Console.ReadLine();

                Console.WriteLine("Enter the w8_ch4");
                Console.Write("> ");
                customerAccountLoadRequest.w8_ch4 = Console.ReadLine();

                Console.WriteLine("Enter the w8_pool");
                Console.Write("> ");
                customerAccountLoadRequest.w8_pool = Console.ReadLine();

                Console.WriteLine("Enter the w8_lob");
                Console.Write("> ");
                customerAccountLoadRequest.w8_lob = Console.ReadLine();

                Console.WriteLine("Enter the w8_income");
                Console.Write("> ");
                customerAccountLoadRequest.w8_income = Console.ReadLine();

                Console.WriteLine("Enter the w8_exempt");
                Console.Write("> ");
                customerAccountLoadRequest.w8_exempt = Console.ReadLine();

                Console.WriteLine("Enter the cust_type_2052a");
                Console.Write("> ");
                customerAccountLoadRequest.cust_type_2052a = Console.ReadLine();

                Console.WriteLine("Enter the corp_buyback");
                Console.Write("> ");
                customerAccountLoadRequest.corp_buyback = Console.ReadLine();

                Console.WriteLine("Enter the gdpr_compliant");
                Console.Write("> ");
                customerAccountLoadRequest.gdpr_compliant = Console.ReadLine();

                Console.WriteLine("Enter the firpta_blend_rate");
                Console.Write("> ");
                String? FBRS = Console.ReadLine();
                customerAccountLoadRequest.firpta_blend_rate = config.ParseNullableDecimal(FBRS);

                Console.WriteLine("Enter the add4");
                Console.Write("> ");
                customerAccountLoadRequest.add4 = Console.ReadLine();

                Console.WriteLine("Enter the add5");
                Console.Write("> ");
                customerAccountLoadRequest.add5 = Console.ReadLine();

                #endregion "cust_details fields"


                #region "Additional Fields"
                Console.WriteLine("Enter the Account type");
                Console.Write("> ");
                customerAccountLoadRequest.acct_type = Console.ReadLine();

                Console.WriteLine("Enter the dvp_id_num");
                Console.Write("> ");
                customerAccountLoadRequest.dvp_id_num = Console.ReadLine();

                Console.WriteLine("Enter the act_agent_bk");
                Console.Write("> ");
                customerAccountLoadRequest.act_agent_bk = Console.ReadLine();

                Console.WriteLine("Enter the access_cd");
                Console.Write("> ");
                customerAccountLoadRequest.access_cd = Console.ReadLine();

                Console.WriteLine("Enter the dtcc_num");
                Console.Write("> ");
                customerAccountLoadRequest.dtcc_num = Console.ReadLine();

                Console.WriteLine("Enter the agent_bk");
                Console.Write("> ");
                customerAccountLoadRequest.agent_bk = Console.ReadLine();

                Console.WriteLine("Enter the ip_num_1");
                Console.Write("> ");
                customerAccountLoadRequest.ip_num_1 = Console.ReadLine();

                Console.WriteLine("Enter the ip_account_1");
                Console.Write("> ");
                customerAccountLoadRequest.ip_account_1 = Console.ReadLine();

                Console.WriteLine("Enter the ip_num_2");
                Console.Write("> ");
                customerAccountLoadRequest.ip_num_2 = Console.ReadLine();

                Console.WriteLine("Enter the ip_account_2");
                Console.Write("> ");
                customerAccountLoadRequest.ip_account_2 = Console.ReadLine();

                Console.WriteLine("Enter the sub_acct_no");
                Console.Write("> ");
                customerAccountLoadRequest.sub_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the chgind");
                Console.Write("> ");
                customerAccountLoadRequest.chgind = Console.ReadLine();

                Console.WriteLine("Enter the ip_name1");
                Console.Write("> ");
                customerAccountLoadRequest.ip_name1 = Console.ReadLine();

                Console.WriteLine("Enter the ip_email1");
                Console.Write("> ");
                customerAccountLoadRequest.ip_email1 = Console.ReadLine();

                Console.WriteLine("Enter the ip_name2");
                Console.Write("> ");
                customerAccountLoadRequest.ip_name2 = Console.ReadLine();

                Console.WriteLine("Enter the ip_email2");
                Console.Write("> ");
                customerAccountLoadRequest.ip_email2 = Console.ReadLine();

                Console.WriteLine("Enter the firm_ca_frac");
                Console.Write("> ");
                customerAccountLoadRequest.firm_ca_frac = Console.ReadLine();

                Console.WriteLine("Enter the new_sub");
                Console.Write("> ");
                customerAccountLoadRequest.new_sub = Console.ReadLine();

                Console.WriteLine("Enter the dummy1");
                Console.Write("> ");
                customerAccountLoadRequest.dummy1 = Console.ReadLine();

                Console.WriteLine("Enter the dummy2");
                Console.Write("> ");
                customerAccountLoadRequest.dummy2 = Console.ReadLine();

                #endregion "Additional Fields"


                var dataAsString = JsonConvert.SerializeObject(customerAccountLoadRequest);
                Console.WriteLine(dataAsString);
                var dataContent = new StringContent("[" + dataAsString + "]", Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(config.BASEURL() + "/CustomerAccounts", dataContent);

                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
                    Console.WriteLine("Customer Profile is Added");
                }
                else
                {
                    Console.WriteLine("Statuscode is error");
                    Console.WriteLine(response.Content);

                }


            }
        }



        //Add a Customer Account 
        public static async Task UpdateCustomerAccount()
        {

            using (var client = new HttpClient())
            {

                CustomerAccountLoadRequest customerAccountLoadRequest = new CustomerAccountLoadRequest();
                UrlConfiguration config = new UrlConfiguration();


                #region "cust_profile fields"
                Console.WriteLine("Enter the Correspondent");
                Console.Write("> ");
                customerAccountLoadRequest.corr = Console.ReadLine();

                Console.WriteLine("Enter the Office");
                Console.Write("> ");
                customerAccountLoadRequest.office = Console.ReadLine();

                Console.WriteLine("Enter the Account Number");
                Console.Write("> ");
                customerAccountLoadRequest.acct_no = Console.ReadLine();

                Console.WriteLine("Enter the Account Name");
                Console.Write("> ");
                customerAccountLoadRequest.acct_name = Console.ReadLine();

                Console.WriteLine("Enter the Short Name");
                Console.Write("> ");
                customerAccountLoadRequest.short_name = Console.ReadLine();

                Console.WriteLine("Enter the Port Track");
                Console.Write("> ");
                customerAccountLoadRequest.port_track = Console.ReadLine();

                Console.WriteLine("Enter the Designator");
                Console.Write("> ");
                customerAccountLoadRequest.designator = Console.ReadLine();

                Console.WriteLine("Enter the cost of Designator");
                Console.Write("> ");
                customerAccountLoadRequest.cost_desig = Console.ReadLine();

                Console.WriteLine("Enter the Tax Lot");
                Console.Write("> ");
                customerAccountLoadRequest.tax_lot = Console.ReadLine();

                Console.WriteLine("Enter the Capacity");
                Console.Write("> ");
                customerAccountLoadRequest.capacity = Console.ReadLine();

                Console.WriteLine("Enter the Sold & Unsold");
                Console.Write("> ");
                customerAccountLoadRequest.sol_unsol = Console.ReadLine();

                Console.WriteLine("Enter the RR Code");
                Console.Write("> ");
                customerAccountLoadRequest.rr_cd = Console.ReadLine();

                Console.WriteLine("Enter the AD code");
                Console.Write("> ");
                customerAccountLoadRequest.ad_cd = Console.ReadLine();

                Console.WriteLine("Enter the AN code");
                Console.Write("> ");
                customerAccountLoadRequest.an_cd = Console.ReadLine();

                Console.WriteLine("Enter the PM code");
                Console.Write("> ");
                customerAccountLoadRequest.pm_cd = Console.ReadLine();

                Console.WriteLine("Enter the Account Group Code");
                Console.Write("> ");
                customerAccountLoadRequest.ac_grp_cd = Console.ReadLine();

                Console.WriteLine("Enter the Currency");
                Console.Write("> ");
                customerAccountLoadRequest.currency = Console.ReadLine();

                Console.WriteLine("Enter the Legal Entity");
                Console.Write("> ");
                customerAccountLoadRequest.legal_entity = Console.ReadLine();

                Console.WriteLine("Enter the Classification");
                Console.Write("> ");
                customerAccountLoadRequest.classification = Console.ReadLine();

                Console.WriteLine("Enter the Social Security Number");
                Console.Write("> ");
                customerAccountLoadRequest.ssn = Console.ReadLine();

                Console.WriteLine("Enter the Security Charge");
                Console.Write("> ");
                customerAccountLoadRequest.sec_charge = Console.ReadLine();

                Console.WriteLine("Enter the CA Fraction");
                Console.Write("> ");
                customerAccountLoadRequest.ca_frac = Console.ReadLine();

                Console.WriteLine("Enter the W8 date");
                Console.Write("> ");
                String? SDT = Console.ReadLine();
                customerAccountLoadRequest.w8_dt = config.ParseNullableDateTime(SDT);

                Console.WriteLine("Enter the Employee");
                Console.Write("> ");
                customerAccountLoadRequest.employee = Console.ReadLine();

                Console.WriteLine("Enter the Firm of the Employee");
                Console.Write("> ");
                customerAccountLoadRequest.employee = Console.ReadLine();

                Console.WriteLine("Enter the Marital Status");
                Console.Write("> ");
                customerAccountLoadRequest.marital_status = Console.ReadLine();

                Console.WriteLine("Enter Number of Dependants ");
                Console.Write("> ");
                String? dependants = Console.ReadLine();
                customerAccountLoadRequest.dependants = config.ParseNullableByte(dependants);

                Console.WriteLine("Enter the Date of Birth");
                Console.Write("> ");
                String? DOBS = Console.ReadLine();
                customerAccountLoadRequest.dob = config.ParseNullableDateTime(DOBS);

                Console.WriteLine("Enter the Nasd of Employee");
                Console.Write("> ");
                customerAccountLoadRequest.nasd_emp = Console.ReadLine();

                Console.WriteLine("Enter the Nasd of Spouse");
                Console.Write("> ");
                customerAccountLoadRequest.nasd_spouse = Console.ReadLine();

                Console.WriteLine("Enter the Larger Trader ID");
                Console.Write("> ");
                customerAccountLoadRequest.large_trader_id = Console.ReadLine();

                Console.WriteLine("Enter the Reason for Inactive");
                Console.Write("> ");
                customerAccountLoadRequest.inactive_reason = Console.ReadLine();

                Console.WriteLine("Enter the Start Date");
                Console.Write("> ");
                String? StDt = Console.ReadLine();
                customerAccountLoadRequest.stat_st_dt = config.ParseNullableDateTime(StDt);

                Console.WriteLine("Enter the End Date");
                Console.Write("> ");
                String? EtDt = Console.ReadLine();
                customerAccountLoadRequest.stat_en_dt = config.ParseNullableDateTime(EtDt);

                Console.WriteLine("Enter the INV objective");
                Console.Write("> ");
                customerAccountLoadRequest.inv_objective = Console.ReadLine();

                Console.WriteLine("Enter the Risk Tolerance");
                Console.Write("> ");
                customerAccountLoadRequest.risk_tolerence = Console.ReadLine();

                Console.WriteLine("Enter the Financial Data");
                Console.Write("> ");
                customerAccountLoadRequest.fncl_data = Console.ReadLine();

                Console.WriteLine("Enter the JT Financial Data");
                Console.Write("> ");
                customerAccountLoadRequest.jt_fncl_data = Console.ReadLine();

                Console.WriteLine("Enter the Tax Bracket");
                Console.Write("> ");
                String? TBS = Console.ReadLine();
                customerAccountLoadRequest.tax_bracket = config.ParseNullableByte(TBS);

                Console.WriteLine("Enter the Stock Level");
                Console.Write("> ");
                customerAccountLoadRequest.level_stocks = Console.ReadLine();

                Console.WriteLine("Enter the Stock Year");
                Console.Write("> ");
                String? STYS = Console.ReadLine();
                customerAccountLoadRequest.years_stocks = config.ParseNullableByte(STYS);

                Console.WriteLine("Enter the Option Level");
                Console.Write("> ");
                customerAccountLoadRequest.level_options = Console.ReadLine();

                Console.WriteLine("Enter the Years of Option");
                Console.Write("> ");
                String? YOS = Console.ReadLine();
                customerAccountLoadRequest.years_options = config.ParseNullableByte(YOS);

                Console.WriteLine("Enter the Account of the firms");
                Console.Write("> ");
                customerAccountLoadRequest.acct_oth_firms = Console.ReadLine();

                Console.WriteLine("Enter the Dir shr dec");
                Console.Write("> ");
                customerAccountLoadRequest.dir_shr_dec = Console.ReadLine();

                Console.WriteLine("Enter the Margin on the file");
                Console.Write("> ");
                customerAccountLoadRequest.mrgn_on_file = Console.ReadLine();

                Console.WriteLine("Enter the option on the file");
                Console.Write("> ");
                customerAccountLoadRequest.optn_on_file = Console.ReadLine();

                Console.WriteLine("Enter the Average Price");
                Console.Write("> ");
                customerAccountLoadRequest.avg_price = Console.ReadLine();

                Console.WriteLine("Enter the Program Trading");
                Console.Write("> ");
                customerAccountLoadRequest.prg_trading = Console.ReadLine();

                Console.WriteLine("Enter the Index Arbitrage");
                Console.Write("> ");
                customerAccountLoadRequest.index_arbitrage = Console.ReadLine();

                Console.WriteLine("Enter the Bill Source Level");
                Console.Write("> ");
                customerAccountLoadRequest.bill_srvc_lvl = Console.ReadLine();

                Console.WriteLine("Enter the Div Reinv");
                Console.Write("> ");
                customerAccountLoadRequest.div_reinv = Console.ReadLine();

                Console.WriteLine("Enter the In Account Number");
                Console.Write("> ");
                customerAccountLoadRequest.in_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the Out Account Number");
                Console.Write("> ");
                customerAccountLoadRequest.office = Console.ReadLine();

                Console.WriteLine("Enter the Social secuirty Number Type");
                Console.Write("> ");
                customerAccountLoadRequest.ssn_type = Console.ReadLine();

                Console.WriteLine("Enter the GIIN");
                Console.Write("> ");
                customerAccountLoadRequest.giin = Console.ReadLine();

                Console.WriteLine("Enter the Federal Tax Number");
                Console.Write("> ");
                customerAccountLoadRequest.ftn = Console.ReadLine();

                Console.WriteLine("Enter the FDID");
                Console.Write("> ");
                customerAccountLoadRequest.FDID = Console.ReadLine();

                #endregion "cust_profile fields"

                #region "cust_details fields"
                Console.WriteLine("Enter the Salute");
                Console.Write("> ");
                customerAccountLoadRequest.salute = Console.ReadLine();

                Console.WriteLine("Enter the Contact FirstName");
                Console.Write("> ");
                customerAccountLoadRequest.contactf = Console.ReadLine();

                Console.WriteLine("Enter the Contact Lastname");
                Console.Write("> ");
                customerAccountLoadRequest.contactl = Console.ReadLine();

                Console.WriteLine("Enter the Initial");
                Console.Write("> ");
                customerAccountLoadRequest.m_initial = Console.ReadLine();

                Console.WriteLine("Enter the W8W9");
                Console.Write("> ");
                customerAccountLoadRequest.w8w9 = Console.ReadLine();

                Console.WriteLine("Enter the W8W9 Type");
                Console.Write("> ");
                customerAccountLoadRequest.w8w9type = Console.ReadLine();

                Console.WriteLine("Enter the W8 Record Code");
                Console.Write("> ");
                customerAccountLoadRequest.w8rec_cd = Console.ReadLine();

                Console.WriteLine("Enter the Backup Withold");
                Console.Write("> ");
                customerAccountLoadRequest.bkup_withhold = Console.ReadLine();

                Console.WriteLine("Enter the Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.add1 = Console.ReadLine();

                Console.WriteLine("Enter the Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.add2 = Console.ReadLine();

                Console.WriteLine("Enter the Address 3");
                Console.Write("> ");
                customerAccountLoadRequest.add3 = Console.ReadLine();

                Console.WriteLine("Enter the City");
                Console.Write("> ");
                customerAccountLoadRequest.city = Console.ReadLine();

                Console.WriteLine("Enter the State Code");
                Console.Write("> ");
                customerAccountLoadRequest.st_cd = Console.ReadLine();

                Console.WriteLine("Enter the ZIP");
                Console.Write("> ");
                customerAccountLoadRequest.zip = Console.ReadLine();

                Console.WriteLine("Enter the Country");
                Console.Write("> ");
                customerAccountLoadRequest.country = Console.ReadLine();

                Console.WriteLine("Enter the phone");
                Console.Write("> ");
                customerAccountLoadRequest.phone = Console.ReadLine();

                Console.WriteLine("Enter the Fax");
                Console.Write("> ");
                customerAccountLoadRequest.fax = Console.ReadLine();

                Console.WriteLine("Enter the Email");
                Console.Write("> ");
                customerAccountLoadRequest.email = Console.ReadLine();

                Console.WriteLine("Enter the Citizenship");
                Console.Write("> ");
                customerAccountLoadRequest.citizenship = Console.ReadLine();

                Console.WriteLine("Enter the Tax Country");
                Console.Write("> ");
                customerAccountLoadRequest.tax_country = Console.ReadLine();

                Console.WriteLine("Enter the Mail Flag");
                Console.Write("> ");
                customerAccountLoadRequest.mail_flg = Console.ReadLine();

                Console.WriteLine("Enter the Mail Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.mail_add1 = Console.ReadLine();

                Console.WriteLine("Enter the Mail Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.mail_add2 = Console.ReadLine();

                Console.WriteLine("Enter the Mail Address 3");
                Console.Write("> ");
                customerAccountLoadRequest.mail_add3 = Console.ReadLine();

                Console.WriteLine("Enter the Mail City");
                Console.Write("> ");
                customerAccountLoadRequest.mail_city = Console.ReadLine();

                Console.WriteLine("Enter the Mail State Code");
                Console.Write("> ");
                customerAccountLoadRequest.mail_st_cd = Console.ReadLine();

                Console.WriteLine("Enter the Mail Zip");
                Console.Write("> ");
                customerAccountLoadRequest.mail_zip = Console.ReadLine();

                Console.WriteLine("Enter the Mail Country");
                Console.Write("> ");
                customerAccountLoadRequest.mail_country = Console.ReadLine();

                Console.WriteLine("Enter the Custodian");
                Console.Write("> ");
                customerAccountLoadRequest.custodian = Console.ReadLine();

                Console.WriteLine("Enter the Guarantee");
                Console.Write("> ");
                customerAccountLoadRequest.guarantee = Console.ReadLine();

                Console.WriteLine("Enter the Employer Name");
                Console.Write("> ");
                customerAccountLoadRequest.employer = Console.ReadLine();

                Console.WriteLine("Enter the Employer Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.emp_add1 = Console.ReadLine();

                Console.WriteLine("Enter the Employer Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.emp_add2 = Console.ReadLine();

                Console.WriteLine("Enter the Employer Address 3");
                Console.Write("> ");
                customerAccountLoadRequest.emp_add3 = Console.ReadLine();

                Console.WriteLine("Enter the Credit Adjustment");
                Console.Write("> ");
                String? CAS = Console.ReadLine();
                customerAccountLoadRequest.credit_adj = config.ParseNullableDecimal(CAS);

                Console.WriteLine("Enter the Debit Adjustment");
                Console.Write("> ");
                String? DAS = Console.ReadLine();
                customerAccountLoadRequest.debit_adj = config.ParseNullableDecimal(DAS);

                Console.WriteLine("Enter the Joint Name");
                Console.Write("> ");
                customerAccountLoadRequest.jt_name = Console.ReadLine();

                Console.WriteLine("Enter the Joint FirstName");
                Console.Write("> ");
                customerAccountLoadRequest.jt_fname = Console.ReadLine();

                Console.WriteLine("Enter the Joint Initial");
                Console.Write("> ");
                customerAccountLoadRequest.jt_m_initial = Console.ReadLine();

                Console.WriteLine("Enter the Joint Last Name");
                Console.Write("> ");
                customerAccountLoadRequest.jt_lname = Console.ReadLine();

                Console.WriteLine("Enter the Joint Social Security NUmber");
                Console.Write("> ");
                customerAccountLoadRequest.jt_ssn = Console.ReadLine();

                Console.WriteLine("Enter the Joint MNR relation");
                Console.Write("> ");
                customerAccountLoadRequest.jt_mnr_relation = Console.ReadLine();

                Console.WriteLine("Enter the Joint MNR DOB");
                Console.Write("> ");
                String? JTDOB = Console.ReadLine();
                customerAccountLoadRequest.jt_mnr_dob = config.ParseNullableDateTime(JTDOB);

                Console.WriteLine("Enter the Joint MNR Citizen");
                Console.Write("> ");
                customerAccountLoadRequest.jt_mnr_citizen = Console.ReadLine();

                Console.WriteLine("Enter the Joint MNR w8");
                Console.Write("> ");
                customerAccountLoadRequest.jt_mnr_w8 = Console.ReadLine();

                Console.WriteLine("Enter the Joint Employer Name");
                Console.Write("> ");
                customerAccountLoadRequest.jt_empr_name = Console.ReadLine();

                Console.WriteLine("Enter the Joint Employer Address");
                Console.Write("> ");
                customerAccountLoadRequest.jt_empr_addr = Console.ReadLine();

                Console.WriteLine("Enter the Other Firms");
                Console.Write("> ");
                customerAccountLoadRequest.oth_firms = Console.ReadLine();

                Console.WriteLine("Enter the Dir SHR Dec");
                Console.Write("> ");
                customerAccountLoadRequest.dir_shr_dec_dtl = Console.ReadLine();

                Console.WriteLine("Enter the CPA Name");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_name = Console.ReadLine();

                Console.WriteLine("Enter the CPA Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_addr1 = Console.ReadLine();

                Console.WriteLine("Enter the CPA Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_addr2 = Console.ReadLine();

                Console.WriteLine("Enter the CPA Phone");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_phone = Console.ReadLine();

                Console.WriteLine("Enter the CPA Email");
                Console.Write("> ");
                customerAccountLoadRequest.cpa_email = Console.ReadLine();

                Console.WriteLine("Enter the CPA Contact");
                Console.Write("> ");
                customerAccountLoadRequest.contact_cpa = Console.ReadLine();

                Console.WriteLine("Enter the Att NAme");
                Console.Write("> ");
                customerAccountLoadRequest.att_name = Console.ReadLine();

                Console.WriteLine("Enter the Att Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.att_addr1 = Console.ReadLine();

                Console.WriteLine("Enter the Att Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.att_addr2 = Console.ReadLine();

                Console.WriteLine("Enter the Att Email");
                Console.Write("> ");
                customerAccountLoadRequest.att_email = Console.ReadLine();

                Console.WriteLine("Enter the ATT Contact");
                Console.Write("> ");
                customerAccountLoadRequest.contact_att = Console.ReadLine();

                Console.WriteLine("Enter the ID Type");
                Console.Write("> ");
                customerAccountLoadRequest.id_type = Console.ReadLine();

                Console.WriteLine("Enter the ID Number");
                Console.Write("> ");
                customerAccountLoadRequest.id_num = Console.ReadLine();

                Console.WriteLine("Enter the ID Place");
                Console.Write("> ");
                customerAccountLoadRequest.id_place = Console.ReadLine();

                Console.WriteLine("Enter the Annual Income");
                Console.Write("> ");
                String? AIS = Console.ReadLine();
                customerAccountLoadRequest.annual_inc = config.ParseNullableInt(AIS);

                Console.WriteLine("Enter the Net Worth");
                Console.Write("> ");
                String? NWS = Console.ReadLine();
                customerAccountLoadRequest.net_worth = config.ParseNullableInt(NWS);

                Console.WriteLine("Enter the Liquid Net worth");
                Console.Write("> ");
                String? LNWS = Console.ReadLine();
                customerAccountLoadRequest.net_worth_liq = config.ParseNullableInt(LNWS);


                Console.WriteLine("Enter the Post pl");
                Console.Write("> ");
                customerAccountLoadRequest.post_pl = Console.ReadLine();

                Console.WriteLine("Enter the Sweep mny market");
                Console.Write("> ");
                customerAccountLoadRequest.sweep_mny_mkt = Console.ReadLine();

                Console.WriteLine("Enter the Cr_int Rate");
                Console.Write("> ");
                String? crintrates = Console.ReadLine();
                customerAccountLoadRequest.cr_int_rate = config.ParseNullableDecimal(crintrates);


                Console.WriteLine("Enter the DB_int Rate");
                Console.Write("> ");
                String? dbintrates = Console.ReadLine();
                customerAccountLoadRequest.db_int_rate = config.ParseNullableDecimal(dbintrates);

                Console.WriteLine("Enter the Tefra");
                Console.Write("> ");
                customerAccountLoadRequest.tefra = Console.ReadLine();

                Console.WriteLine("Enter the Dtbp Ratio");
                Console.Write("> ");
                String? dtbps = Console.ReadLine();
                customerAccountLoadRequest.dtbp_ratio = config.ParseNullableDecimal(dtbps);

                Console.WriteLine("Enter the PM Dtbp Ratio");
                Console.Write("> ");
                String? PMdtbps = Console.ReadLine();
                customerAccountLoadRequest.pm_dtbp_ratio = config.ParseNullableDecimal(PMdtbps);

                Console.WriteLine("Enter the Option level");
                Console.Write("> ");
                customerAccountLoadRequest.optn_level = Console.ReadLine();

                Console.WriteLine("Enter the Start date");
                Console.Write("> ");
                String? StartDateS = Console.ReadLine();
                customerAccountLoadRequest.start_dt = config.ParseNullableDateTime(StartDateS);

                Console.WriteLine("Enter the OPT Designator");
                Console.Write("> ");
                customerAccountLoadRequest.opt_designator = Console.ReadLine();

                Console.WriteLine("Enter the EQ Clear Process Ind");
                Console.Write("> ");
                customerAccountLoadRequest.eq_clear_process_ind = Console.ReadLine();

                Console.WriteLine("Enter the OPT Clear Process Ind");
                Console.Write("> ");
                customerAccountLoadRequest.opt_clear_process_ind = Console.ReadLine();

                Console.WriteLine("Enter the MF Clear Process Ind");
                Console.Write("> ");
                customerAccountLoadRequest.mf_clear_process_ind = Console.ReadLine();

                Console.WriteLine("Enter the FI Clear Process Ind");
                Console.Write("> ");
                customerAccountLoadRequest.fi_clear_process_ind = Console.ReadLine();

                Console.WriteLine("Enter the Fed_l_rate");
                Console.Write("> ");
                String? fedlrates = Console.ReadLine();
                customerAccountLoadRequest.fed_l_rate = config.ParseNullableDecimal(fedlrates);

                Console.WriteLine("Enter the Fed_s_rate");
                Console.Write("> ");
                String? fedsrates = Console.ReadLine();
                customerAccountLoadRequest.fed_s_rate = config.ParseNullableDecimal(fedsrates);

                Console.WriteLine("Enter the Exchange l rate");
                Console.Write("> ");
                String? exclrate = Console.ReadLine();
                customerAccountLoadRequest.exch_l_rate = config.ParseNullableDecimal(exclrate);

                Console.WriteLine("Enter the Exchange S rate");
                Console.Write("> ");
                String? excsrate = Console.ReadLine();
                customerAccountLoadRequest.exch_s_rate = config.ParseNullableDecimal(excsrate);

                Console.WriteLine("Enter the House l rate");
                Console.Write("> ");
                String? houslrate = Console.ReadLine();
                customerAccountLoadRequest.house_l_rate = config.ParseNullableDecimal(houslrate);

                Console.WriteLine("Enter the House S rate");
                Console.Write("> ");
                String? houssrate = Console.ReadLine();
                customerAccountLoadRequest.house_s_rate = config.ParseNullableDecimal(houssrate);

                Console.WriteLine("Enter the Statement Mail");
                Console.Write("> ");
                customerAccountLoadRequest.stmnt_mail = Console.ReadLine();

                Console.WriteLine("Enter the Statement Copy");
                Console.Write("> ");
                String? StCS = Console.ReadLine();
                customerAccountLoadRequest.stmnt_copy = config.ParseNullableByte(StCS);

                Console.WriteLine("Enter the Confirm MAil");
                Console.Write("> ");
                customerAccountLoadRequest.cnfrm_mail = Console.ReadLine();

                Console.WriteLine("Enter the Confirm Copy");
                Console.Write("> ");
                String? ConCS = Console.ReadLine();
                customerAccountLoadRequest.cnfrm_copy = config.ParseNullableByte(ConCS);

                Console.WriteLine("Enter the Proxy OPTOUT");
                Console.Write("> ");
                customerAccountLoadRequest.proxy_optout = Console.ReadLine();

                Console.WriteLine("Enter the lei");
                Console.Write("> ");
                customerAccountLoadRequest.lei = Console.ReadLine();

                Console.WriteLine("Enter the ltid_1");
                Console.Write("> ");
                customerAccountLoadRequest.ltid_1 = Console.ReadLine();

                Console.WriteLine("Enter the ltid_2");
                Console.Write("> ");
                customerAccountLoadRequest.ltid_2 = Console.ReadLine();

                Console.WriteLine("Enter the ltid_3");
                Console.Write("> ");
                customerAccountLoadRequest.ltid_3 = Console.ReadLine();

                Console.WriteLine("Enter the marigin ltid");
                Console.Write("> ");
                customerAccountLoadRequest.mltid = Console.ReadLine();

                Console.WriteLine("Enter the Trading Limit");
                Console.Write("> ");
                String? tls = Console.ReadLine();
                customerAccountLoadRequest.trading_limit = config.ParseNullableDecimal(tls);

                Console.WriteLine("Enter the Rule 2111");
                Console.Write("> ");
                customerAccountLoadRequest.rule_2111 = Console.ReadLine();

                Console.WriteLine("Enter the Business Type");
                Console.Write("> ");
                customerAccountLoadRequest.business_type = Console.ReadLine();

                Console.WriteLine("Enter the Fixed Income level");
                Console.Write("> ");
                customerAccountLoadRequest.level_fixedinc = Console.ReadLine();

                Console.WriteLine("Enter the Fixed Income Years");
                Console.Write("> ");
                String? FIYS = Console.ReadLine();
                customerAccountLoadRequest.years_fixedinc = config.ParseNullableByte(FIYS);

                Console.WriteLine("Enter the Time Horizon");
                Console.Write("> ");
                customerAccountLoadRequest.time_horizon = Console.ReadLine();

                Console.WriteLine("Enter the liquid Needs");
                Console.Write("> ");
                customerAccountLoadRequest.liq_needs = Console.ReadLine();

                Console.WriteLine("Enter the Sweep Destination");
                Console.Write("> ");
                customerAccountLoadRequest.sweep_dest = Console.ReadLine();

                Console.WriteLine("Enter the Sweep SYM");
                Console.Write("> ");
                customerAccountLoadRequest.sweep_sym = Console.ReadLine();

                Console.WriteLine("Enter the Ho min equity");
                Console.Write("> ");
                String? HMES = Console.ReadLine();
                customerAccountLoadRequest.ho_min_equity = config.ParseNullableDecimal(HMES);

                Console.WriteLine("Enter the Tax Blend rate");
                Console.Write("> ");
                String? TBRS = Console.ReadLine();
                customerAccountLoadRequest.tax_blend_rate = config.ParseNullableDecimal(TBRS);

                Console.WriteLine("Enter the Deceased date");
                Console.Write("> ");
                String? decDateS = Console.ReadLine();
                customerAccountLoadRequest.deceased_dt = config.ParseNullableDateTime(decDateS);

                Console.WriteLine("Enter the Account Close date");
                Console.Write("> ");
                String? ACDateS = Console.ReadLine();
                customerAccountLoadRequest.acct_close_dt = config.ParseNullableDateTime(ACDateS);

                Console.WriteLine("Enter the fi_fed_l_rate");
                Console.Write("> ");
                String? fifedls = Console.ReadLine();
                customerAccountLoadRequest.fi_fed_l_rate = config.ParseNullableDecimal(fifedls);

                Console.WriteLine("Enter the fi_fed_s_rate");
                Console.Write("> ");
                String? fifedlss = Console.ReadLine();
                customerAccountLoadRequest.fi_fed_s_rate = config.ParseNullableDecimal(fifedlss);

                Console.WriteLine("Enter the fi_exch_l_rate");
                Console.Write("> ");
                String? fiexhls = Console.ReadLine();
                customerAccountLoadRequest.fi_exch_l_rate = config.ParseNullableDecimal(fiexhls);

                Console.WriteLine("Enter the fi_exch_s_rate");
                Console.Write("> ");
                String? fiexhss = Console.ReadLine();
                customerAccountLoadRequest.fi_exch_s_rate = config.ParseNullableDecimal(fiexhss);

                Console.WriteLine("Enter the fi_house_l_rate");
                Console.Write("> ");
                String? fhols = Console.ReadLine();
                customerAccountLoadRequest.fi_house_l_rate = config.ParseNullableDecimal(fhols);

                Console.WriteLine("Enter the fi_house_s_rate");
                Console.Write("> ");
                String? fhsr = Console.ReadLine();
                customerAccountLoadRequest.fi_house_s_rate = config.ParseNullableDecimal(fhsr);

                Console.WriteLine("Enter the ira_distrb_amt");
                Console.Write("> ");
                String? irdias = Console.ReadLine();
                customerAccountLoadRequest.ira_distrb_amt = config.ParseNullableDecimal(irdias);

                Console.WriteLine("Enter the ira_fed_tax");
                Console.Write("> ");
                String? ifedts = Console.ReadLine();
                customerAccountLoadRequest.ira_fed_tax = config.ParseNullableDecimal(ifedts);

                Console.WriteLine("Enter the ira_state_tax");
                Console.Write("> ");
                String? istatts = Console.ReadLine();
                customerAccountLoadRequest.ira_state_tax = config.ParseNullableDecimal(istatts);



                Console.WriteLine("Enter the IR Period");
                Console.Write("> ");
                customerAccountLoadRequest.ira_period = Console.ReadLine();

                Console.WriteLine("Enter the IRA State code");
                Console.Write("> ");
                customerAccountLoadRequest.ira_st_cd = Console.ReadLine();

                Console.WriteLine("Enter the sh_seg_offset");
                Console.Write("> ");
                customerAccountLoadRequest.sh_seg_offset = Console.ReadLine();

                Console.WriteLine("Enter the escrow_acct_type");
                Console.Write("> ");
                customerAccountLoadRequest.escrow_acct_type = Console.ReadLine();

                Console.WriteLine("Enter the mail_irs_forms");
                Console.Write("> ");
                customerAccountLoadRequest.mail_irs_forms = Console.ReadLine();

                Console.WriteLine("Enter the intraday_cnfrm");
                Console.Write("> ");
                customerAccountLoadRequest.intraday_cnfrm = Console.ReadLine();

                Console.WriteLine("Enter the intraday_emails");
                Console.Write("> ");
                customerAccountLoadRequest.intraday_emails = Console.ReadLine();

                Console.WriteLine("Enter the intraday_fax");
                Console.Write("> ");
                customerAccountLoadRequest.salute = Console.ReadLine();

                Console.WriteLine("Enter the intraday_fax");
                Console.Write("> ");
                customerAccountLoadRequest.salute = Console.ReadLine();

                Console.WriteLine("Enter the Employee Status");
                Console.Write("> ");
                customerAccountLoadRequest.emp_status = Console.ReadLine();

                Console.WriteLine("Enter the Employee Title");
                Console.Write("> ");
                customerAccountLoadRequest.emp_title = Console.ReadLine();

                Console.WriteLine("Enter the Joint Address 1");
                Console.Write("> ");
                customerAccountLoadRequest.jt_add1 = Console.ReadLine();

                Console.WriteLine("Enter the Joint Address 2");
                Console.Write("> ");
                customerAccountLoadRequest.jt_add2 = Console.ReadLine();

                Console.WriteLine("Enter the Joint Address 3");
                Console.Write("> ");
                customerAccountLoadRequest.jt_add3 = Console.ReadLine();

                Console.WriteLine("Enter the Joint City");
                Console.Write("> ");
                customerAccountLoadRequest.jt_city = Console.ReadLine();

                Console.WriteLine("Enter the Joint State code");
                Console.Write("> ");
                customerAccountLoadRequest.jt_st_cd = Console.ReadLine();

                Console.WriteLine("Enter the Joint Zip");
                Console.Write("> ");
                customerAccountLoadRequest.jt_zip = Console.ReadLine();

                Console.WriteLine("Enter the Joint Country");
                Console.Write("> ");
                customerAccountLoadRequest.jt_country = Console.ReadLine();

                Console.WriteLine("Enter the Joint Employer Status");
                Console.Write("> ");
                customerAccountLoadRequest.jt_empr_status = Console.ReadLine();

                Console.WriteLine("Enter the Joint Employee Title");
                Console.Write("> ");
                customerAccountLoadRequest.jt_empr_title = Console.ReadLine();

                Console.WriteLine("Enter the Trust date");
                Console.Write("> ");
                String? trustDateS = Console.ReadLine();
                customerAccountLoadRequest.trust_dt = config.ParseNullableDateTime(trustDateS);


                Console.WriteLine("Enter the Trust Net Income");
                Console.Write("> ");
                String? tnis = Console.ReadLine();
                customerAccountLoadRequest.trust_net_inc = config.ParseNullableInt(tnis);

                Console.WriteLine("Enter the Trust liquid Net Worth");
                Console.Write("> ");
                String? tlNWS = Console.ReadLine();
                customerAccountLoadRequest.trust_net_liq = config.ParseNullableInt(tlNWS);

                Console.WriteLine("Enter the oth_brk_emp");
                Console.Write("> ");
                customerAccountLoadRequest.oth_brk_emp = Console.ReadLine();

                Console.WriteLine("Enter the valid_w8w9");
                Console.Write("> ");
                customerAccountLoadRequest.valid_w8w9 = Console.ReadLine();

                Console.WriteLine("Enter the fatca");
                Console.Write("> ");
                customerAccountLoadRequest.fatca = Console.ReadLine();

                Console.WriteLine("Enter the Override Rate");
                Console.Write("> ");
                String? ORRS = Console.ReadLine();
                customerAccountLoadRequest.override_rate = config.ParseNullableDecimal(tlNWS);


                Console.WriteLine("Enter the rpt_8966");
                Console.Write("> ");
                customerAccountLoadRequest.rpt_8966 = Console.ReadLine();

                Console.WriteLine("Enter the tax_type_ch4");
                Console.Write("> ");
                customerAccountLoadRequest.tax_type_ch4 = Console.ReadLine();

                Console.WriteLine("Enter the w8_ch3");
                Console.Write("> ");
                customerAccountLoadRequest.w8_ch3 = Console.ReadLine();

                Console.WriteLine("Enter the w8_ch4");
                Console.Write("> ");
                customerAccountLoadRequest.w8_ch4 = Console.ReadLine();

                Console.WriteLine("Enter the w8_pool");
                Console.Write("> ");
                customerAccountLoadRequest.w8_pool = Console.ReadLine();

                Console.WriteLine("Enter the w8_lob");
                Console.Write("> ");
                customerAccountLoadRequest.w8_lob = Console.ReadLine();

                Console.WriteLine("Enter the w8_income");
                Console.Write("> ");
                customerAccountLoadRequest.w8_income = Console.ReadLine();

                Console.WriteLine("Enter the w8_exempt");
                Console.Write("> ");
                customerAccountLoadRequest.w8_exempt = Console.ReadLine();

                Console.WriteLine("Enter the cust_type_2052a");
                Console.Write("> ");
                customerAccountLoadRequest.cust_type_2052a = Console.ReadLine();

                Console.WriteLine("Enter the corp_buyback");
                Console.Write("> ");
                customerAccountLoadRequest.corp_buyback = Console.ReadLine();

                Console.WriteLine("Enter the gdpr_compliant");
                Console.Write("> ");
                customerAccountLoadRequest.gdpr_compliant = Console.ReadLine();

                Console.WriteLine("Enter the firpta_blend_rate");
                Console.Write("> ");
                String? FBRS = Console.ReadLine();
                customerAccountLoadRequest.firpta_blend_rate = config.ParseNullableDecimal(FBRS);

                Console.WriteLine("Enter the add4");
                Console.Write("> ");
                customerAccountLoadRequest.add4 = Console.ReadLine();

                Console.WriteLine("Enter the add5");
                Console.Write("> ");
                customerAccountLoadRequest.add5 = Console.ReadLine();

                #endregion "cust_details fields"


                #region "Additional Fields"
                Console.WriteLine("Enter the Account type");
                Console.Write("> ");
                customerAccountLoadRequest.acct_type = Console.ReadLine();

                Console.WriteLine("Enter the dvp_id_num");
                Console.Write("> ");
                customerAccountLoadRequest.dvp_id_num = Console.ReadLine();

                Console.WriteLine("Enter the act_agent_bk");
                Console.Write("> ");
                customerAccountLoadRequest.act_agent_bk = Console.ReadLine();

                Console.WriteLine("Enter the access_cd");
                Console.Write("> ");
                customerAccountLoadRequest.access_cd = Console.ReadLine();

                Console.WriteLine("Enter the dtcc_num");
                Console.Write("> ");
                customerAccountLoadRequest.dtcc_num = Console.ReadLine();

                Console.WriteLine("Enter the agent_bk");
                Console.Write("> ");
                customerAccountLoadRequest.agent_bk = Console.ReadLine();

                Console.WriteLine("Enter the ip_num_1");
                Console.Write("> ");
                customerAccountLoadRequest.ip_num_1 = Console.ReadLine();

                Console.WriteLine("Enter the ip_account_1");
                Console.Write("> ");
                customerAccountLoadRequest.ip_account_1 = Console.ReadLine();

                Console.WriteLine("Enter the ip_num_2");
                Console.Write("> ");
                customerAccountLoadRequest.ip_num_2 = Console.ReadLine();

                Console.WriteLine("Enter the ip_account_2");
                Console.Write("> ");
                customerAccountLoadRequest.ip_account_2 = Console.ReadLine();

                Console.WriteLine("Enter the sub_acct_no");
                Console.Write("> ");
                customerAccountLoadRequest.sub_acct_no = Console.ReadLine();

                Console.WriteLine("Enter the chgind");
                Console.Write("> ");
                customerAccountLoadRequest.chgind = Console.ReadLine();

                Console.WriteLine("Enter the ip_name1");
                Console.Write("> ");
                customerAccountLoadRequest.ip_name1 = Console.ReadLine();

                Console.WriteLine("Enter the ip_email1");
                Console.Write("> ");
                customerAccountLoadRequest.ip_email1 = Console.ReadLine();

                Console.WriteLine("Enter the ip_name2");
                Console.Write("> ");
                customerAccountLoadRequest.ip_name2 = Console.ReadLine();

                Console.WriteLine("Enter the ip_email2");
                Console.Write("> ");
                customerAccountLoadRequest.ip_email2 = Console.ReadLine();

                Console.WriteLine("Enter the firm_ca_frac");
                Console.Write("> ");
                customerAccountLoadRequest.firm_ca_frac = Console.ReadLine();

                Console.WriteLine("Enter the new_sub");
                Console.Write("> ");
                customerAccountLoadRequest.new_sub = Console.ReadLine();

                Console.WriteLine("Enter the dummy1");
                Console.Write("> ");
                customerAccountLoadRequest.dummy1 = Console.ReadLine();

                Console.WriteLine("Enter the dummy2");
                Console.Write("> ");
                customerAccountLoadRequest.dummy2 = Console.ReadLine();

                #endregion "Additional Fields"



                var dataAsString = JsonConvert.SerializeObject(customerAccountLoadRequest);
                Console.WriteLine(dataAsString);
                var dataContent = new StringContent("[" + dataAsString + "]", Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(config.BASEURL() + "/CustomerAccounts", dataContent);

                if (response.IsSuccessStatusCode)
                {
                    Uri? ncrUrl = response.Headers.Location;
                    var contents = await response.Content.ReadAsStringAsync();

                    var obj = JsonConvert.DeserializeObject(contents);
                    var JS = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    Console.WriteLine(JS);
                    Console.WriteLine("Customer Profile is Updated");
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
