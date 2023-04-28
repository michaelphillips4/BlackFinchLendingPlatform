using System.Text;

namespace BlackFinchLendingPlatform
{
    public class LendingEngine
    {
        private IList<LendingItem> LendingItems { get; set; } = new List<LendingItem>();

        private void Add(LendingItem lendingItem)
        {
            LendingItems.Add(lendingItem);
        }

        public string Summary(LendingItem lendingItem)
        {

            Add(lendingItem);

            StringBuilder summary = new();

            var totalSuccess = LendingItems.Count(e => e.Success() == true);
            var totalFails = LendingItems.Count(e => e.Success() == false);
            var totalValueOfLoansWritten = LendingItems.Where(e => e.Success() == true).Sum(e => e.LoanValue);

            summary.Append("Applicant Success : ").Append(lendingItem.Success()).AppendLine();
            summary.Append("Total Applicants Where Success = true : ").Append(totalSuccess).AppendLine();
            summary.Append("Total Applicants Where Success = false: ").Append(totalFails).AppendLine();
            summary.Append("Total Value of Loans Written to date : ").Append(totalValueOfLoansWritten).AppendLine();


            return summary.ToString();

        }




    }
}
