namespace SurveyAndVoting.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
        public ICollection<Option> Options { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
