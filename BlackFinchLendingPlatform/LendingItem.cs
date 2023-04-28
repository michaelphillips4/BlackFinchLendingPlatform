namespace BlackFinchLendingPlatform
{
    public class LendingItem
    {
        public LendingItem(decimal loanValue, decimal assetValue, int creditScore)
        {
            LoanValue = loanValue;
            AssetValue = assetValue;
            CreditScore = creditScore;
        }

        public decimal LoanValue { get; set; }
        public decimal AssetValue { get; set; }
        public int CreditScore { get; set; }
        public bool Success()
        {
            //If the value of the loan is more than £1.5 million or less than £100,000 then the application must be declined
            if(LoanValue > 1500000 || LoanValue < 100000)
            {
                return false;
            }

            //If the value of the loan is £1 million or more then the LTV must be 60 % or less and the credit score of the applicant must be 950 or more
            if (LoanValue >= 1000000 && LTV() < 60 && CreditScore >= 950)
            {
                return true;
            }

            //If the value of the loan is less than £1 million then the following rules apply:
            //If the LTV is less than 60 %, the credit score of the applicant must be 750 or more
            //If the LTV is less than 80 %, the credit score of the applicant must be 800 or more
            //If the LTV is less than 90 %, the credit score of the applicant must be 900 or more
            //If the LTV is 90 % or more, the application must be declined

            if (LoanValue <= 1000000 )
            {

                if(LTV() < 60 && CreditScore >= 750)
                {
                    return true;
                }

                if (LTV() < 80 && CreditScore >= 800)
                {
                    return true;
                }

                if (LTV() < 90 && CreditScore >= 900)
                {
                    return true;
                }

                if (LTV() >= 90)
                {
                    return false;
                }

            }


            return false;
        }
        public decimal LTV()
        {
            if (LoanValue == 0 || AssetValue == 0)
            { return -1; }  //?

            if (AssetValue <= LoanValue)
            { return -1; }  //?

            //Loan to Value(LTV) is the amount that the loan is for, expressed as a percentage of the value of the asset that the loan will be secured against.
            var temp = (LoanValue / AssetValue) * 100;
            return Math.Round(temp,2);
        }

         
    }
}
