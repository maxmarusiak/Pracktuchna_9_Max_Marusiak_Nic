public class EventManager
{
    public event EventHandler<StudentEventArgs> StudentAdded;
    public event EventHandler<StudentEventArgs> StudentRemoved;
    public event EventHandler<GroupReportEventArgs> ReportGenerated;

    public void OnStudentAdded(Student s) =>
        StudentAdded?.Invoke(this, new StudentEventArgs(s));

    public void OnStudentRemoved(Student s) =>
        StudentRemoved?.Invoke(this, new StudentEventArgs(s));

    public void OnReportGenerated(string report) =>
        ReportGenerated?.Invoke(this, new GroupReportEventArgs(report));
}
