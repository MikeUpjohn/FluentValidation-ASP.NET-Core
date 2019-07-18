using fluent_validation_trial.Models.Enums;

namespace fluent_validation_trial.Models
{
    public class Customer
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
    }
}
