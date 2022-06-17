using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icAPIConsole.Models.CustomerAccount
{
    public class CustomerAccountLoadRequest
    {
        #region "cust_profile fields"
        public string? corr { get; set; } //f
        public string? office { get; set; } //f
        public string? acct_no { get; set; } //f
        public string? acct_name { get; set; } //f
        public string? short_name { get; set; } //f
        public string? port_track { get; set; } //f
        public string? designator { get; set; } //f
        public string? cost_desig { get; set; } //f
        //public string paib_ind { get; set; }
        public string? tax_lot { get; set; } //f
        //public string status { get; set; }
        public string? capacity { get; set; } //f
        public string? sol_unsol { get; set; } //f
 
        public string? rr_cd { get; set; } //f
        public string? ad_cd { get; set; } //f
        public string? an_cd { get; set; } //f
        public string? pm_cd { get; set; } //f
    
        public string? ac_grp_cd { get; set; } //f
        public string? currency { get; set; } //f
        public string? legal_entity { get; set; } //f
        public string? classification { get; set; } //f
        public string? ssn { get; set; } //f
        public string? sec_charge { get; set; } //f
        public string? ca_frac { get; set; } //f
        //public string w8 { get; set; }
        public DateTime? w8_dt { get; set; } //f
        //public string w9 { get; set; }
        public string? employee { get; set; } //f
        public string? firm_emp { get; set; } //f

        public string? marital_status { get; set; } //f
        public byte? dependants { get; set; } //f
        public DateTime? dob { get; set; } //f
        public string? nasd_emp { get; set; } //f
        public string? nasd_spouse { get; set; } //f
        //public string day_trader { get; set; }
        //public string large_trader { get; set; }
        public string? large_trader_id { get; set; } //commented large_trader and added large_trader_id instead
      
        public string? inactive_reason { get; set; } //f
        public DateTime? stat_st_dt { get; set; } //f
        public DateTime? stat_en_dt { get; set; } //f
      
        public string? inv_objective { get; set; } //f
        public string? risk_tolerence { get; set; } //f
        public string? fncl_data { get; set; } //f
        public string? jt_fncl_data { get; set; } //f
        public byte? tax_bracket { get; set; } //f
        public string? level_stocks { get; set; } //f
        public byte? years_stocks { get; set; } //f
        public string? level_options { get; set; } //f
        public byte? years_options { get; set; } //f
        public string? acct_oth_firms { get; set; } //f
        public string? dir_shr_dec { get; set; } //f
        public string? mrgn_on_file { get; set; } //f
        public string? optn_on_file { get; set; } //f
        public string? avg_price { get; set; } //f
        public string? prg_trading { get; set; } //f
        public string? index_arbitrage { get; set; } //f
        public string? bill_srvc_lvl { get; set; } //f
        public string? div_reinv { get; set; } //f
   
        public string? in_acct_no { get; set; } //f
        public string? out_acct_no { get; set; } //f
        public string? ssn_type { get; set; } //f
        public string? giin { get; set; } //f
        public string? ftn { get; set; } //f
        public string? FDID { get; set; } //f
  
        #endregion "cust_profile fields"

        #region "cust_details fields"
 
        public string salute { get; set; } //f
        public string contactf { get; set; } //f
        public string contactl { get; set; } //f
        public string m_initial { get; set; } //f
        public string w8w9 { get; set; } //f
        public string w8w9type { get; set; } //f
        public string w8rec_cd { get; set; } //f
      
        public string bkup_withhold { get; set; } //f
        public string add1 { get; set; } //f
        public string add2 { get; set; } //f
        public string add3 { get; set; } //f
        public string city { get; set; } //f
        public string st_cd { get; set; } //f
        public string zip { get; set; } //f
        public string country { get; set; } //f
        public string phone { get; set; } //f
        public string fax { get; set; } //f
        public string email { get; set; } //f
        public string citizenship { get; set; } //f
        public string tax_country { get; set; } //f
        public string mail_flg { get; set; } //f
        public string mail_add1 { get; set; } //f
        public string mail_add2 { get; set; } //f
        public string mail_add3 { get; set; } //f
        public string mail_city { get; set; } //f
        public string mail_st_cd { get; set; } //f
        public string mail_zip { get; set; } //f
        public string mail_country { get; set; } //f
        //public string aba_num { get; set; }
        public string custodian { get; set; } //f
        public string guarantee { get; set; } //f
        public string employer { get; set; } //f
        public string emp_add1 { get; set; } //f
        public string emp_add2 { get; set; } //f
        public string emp_add3 { get; set; } //f
        public decimal? credit_adj { get; set; } //f
        public decimal? debit_adj { get; set; } //f
        public string jt_name { get; set; } //f
        public string jt_fname { get; set; } //f
        public string jt_m_initial { get; set; } //f
        public string jt_lname { get; set; } //f
        public string jt_ssn { get; set; } //f
        public string? jt_mnr_relation { get; set; } //f
        public DateTime? jt_mnr_dob { get; set; } //f
        public string jt_mnr_citizen { get; set; } //f
        public string? jt_mnr_w8 { get; set; } //f
        public string? jt_empr_name { get; set; } //f
        public string? jt_empr_addr { get; set; } //f
        public string? oth_firms { get; set; } //f
        public string? dir_shr_dec_dtl { get; set; } //f
        public string? cpa_name { get; set; } //f
        public string? cpa_addr1 { get; set; } //f
        public string? cpa_addr2 { get; set; } //f
        public string? cpa_phone { get; set; } //f
        public string? cpa_email { get; set; } //f
        public string? contact_cpa { get; set; } //f
        public string? att_name { get; set; } //f
        public string? att_addr1 { get; set; } //f
        public string? att_addr2 { get; set; } //f
        public string? att_phone { get; set; } //f
        public string? att_email { get; set; } //f
        public string? contact_att { get; set; } //f
        public string? id_type { get; set; } //f
        public string? id_num { get; set; } //f
        public string? id_place { get; set; } //f
        public int? annual_inc { get; set; } //f
        public int? net_worth_liq { get; set; } //f
        public int? net_worth { get; set; } //f
        public string? post_pl { get; set; } //f
        public string? sweep_mny_mkt { get; set; } //f
        public decimal? cr_int_rate { get; set; } //f
        public decimal? db_int_rate { get; set; } //f
        public string? tefra { get; set; } //f
        //public string dt_timetick { get; set; }
        public decimal? dtbp_ratio { get; set; } //f
        public decimal? pm_dtbp_ratio { get; set; } //f
        public string? optn_level { get; set; } //f
        //public string ws_exempt { get; set; }
        public DateTime? start_dt { get; set; } //f
        public string? opt_designator { get; set; } //f
        public string? eq_clear_process_ind { get; set; } //f
        public string? opt_clear_process_ind { get; set; } //f
        public string? mf_clear_process_ind { get; set; } //f
        public string? fi_clear_process_ind { get; set; } //f
        public decimal? fed_l_rate { get; set; } //f
        public decimal? fed_s_rate { get; set; } //f
        public decimal? exch_l_rate { get; set; } //f
        public decimal? exch_s_rate { get; set; } //f
        public decimal? house_l_rate { get; set; } //f
        public decimal? house_s_rate { get; set; } //f
        public string? stmnt_mail { get; set; } //f
        public byte? stmnt_copy { get; set; } //f
        public string cnfrm_mail { get; set; } //f
        public byte? cnfrm_copy { get; set; } //f
        public string? proxy_optout { get; set; } //f
        public string? lei { get; set; } //f
        public string? ltid_1 { get; set; } //f
        public string? ltid_2 { get; set; } //f
        public string? ltid_3 { get; set; } //f
        public string? mltid { get; set; } //f
        public decimal? trading_limit { get; set; } //f
        public string? rule_2111 { get; set; } //f
        public string? business_type { get; set; } //f
        public string? level_fixedinc { get; set; } //f
        public byte? years_fixedinc { get; set; } //f
        public string? time_horizon { get; set; } //f
        public string? liq_needs { get; set; } //f
        public string? sweep_dest { get; set; } //f
        public string? sweep_sym { get; set; } //f
        public decimal? ho_min_equity { get; set; } //f
        public decimal? tax_blend_rate { get; set; } //f
        public DateTime? deceased_dt { get; set; } //f
        public DateTime? acct_close_dt { get; set; } //f
        public decimal? fi_fed_l_rate { get; set; } //f
        public decimal? fi_fed_s_rate { get; set; } //f
        public decimal? fi_exch_l_rate { get; set; } //f
        public decimal? fi_exch_s_rate { get; set; } //f
        public decimal? fi_house_l_rate { get; set; } //f
        public decimal? fi_house_s_rate { get; set; } //f
        public decimal? ira_distrb_amt { get; set; } //f
        public string? ira_period { get; set; } //f
        public string? ira_st_cd { get; set; } //f
        public decimal? ira_fed_tax { get; set; } //f
        public decimal? ira_state_tax { get; set; } //f
        public string? sh_seg_offset { get; set; } //f
       
        public string? escrow_acct_type { get; set; } //f
        public string? mail_irs_forms { get; set; } //f
        public string? intraday_cnfrm { get; set; } //f
        public string? intraday_emails { get; set; } //f
        public string? intraday_fax { get; set; } //f
        public string? emp_status { get; set; } //f
        public string? emp_title { get; set; } //f
        public string? jt_add1 { get; set; } //f
        public string? jt_add2 { get; set; } //f
        public string? jt_add3 { get; set; } //f
        public string? jt_city { get; set; } //f
        public string? jt_st_cd { get; set; } //f
        public string? jt_zip { get; set; } //f
        public string? jt_country { get; set; } //f
        public string? jt_empr_status { get; set; } //f
        public string? jt_empr_title { get; set; } //f
        public DateTime? trust_dt { get; set; } //f
        public int? trust_net_inc { get; set; } //f
        public int? trust_net_liq { get; set; } //f
        public string? oth_brk_emp { get; set; } //f
        public string? valid_w8w9 { get; set; } //f
        public string? fatca { get; set; } //f
        public decimal? override_rate { get; set; } //f
        public string? rpt_8966 { get; set; } //f
        public string? tax_type_ch4 { get; set; } //f
        public string? w8_ch3 { get; set; } //f
        public string? w8_ch4 { get; set; } //f
        public string? w8_pool { get; set; } //f
        public string? w8_lob { get; set; } //f
        public string? w8_income { get; set; } //f
        public string? w8_exempt { get; set; } //f
        public string? cust_type_2052a { get; set; } //f
        public string? corp_buyback { get; set; } //f
        public string? gdpr_compliant { get; set; } //f
        public decimal? firpta_blend_rate { get; set; } //f
        public string? add4 { get; set; } //f
        public string? add5 { get; set; } //f
  
        #endregion "cust_details fields"

   

        #region "cust_type fields"
    
        public string? acct_type { get; set; } //f
      
        #endregion "cust_type fields"

        #region "cust_dvp fields"
        
        public string? dvp_id_num { get; set; } //f id_num modified to dvp_id_num
        public string? act_agent_bk { get; set; } //f
      
        public string? access_cd { get; set; } //f
        public string? dtcc_num { get; set; } //f
      
        public string? agent_bk { get; set; } //f
        
        public string? ip_num_1 { get; set; } //f
        public string? ip_account_1 { get; set; } //f
        public string? ip_num_2 { get; set; } //f
        public string? ip_account_2 { get; set; } 
        #endregion "cust_dvp fields"



        #region "cust_sub_acct fields"
     
        public string? sub_acct_no { get; set; } 
        #endregion "cust_sub_acct fields"

        #region "Additional fields"
        public string? chgind { get; set; }
        public string? ip_name1 { get; set; }
        public string? ip_email1 { get; set; }
        public string? ip_name2 { get; set; }
        public string? ip_email2 { get; set; }
        public string? firm_ca_frac { get; set; }
        public string? new_sub { get; set; }
        public string? dummy1 { get; set; }
        public string? dummy2 { get; set; }


        #endregion "Additional fields"
    }
}
