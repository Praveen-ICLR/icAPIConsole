using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using Newtonsoft.Json;

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

      
    }
}
