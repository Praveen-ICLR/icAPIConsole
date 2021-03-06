using icAPIConsole.APIEndPoints;

namespace icAPIConsole
{
    public class APICall
    {
        public void APIConditionClass(string[] args)
        {

            String? i;

            Console.WriteLine(@"Please select the API: 
                1.Transaction API 
                2.Activity API 
                3.Security Profile API 
                4.Customer Account API
                5.EOD API
                6.Security Coupon API
                7.Security Factor API
                8.Security Principle Factor API"
        );
            Console.Write("> ");
            i = Console.ReadLine();

            //Selecting the API to be called 

            //Transaction Api
            if (i == "1")
            {
                Console.WriteLine(@"Please select the Transaction Method You want to Proceed: 
                A.Get Transaction
                B.Cancel Transaction 
                C.Cancel All Transaction
                D.Make a Transaction 
                "
   );
                Console.Write("> ");
                String? TransMethod = Console.ReadLine();

                if (TransMethod == "B")
                {
                    MainCancelTrans(args).GetAwaiter().GetResult();
                    Console.ReadLine();

                }
                else if (TransMethod == "A")
                {
                    MainGetTrans(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else if (TransMethod == "C")
                {
                    MainCancelAllTrans(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else if (TransMethod == "D")
                {
                    MainPostTrans(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Select Right option");
                }


            }

            //Activity API
            else if (i == "2")
            {
                MainGetAct(args).GetAwaiter().GetResult();
                Console.ReadLine();
            }

            //SecurityProfile API 
            else if (i == "3")
            {
                Console.WriteLine(@"Please select the SecurityProfile Method You want to Proceed: 
                 A.Get Security Profile
                 B.Post Security Profile
                 C.Update Security Profile
                 "
   );
                Console.Write("> ");
                String? SPMethod = Console.ReadLine();

                if (SPMethod == "B")
                {
                    MainLoadSecurityProfile(SPMethod).GetAwaiter().GetResult();
                    Console.ReadLine();

                }
                else if (SPMethod == "A")
                {
                    MainGetSecurityProfile(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else if (SPMethod == "C")
                {
                    MainLoadSecurityProfile(SPMethod).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Select Right option");
                }


            }

            //Customer API
            else if (i == "4")
            {
                Console.WriteLine(@"Please select the Customer Account Method You want to Proceed: 
                   A.Get Customer Account 
                   B.Add Customer Account - Post Method 
                   C.Update Customer Account - Put Method
                   "
   );
                Console.Write("> ");
                String? CAMethod = Console.ReadLine();

                if (CAMethod == "B")
                {
                    MainAddCA(args).GetAwaiter().GetResult();
                    Console.ReadLine();

                }
                else if (CAMethod == "A")
                {
                    MainGetCA(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else if (CAMethod == "C")
                {
                    MainUpdateCA(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Select Right option");
                }

            }
            //EOD API
            else if (i == "5")
            {
                Console.WriteLine(@"Please select the EOD Method You want to Proceed: 
                A.Get EOD Cash
                B.Get EOD Position
                "
   );
                Console.Write("> ");
                String? EODMethod = Console.ReadLine();

                if (EODMethod == "B")
                {
                    MainGetEODPosition(args).GetAwaiter().GetResult();
                    Console.ReadLine();

                }
                if (EODMethod == "A")
                {
                    MainGetEODCash(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }

            }
            //Security Coupon API 
            else if (i == "6")
            {
                Console.WriteLine(@"Please select the Security Coupon Method You want to Proceed: 
                 A.Get Security Coupon
                 B.Post Security Coupon
                 "
   );
                Console.Write("> ");
                String? SPMethod = Console.ReadLine();

                if (SPMethod == "B")
                {
                    MainPostSecurityCoupon().GetAwaiter().GetResult();
                    Console.ReadLine();

                }
                else if (SPMethod == "A")
                {
                    MainGetSecurityCoupon(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Select Right option");
                }


            }

            //Security Factor API 
            else if (i == "7")
            {
                Console.WriteLine(@"Please select the Security Factor Method You want to Proceed: 
                 A.Get Security Factor
                 B.Post Security Factor
                 "
   );
                Console.Write("> ");
                String? SPMethod = Console.ReadLine();

                if (SPMethod == "B")
                {
                    MainPostSecurityFactor().GetAwaiter().GetResult();
                    Console.ReadLine();

                }
                else if (SPMethod == "A")
                {
                    MainGetSecurityFactor(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Select Right option");
                }


            }

            //Security Coupon API 
            else if (i == "8")
            {
                Console.WriteLine(@"Please select the Security PrincipleFactor Method You want to Proceed: 
                 A.Get Security PrincipleFactor
                 B.Post Security PrincipleFactor
                 "
   );
                Console.Write("> ");
                String? SPMethod = Console.ReadLine();

                if (SPMethod == "B")
                {
                    MainPostSecurityPrincipleFactor().GetAwaiter().GetResult();
                    Console.ReadLine();

                }
                else if (SPMethod == "A")
                {
                    MainGetSecurityPrincipleFactor(args).GetAwaiter().GetResult();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Select Right option");
                }


            }
            else
            {
                Console.WriteLine("Not correct API was selected!");
            }

        }

        #region "Transaction API"
        /*1.Transaction function  */
        //Transaction Cancel API Function
        static async Task MainCancelTrans(string[] args)
        {

            await TransactionAPIEndPoints.CancelTransaction();
        }

        //Transaction Get API Function
        static async Task MainGetTrans(string[] args)
        {

            await TransactionAPIEndPoints.GetTransaction();
        }

        //All Transaction Cancel API Function
        static async Task MainCancelAllTrans(string[] args)
        {

            await TransactionAPIEndPoints.CancelAllTransaction();
        }

        static async Task MainPostTrans(string[] args)
        {

            await TransactionAPIEndPoints.PostTransaction();
        }
        #endregion "Transaction API"

        #region "Activity API"
        /*2. Activity function  */
        //Activity Get API Function
        static async Task MainGetAct(string[] args)
        {

            await ActivityAPIEndPoints.GetActivity();
        }

        #endregion "Activity API"

        #region "Security API"
        /*3. Security function  */
        //SecuirtyProfile Get API Function
        static async Task MainGetSecurityProfile(string[] args)
        {

            await SecurityProfileAPIEndPoints.GetSecurityProfile();
        }

        //LoadSecurityProfileRequest....
        static async Task MainLoadSecurityProfile(string a)
        {

            await SecurityProfileAPIEndPoints.LoadSecurityProfile(a);
        }

        #endregion "Security API"


        #region "Customer API"

        /*4. Customer Account function  */
        //Customer Account Get API Function
        static async Task MainGetCA(string[] args)
        {

            await CustomerAccountAPIEndPoints.GetCustomerAccounts();
        }

        //Customer Account Add API Function
        static async Task MainAddCA(string[] args)
        {

            await CustomerAccountAPIEndPoints.AddCustomerAccount();
        }

        //Customer Account Update API Function
        static async Task MainUpdateCA(string[] args)
        {

            await CustomerAccountAPIEndPoints.UpdateCustomerAccount();
        }

        #endregion "Customer API"

        #region "EOD API"
        /*5. EOD function  */
        //EODCash Get API Function
        static async Task MainGetEODCash(string[] args)
        {

            await EODAPIEndPoints.EODCashGetRequest();
        }

        //EODPosition Get API Function
        static async Task MainGetEODPosition(string[] args)
        {

            await EODAPIEndPoints.EODPositionGetRequest();
        }

        #endregion "EOD API"

        #region "Security Coupon API"
        static async Task MainGetSecurityCoupon(string[] args)
        {

            await SecurityCouponAPIEndPoints.GetSecurityCoupon();
        }

        //LoadSecurityProfileRequest....
        static async Task MainPostSecurityCoupon( )
        {

            await SecurityCouponAPIEndPoints.PostSecurityCoupon();
        }
        #endregion "Security Coupon API"

        #region "Security Factor API"
        static async Task MainGetSecurityFactor(string[] args)
        {

            await SecurityFactorAPIEndPoints.GetSecurityPrincipleFactor();
        }

        //LoadSecurityProfileRequest....
        static async Task MainPostSecurityFactor()
        {

            await SecurityFactorAPIEndPoints.PostSecurityFactor();
        }
        #endregion "Security Factor API"

        #region "Security Principle Factor API"
        static async Task MainGetSecurityPrincipleFactor(string[] args)
        {

            await SecurityPrincipleFactorAPIEndPoints.GetSecurityPrincipleFactor();
        }

        //LoadSecurityProfileRequest....
        static async Task MainPostSecurityPrincipleFactor()
        {

            await SecurityPrincipleFactorAPIEndPoints.PostSecurityPrincipleFactor();
        }
        #endregion "Security Principle Factor API"


    }
}
