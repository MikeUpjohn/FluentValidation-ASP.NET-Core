using System;
using System.Collections.Generic;
using fluent_validation_trial.Models.Enum;

namespace fluent_validation_trial.Models
{
    public class Applicant
    {
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public MaritalStatus? MaritalStatus { get; set; }
        public Nationality? Nationality { get; set; }
        public bool? HasChildren { get; set; }
        public int? NumberOfChildren { get; set; }
        public int? RetirementAge { get; set; }
        public string Telephone { get; set; }
        public List<AddressHistory> AddressHistory { get; set; }
    }
}
