public partial class AttendanceView : UserControl
{
    public AttendanceView()
    {
        InitializeComponent();
        AttendanceList.ItemsSource = AttendanceDataService.Students.AsEnumerable().Select(row => new
        {
            Id = row["Id"],
            Name = row["Name"]
        }).ToList();
    }

    private void Status_Changed(object sender, RoutedEventArgs e)
    {
        var check = sender as CheckBox;
        Guid studentId = (Guid)check.Tag;
        var date = AttendanceDate.SelectedDate ?? DateTime.Now;

        AttendanceDataService.MarkAttendance(studentId, date, check.IsChecked == true);
    }
}
