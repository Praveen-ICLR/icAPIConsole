namespace icAPIConsole.Models.EOD
{
    public class EODGetRequest
    {
        public string? system_dt { get; set; }
        public string? corr { get; set; }
        public string? sub_flag { get; set; }
        public string? search { get; set; }
    }
}
