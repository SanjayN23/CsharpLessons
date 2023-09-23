using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

    public class Emp
    {
        [Key]
        public int eno { get; set; }

        [Required]
    [StringLength(20)]
    [MinLength(3,ErrorMessage ="Name must be between 3 and 20 chars")]
    public string name { get; set; }
    
    [Required]
    [Range(1000,500000)]
    public Decimal salary { get; set; }

    [Required]
    [StringLength(20,ErrorMessage ="city must be between 3 and 20 char")]
    public string city { get; set; }
    }

