
namespace BlackFinchLendingPlatform
{
    public class LendingEngine
    {
        public IList<LendingItem> LendingItems { get; set; } = new List<LendingItem>();

        private int CountStatus(bool success) => LendingItems.Count(e => e.Success() == success);

        private decimal TotalValueOfLoansWritten => LendingItems.Where(e => e.Success() == true).Sum(e => e.LoanValue);

        public string Summary()
        {

            return $"Total Applicants Where Success = True : {CountStatus(true)}\n" +
                $"Total Applicants Where Success = False: {CountStatus(false)}\n" +
                $"Total Value of Loans Written to date : { TotalValueOfLoansWritten:c}\n";
 
        }
    }
}
