using System.ComponentModel.DataAnnotations;

namespace icAPIConsole.Models.SecurityProfile
{
    public class SecuirtyProfileLoadRequest
    {

        [Required]
        public string? chgind { get; set; }
        [Required]
        public string? symbol { get; set; }
        [Required]
        public string? asset_type { get; set; }
        [Required]
        public string? sec_type { get; set; }
        [Required]
        public string? sec_no { get; set; }
        public string? descr { get; set; }
        public string? sec_sub_type { get; set; }
        public string? cusip { get; set; }
        public string? sedol { get; set; }
        public string? isin { get; set; }
        public string? issuer_catg { get; set; }
        public string? cust_symbol { get; set; }
        public string? exchange { get; set; }
        public string? alt_symbol2 { get; set; }
        public short? prem_mult { get; set; }
        public string? marginable { get; set; }
        public string? under_symbol { get; set; }
        public string? put_call { get; set; }
        public decimal? strike_price { get; set; }
        public DateTime? expire_dt { get; set; }
        public string? status { get; set; }
        public decimal? fed_l_rate { get; set; }
        public decimal? fed_s_rate { get; set; }
        public decimal? exch_l_rate { get; set; }
        public decimal? exch_s_rate { get; set; }
        public decimal? house_l_rate { get; set; }
        public decimal? house_s_rate { get; set; }
        public decimal? pm_el_rate { get; set; }
        public decimal? pm_es_rate { get; set; }
        public decimal? pm_hl_rate { get; set; }
        public decimal? pm_hs_rate { get; set; }
        public decimal? pm_hedge_hl_rate { get; set; }
        public decimal? pm_hedge_hs_rate { get; set; }
        public string? pm_prod_grp { get; set; }
        public short? pm_volatility { get; set; }
        public string? sic_cd { get; set; }
        public string? ftbr_trd_flg { get; set; }
        public string? ftbr_sec_tier { get; set; }
        public byte? settle_days { get; set; }
        public short? redmp_days { get; set; }
        public decimal? redmp_fee { get; set; }
        public string? inactive_reason { get; set; }
        public decimal? coupon { get; set; }
        public string? coupon_type { get; set; }
        public DateTime? mature_dt { get; set; }
        public byte? pay_freq { get; set; }
        public DateTime? issue_dt { get; set; }
        public DateTime? dated_dt { get; set; }
        public DateTime? first_coupon { get; set; }
        public DateTime? last_coupon { get; set; }
        public DateTime? next_coupon { get; set; }
        public DateTime? prev_coupon { get; set; }
        public string? taxable { get; set; }
        public DateTime? call_dt1 { get; set; }
        public decimal? call_rate1 { get; set; }
        public DateTime? call_dt2 { get; set; }
        public decimal? call_rate2 { get; set; }
        public DateTime? call_dt3 { get; set; }
        public decimal? call_rate3 { get; set; }
        public DateTime? put_dt1 { get; set; }
        public decimal? put_rate1 { get; set; }
        public DateTime? put_dt2 { get; set; }
        public decimal? put_rate2 { get; set; }
        public DateTime? put_dt3 { get; set; }
        public decimal? put_rate3 { get; set; }
        public string? sec_charge { get; set; }
        public string? country { get; set; }
        public string? wi { get; set; }
        public DateTime? wi_dt { get; set; }
        public string? mfdiv_accr { get; set; }
        public short? mfdiv_buy_accr { get; set; }
        public short? mfdiv_sell_accr { get; set; }
        public short? contract_shrs { get; set; }
        public int? issuer_no { get; set; }
        public int? rating_no { get; set; }
        public int? rating_no2 { get; set; }
        public int? rating_no3 { get; set; }
        public string? currency { get; set; }
        public string? penny_pilot { get; set; }
        public string? eq_hard2brw { get; set; }
        public string? sweep_dest { get; set; }
        public string? sweep_sym { get; set; }
        public string? accr_basis { get; set; }
        public string? trace_elig { get; set; }
        public DateTime? trace_dt { get; set; }
        public string? trace_status { get; set; }
        public string? mic { get; set; }
        public string? parent_ctry_cd { get; set; }
        public decimal? override_rate { get; set; }
        public string? fed_taxable { get; set; }
        public string? state_taxable { get; set; }
        public string? firm_sec_type { get; set; }
        public string? cov_uncov { get; set; }
        public string? contra_cusip_flg { get; set; }
        public string? master_cusip { get; set; }

    }
}
