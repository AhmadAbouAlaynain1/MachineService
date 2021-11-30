using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MachineService.Models
{
    public class Machine
    {
        [Key]
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        [Display(Name = "Date Released")]
        [DataType(DataType.Date)]
        public DateTime DateReleased { get; set; }
        [Range(1, 1000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public int Price { get; set; }
        [ForeignKey("ServiceID")]
        public Service? Service { get; set; }
        public int? ServiceID { get; set; }

    }
}