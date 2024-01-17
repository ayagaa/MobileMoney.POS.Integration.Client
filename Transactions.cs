using MobileMoney.POS.Integration.Client.Dialogs;

namespace MobileMoney.POS.Integration.Client
{
    public static class Transactions
    {
        public static string InitiateTransaction(string transactionDetail,
            string customerMobileNo, string transactionAmount, string transactionRef)
        {
            using (var transactionDlg = new TransactionsDialogFrm(transactionDetail,
                customerMobileNo, transactionAmount, transactionRef))
            {
                transactionDlg.ShowDialog();
            }
            return string.Empty;
        }
    }
}
