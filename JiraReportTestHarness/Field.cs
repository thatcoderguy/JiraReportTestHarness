﻿namespace JiraReportTestHarness
{
    public class Field
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool custom { get; set; }
        public bool orderable { get; set; }
        public bool navigable { get; set; }
        public bool searchable { get; set; }
        public List<string> clauseNames { get; set; }
        public Schema schema { get; set; }
    }

    public class Schema
    {
        public string type { get; set; }
        public string custom { get; set; }
        public int customId { get; set; }
    }


}
