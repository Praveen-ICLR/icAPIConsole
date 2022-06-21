using System.ComponentModel.DataAnnotations;

namespace icAPIConsole.Models.Transactions
{
    public class TransactionGetRequest
    {
        public decimal? tr_no { get; set; }
        public string? etype_list { get; set; }
        public string? corr { get; set; }
        public string? office { get; set; }
        public string? acct_no { get; set; }
        public string? acct_type { get; set; }
        public string? sub_acct_no { get; set; }
        public string? symbol { get; set; }
        public decimal? qty { get; set; }
        public decimal? price { get; set; }
        public decimal? n_amt { get; set; }
        public string? contra_code { get; set; }
        public string? blot_exch_cd { get; set; }
        public string? blot_clr_typ { get; set; }
        public string? blot_method { get; set; }
        public string? feetyp { get; set; }
        public string? ftdt { get; set; }
        public string? ttdt { get; set; }
        public string? fsdt { get; set; }
        public string? tsdt { get; set; }
        public string? fxdt { get; set; }
        public string? txdt { get; set; }
        public string? side { get; set; }
        public string? settle { get; set; }
        public string? rr_cd { get; set; }
        public string? c_corr { get; set; }
        public string? c_office { get; set; }
        public string? c_acct_no { get; set; }
        public string? c_acct_type { get; set; }
        public string? c_sub_acct_no { get; set; }
        public string? loginid { get; set; }
        public string? trd_tag { get; set; }
        public string? exclude_login { get; set; }
        public string? currency { get; set; }
        public string? ac_grp_cd { get; set; }
        public string? capacity { get; set; }
        public int? batchno { get; set; }
        public string? w8w9 { get; set; }
        public string? cl_order_id { get; set; }
    }

    public class TransactionsCancelRequest
    {
        [Required]
        public decimal? tr_no { get; set; }
        [Required]
        public string? system_dt { get; set; }
        [Required]
        public string? trd_tag { get; set; }
        public string? cl_order_id { get; set; }
        [Required]
        public string? cncl_reason { get; set; }
        public string? ib_cancel { get; set; }
    }

    public class TransactionsCancelAllRequest
    {
        [Required]
        public string? sysStr { get; set; }
        [Required]
        public string? trdTag { get; set; }
    }
}
