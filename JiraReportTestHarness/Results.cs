namespace JiraReportTestHarness
{
    public class Results
    {
        public string expand { get; set; }
        public int startAt { get; set; }

        public int maxResults { get; set; }
        public int total { get; set; }
        public List<string> issues { get; set; }
    }
}