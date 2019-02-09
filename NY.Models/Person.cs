

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NY.Models
{
    [Table("Persons", Schema = "dbo")]
    public class Person
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumnber { get; set; }
        public DateTime InscriptionDate { get; set; }
        public string Publisher { get; set; }
        public bool Isuser { get; set; }
        public string MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }
        public string MyProperty3 { get; set; }
        public string MyProperty4 { get; set; }




        [NotMapped]
        public int Age => CalculateAge(this.DateOfBirth);
        [NotMapped]
        public string ThisPersonName
        {
            get
            {
                return string.Concat(this.Name + " " + this.LastName);
            }
        }
        [NotMapped]
        private static Func<DateTime, int> CalculateAge = 
            (dateOfBirth)
       =>
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        };
    }
}
