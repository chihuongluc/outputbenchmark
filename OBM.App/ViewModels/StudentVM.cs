using System.Collections.Generic;

namespace OBM.App.ViewModels
{
    public class StudentVM
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Birthplace { get; set; }
        public string Course { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool? PassForeignLanguage { get; set; }
        public bool? PassInformationTechnology { get; set; }
        public virtual ICollection<RegisterVM> Registers { get; set; }
    }
}