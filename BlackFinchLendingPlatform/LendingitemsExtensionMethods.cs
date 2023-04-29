
namespace BlackFinchLendingPlatform
{
    public static class LendingItemExtensionMethods
    {

        /// <summary>
        /// Loan to Value(LTV) is the amount that the loan is for, expressed as a percentage of the value of the asset that the loan will be secured against.
        /// </summary>
        public static decimal LTV(this LendingItem item)
        {
            if (item.LoanValue == 0 || item.AssetValue == 0 || item.AssetValue <= item.LoanValue)
            { return 0; }  // TODO check best way handle.     

            var temp = (item.LoanValue / item.AssetValue) * 100;
            return Math.Round(temp, 2);
        }



        public static bool Success(this LendingItem item)
        {
           
            if (item.LoanValue < 1500000 || item.LoanValue > 100000)
            {
               
                if (item.LoanValue >= 1000000 && item.LTV() < 60 && item.CreditScore >= 950)
                {
                    return true;
                }

               
                if (item.LoanValue <= 1000000)
                {

                    if (item.LTV() < 60 && item.CreditScore >= 750)
                    {
                        return true;
                    }

                    if (item.LTV() < 80 && item.CreditScore >= 800)
                    {
                        return true;
                    }

                    if (item.LTV() < 90 && item.CreditScore >= 900)
                    {
                        return true;
                    }
                                       
                }
            }

            return false;
        }

    }
}
