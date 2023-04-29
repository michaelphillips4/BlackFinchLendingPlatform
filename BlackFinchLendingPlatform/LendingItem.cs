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

        public override string ToString()
        {
            return $"Success = {this.Success(),5}     LTV = {this.LTV(),5:0.00}%     LoanValue ={LoanValue,15:c}     AssetValue ={AssetValue,15:c}     CreditScore = {CreditScore,3:g}";
        }


    }

}
