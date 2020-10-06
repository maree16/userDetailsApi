using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CandidateApi.Data
{
    public class Candidate : ICandidate
    {
        [Key]
        public int CandidateId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public int Age { get; set; }

        [Required]
        [Column(TypeName = "BIT")]
        public bool IsAvailable { get; set; }

        public Candidate() { 
        }
        public Candidate( string firstName, string lastname, int age, bool isAvailable)
        {
            FirstName = firstName;
            LastName = lastname;
            Age = age;
            IsAvailable = isAvailable;
         

        }
        public void ReturnNothing()
        { }

        public string GetFullName()
        { return FirstName + " " + LastName; }
    }
}
