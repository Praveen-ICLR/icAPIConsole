using System.ComponentModel.DataAnnotations;

namespace icAPIConsole.Models.CustomerAccount
{
    public class CustomerAccountGetRequest
    {
        [MaxLength(4)]
        public string? corr { get; set; }
        [MaxLength(4)]
        public string? office { get; set; }
        [MaxLength(13)]
        public string? acct_no { get; set; }
        [MaxLength(12)]
        public string? sub_acct_no { get; set; }
        [MaxLength(25)]
        public string? name { get; set; }
        [MaxLength(12)]
        public string? ssn { get; set; }
        [MaxLength(100)]
        public string? desig_list { get; set; }
        [MaxLength(12)]
        public string? ac_grp_cd { get; set; }
        [MaxLength(12)]
        public string? access_cd { get; set; }
        public String? search { get; set; }

    }
}
