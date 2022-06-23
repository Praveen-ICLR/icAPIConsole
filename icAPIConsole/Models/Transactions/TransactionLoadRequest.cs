using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icAPIConsole.Models.Transactions
{
    public class TransactionLoadRequest
    {
        public string? entry_type { get; set; }
        public string? trd_type { get; set; }
        public DateTime? system_dt { get; set; }
        public DateTime? entry_dt { get; set; }
        public DateTime? trade_dt { get; set; }
        public DateTime? settle_dt { get; set; }
        public DateTime? exec_dt { get; set; }
        public string? symbol { get; set; }
        public decimal? qty { get; set; }
        public decimal? price { get; set; }
        public decimal? g_amt { get; set; }
        public decimal? n_amt { get; set; }
        public decimal? comm { get; set; }
        public decimal? sec_fee { get; set; }
        public decimal? exch_fee { get; set; }
        public decimal? clr_fee { get; set; }
        public decimal? ecn_fee { get; set; }
        public decimal? brk_fee { get; set; }
        public decimal? occ_fee { get; set; }
        public decimal? oth_fee { get; set; }
        public string? corr { get; set; }
        public string? office { get; set; }
        public string? acct_no { get; set; }
        public string? acct_type { get; set; }
        public string? sub_acct_no { get; set; }
        public string? contra_code { get; set; }
        public string? contra_corr { get; set; }
        public string? contra_office { get; set; }
        public string? contra_acct_no { get; set; }
        public string? contra_acct_type { get; set; }
        public string? blot_exch_cd { get; set; }
        public string? blot_clr_typ { get; set; }
        public string? blot_method { get; set; }
        public string? capacity { get; set; }
        public string? sol_unsol { get; set; }
        public string? trd_tag { get; set; }
        public string? descr { get; set; }
        public string? loginid { get; set; }
        public string? contra_sub_acct_no { get; set; }
        public string? memo1 { get; set; }
        public string? memo2 { get; set; }
        public string? rr_cd { get; set; }
        public string? tax_lot { get; set; }
        public decimal? lot_tr_no { get; set; }
        public decimal? buy_interest { get; set; }
        public decimal? finc_yield { get; set; }
        public string? yield_type { get; set; }
        public string? ac_grp_cd { get; set; }
        public string? trailer_codes { get; set; }
        public string? ad_cd { get; set; }
        public string? an_cd { get; set; }
        public string? tr_cd { get; set; }
   
        public string? currency1 { get; set; }
        public string? set_currency { get; set; }
        public string? set_country { get; set; }
        public string? set_location { get; set; }
        public decimal? rptd_price { get; set; }
        public decimal? sales_credit { get; set; }
        public string? discretion_flg { get; set; }
        public string? commflag { get; set; }
        public decimal? tax_lot_tr_no { get; set; }
        public string? cl_order_id { get; set; }
        public string? order_id { get; set; }
        public string? exec_id { get; set; }
        public string? memo3 { get; set; }
        public decimal? finc_discount { get; set; }
        public decimal? finc_spread { get; set; }
        public string? price_source { get; set; }
        public decimal? factor { get; set; }
        public DateTime? factor_dt { get; set; }
        public DateTime? delivery_dt { get; set; }
        public decimal? repo_rate { get; set; }
    }
}
