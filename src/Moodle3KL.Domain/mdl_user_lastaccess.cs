namespace Moodle3KL.Domain
{
    public class mdl_user_lastaccess
    {
        public long id { get; set; }
        public long userid { get; set; }
        public long courseid { get; set; }
        public long timeaccess { get; set; }
    }
}