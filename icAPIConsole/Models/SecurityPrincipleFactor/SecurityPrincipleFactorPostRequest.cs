using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icAPIConsole.Models.SecurityPrincipleFactor
{
    public class SecurityPrincipleFactorPostRequest
    {
        public string? mode { get; set; }
        public string? symbol { get; set; }
        public Int32? id { get; set; }

        public string? system_dt { get; set; }
        public Int32? sym_no { get; set; }
        public Decimal? factor { get; set; }

        public String? factor_dt { get; set; }
    }
}
