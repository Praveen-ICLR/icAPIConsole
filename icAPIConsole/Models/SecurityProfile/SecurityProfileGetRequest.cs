using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icAPIConsole.Models.SecurityProfile
{
    public class SecurityProfileGetRequest
    {
        [Required]
        [MaxLength(25)]
        public string? symbol { get; set; }
        [MaxLength(12)]
        public string? sec_no { get; set; }
        [MaxLength(10)]
        public string? issuer_catg { get; set; }
        [MaxLength(3)]
        public string? asset_type { get; set; }
        [MaxLength(5)]
        public string? sec_type { get; set; }
        [MaxLength(5)]
        public string? sec_sub_type { get; set; }

        public String? search { get; set; }
    }
}
