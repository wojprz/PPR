namespace Projekt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Samochody")]
    public partial class Samochody
    {
        [Column("PESEL Własciciela")]
        [Required]
        [StringLength(11)]
        public string PESEL_Własciciela { get; set; }

        [Key]
        [StringLength(15)]
        public string Rejestracja { get; set; }

        [Required]
        [StringLength(50)]
        public string Marka { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        public int Rocznik { get; set; }

        [Required]
        [StringLength(8)]
        public string Przebieg { get; set; }

        public virtual Owners Owners { get; set; }
    }
}
