namespace Moodle3KL.Domain
{
    public class mdl_survey_answers
    {
        public long id { get; set; }
        public long userid { get; set; }
        public long survey { get; set; }
        public long question { get; set; }
        public long time { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
    }
}