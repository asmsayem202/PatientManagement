using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatientManagement.Models
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;

        // Foreign Key
        public int PatientId { get; set; }

        // Navigation property
        public Patient? Patient { get; set; }
    }
}
