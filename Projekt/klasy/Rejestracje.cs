namespace Projekt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rejestracje")]
    public partial class Rejestracje
    {
        [Key]
        [StringLength(15)]
        public string Rejestracja { get; set; }

        [Column("Pierwsza Rejestracja", TypeName = "date")]
        public DateTime? Pierwsza_Rejestracja { get; set; }

        [Column("Ostatnia Rejestracja", TypeName = "date")]
        public DateTime? Ostatnia_Rejestracja { get; set; }

        [Column("Waznosc Rejestracji", TypeName = "date")]
        public DateTime? Waznosc_Rejestracji { get; set; }

        public DateTime Przedluzenie(DateTime data, int ile)
        {
            DateTime temp = data.AddYears(ile);
            return temp;
        }
    }
}
