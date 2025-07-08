using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PatientManagement.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Mobile { get; set; } = string.Empty;
        public string? Address { get; set; } = string.Empty;
        public string Symptoms { get; set; } = string.Empty;

        public List<Medicine> Medicines { get; set; } = new();
    }
}
