public partial class ReportsView : UserControl
{
    public ReportsView()
    {
        InitializeComponent();
    }

    private void Generate_Click(object sender, RoutedEventArgs e)
    {
        ReportGrid.ItemsSource = AttendanceDataService.GetAttendanceReport().DefaultView;
    }
}
