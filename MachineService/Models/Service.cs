using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MachineService.Models
{
    public class Service
    {
        [Key]
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Type { get; set; }
        [ForeignKey("MachineID")]
        public Machine? Machine { get; set; }
        [Display(Name = "Machine ID")]
        public int MachineID { get; set; }
        [Range(1, 1000)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        [Display(Name = "Time in Days to Fix")]
        public int TimeInDays { get; set; }

    }
}
