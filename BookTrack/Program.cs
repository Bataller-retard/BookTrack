namespace BookTrack
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // UI preview only: change LoginForm to MainForm, BooksForm, MembersForm,
            // BorrowReturnForm, HistoryForm, or StaffForm to preview other screens.
            Application.Run(new LoginForm());
        }
    }
}
