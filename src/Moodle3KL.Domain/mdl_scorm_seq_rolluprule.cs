namespace Moodle3KL.Domain
{
    public class mdl_scorm_seq_rolluprule
    {
        public long id { get; set; }
        public long scoid { get; set; }
        public string childactivityset { get; set; }
        public long minimumcount { get; set; }
        public double minimumpercent { get; set; }
        public string conditioncombination { get; set; }
        public string action { get; set; }
    }
}