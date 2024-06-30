namespace SurveyAndVoting.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public ICollection<Survey> Surveys { get; set; }
        public ICollection<Option> Options { get; set; }
    }
}
