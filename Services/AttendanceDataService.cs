public static class AttendanceDataService
{
    public static DataTable Students = new DataTable();
    public static DataTable Attendance = new DataTable();

    static AttendanceDataService()
    {
        Students.Columns.Add("Id", typeof(Guid));
        Students.Columns.Add("Name", typeof(string));

        Attendance.Columns.Add("StudentId", typeof(Guid));
        Attendance.Columns.Add("Date", typeof(DateTime));
        Attendance.Columns.Add("IsPresent", typeof(bool));
    }

    public static void AddStudent(string name)
    {
        Students.Rows.Add(Guid.NewGuid(), name);
    }

    public static void MarkAttendance(Guid studentId, DateTime date, bool present)
    {
        var row = Attendance.AsEnumerable().FirstOrDefault(r =>
            (Guid)r["StudentId"] == studentId && (DateTime)r["Date"] == date);

        if (row != null)
            row["IsPresent"] = present;
        else
            Attendance.Rows.Add(studentId, date, present);
    }

    public static DataTable GetAttendanceReport()
    {
        var report = new DataTable();
        report.Columns.Add("Student", typeof(string));
        report.Columns.Add("Attendance %", typeof(double));

        foreach (DataRow student in Students.Rows)
        {
            var id = (Guid)student["Id"];
            var total = Attendance.Select($"StudentId = '{id}'").Length;
            var present = Attendance.Select($"StudentId = '{id}' AND IsPresent = true").Length;

            double percentage = total > 0 ? (double)present / total * 100 : 0;
            report.Rows.Add(student["Name"], Math.Round(percentage, 2));
        }

        return report;
    }
}
