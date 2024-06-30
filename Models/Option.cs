namespace SurveyAndVoting.Models
{
    public class Option
    {
        public int SurveyId { get; set; }
        public int OptionId { get; set; }
        public string OptionText { get; set; }
        public Survey Survey { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
