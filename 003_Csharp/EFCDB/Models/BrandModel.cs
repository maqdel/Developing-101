using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace EFCDB.Models
{
    [Table("Brands", Schema = "dbo")]
    public class BrandModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Description { get; set; }

        [Required]
        public bool Enabled { get; set; }

        [Required]
        public DateTime CreatedIn { get; set; }

        [Required]
        public DateTime UpdatedIn { get; set; }

    }
}