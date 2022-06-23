using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icAPIConsole.Models.SecurityCoupon
{
    public class SecurityCouponPostRequest
    {
        public string? mode { get; set; }
        public string? symbol { get; set; }
        public Int32? id { get; set; }

        public DateTime? system_dt { get; set; }

      //  public String? system_dt { get; set; }
        public Int32? sym_no { get; set; }
        public Decimal? coupon { get; set; }

      //  public Int32? coupon { get; set; }

       //public String? search { get; set; }

        public DateTime? eff_coupon_dt { get; set; }

       // public String? eff_coupon_dt { get; set; }
    }
}
