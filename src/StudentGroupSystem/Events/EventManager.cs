namespace StudentGroupSystem.Events
{
    public class EventManager
    {
        public event EventHandler<StudentEventArgs> StudentAdded;
        public event EventHandler<StudentEventArgs> StudentRemoved;
        public event EventHandler<GroupReportEventArgs> ReportGenerated;

        public void RaiseStudentAdded(Student s) =>
            StudentAdded?.Invoke(this, new StudentEventArgs(s));

        public void RaiseStudentRemoved(Student s) =>
            StudentRemoved?.Invoke(this, new StudentEventArgs(s));

        public void RaiseReportGenerated(string report) =>
            ReportGenerated?.Invoke(this, new GroupReportEventArgs(report));
    }
}

