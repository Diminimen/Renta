namespace RentShoppingCenter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pavilions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pavilions()
        {
            Rent = new HashSet<Rent>();
            ShoppingCenter = new HashSet<ShoppingCenter>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PavilionID { get; set; }

        [Required]
        public string NameSC { get; set; }

        [Required]
        [StringLength(5)]
        public string PavilionNumber { get; set; }

        public int Floor { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public decimal Square { get; set; }

        public decimal CostMeter { get; set; }

        public decimal ValueAddedRatio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCenter> ShoppingCenter { get; set; }
    }
}
