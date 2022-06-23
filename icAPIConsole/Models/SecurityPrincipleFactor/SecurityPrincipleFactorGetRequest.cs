using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icAPIConsole.Models.SecurityPrincipleFactor
{
    public class SecurityPrincipleFactorGetRequest
    {
        public string? symbol { get; set; }
        public Int32? sym_no { get; set; }
        public String? search { get; set; }
    }
}
