public partial class StudentsView : UserControl
{
    public StudentsView()
    {
        InitializeComponent();
        StudentGrid.ItemsSource = AttendanceDataService.Students.DefaultView;
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(NameBox.Text))
        {
            AttendanceDataService.AddStudent(NameBox.Text.Trim());
            StudentGrid.ItemsSource = AttendanceDataService.Students.DefaultView;
            NameBox.Text = "";
        }
    }
}
