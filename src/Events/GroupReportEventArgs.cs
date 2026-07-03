public class GroupReportEventArgs : EventArgs
{
    public string Report { get; }
    public GroupReportEventArgs(string report) => Report = report;
}
