namespace Projekt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Owners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Owners()
        {
            Samochody = new HashSet<Samochody>();
        }

        [Key]
        [StringLength(11)]
        public string PESEL { get; set; }

        [Required]
        [StringLength(50)]
        public string Nazwisko { get; set; }

        [Required]
        [StringLength(50)]
        public string Imie { get; set; }

        [Column("Miejsce zamieszkania")]
        [StringLength(50)]
        public string Miejsce_zamieszkania { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Samochody> Samochody { get; set; }
    }
}
