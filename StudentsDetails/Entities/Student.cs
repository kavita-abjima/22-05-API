using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsDetails.Dto
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string FamilyName { get; set; } = null!;


        [MaxLength(200)]
        public string Address { get; set; } = null!;

        [Required]
        public long ContactNumber { get; set; }
    }
}
