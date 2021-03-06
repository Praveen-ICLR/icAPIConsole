using Microsoft.Extensions.Configuration;

namespace icAPIConsole.Core
{
    public class UrlConfiguration
    {

        public String BASEURL()
        {
            //Getting Base URL 
            IConfiguration Config = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json").Build();
            String URL = Config.GetSection("URL").Value;

            return URL;


        }

        public Decimal? ParseNullableDecimal(String value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return Decimal.Parse(value);
        }

        public short? ParseNullableshort(String value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return short.Parse(value);
        }

        public Int32? ParseNullableInt(String value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return Int32.Parse(value);
        }

        public Byte? ParseNullableByte(String value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return Byte.Parse(value);
        }

        public DateTime? ParseNullableDateTime(String value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return DateTime.Parse(value);
        }



        public DateTime ConvertStringtoDT(String dateInput)
        {
            var parsedDate = DateTime.Parse(dateInput);

            return parsedDate;
        }


    }
}
