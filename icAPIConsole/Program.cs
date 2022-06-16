using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using icAPIConsole.APIEndPoints;

namespace icAPIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            APICall a = new APICall();

            a.APIConditionClass(args);
        }



    }
}