namespace RentShoppingCenter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rent")]
    public partial class Rent
    {
        [Key]
        public int RentalID { get; set; }

        public int TenantID { get; set; }

        [Required]
        public string TitleShoppingCenter { get; set; }

        public int EmployeeID { get; set; }

        [Required]
        [StringLength(5)]
        public string PavilionNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Statuc { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartOfTheLease { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndOfLease { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Pavilions Pavilions { get; set; }

        public virtual Tenant Tenant { get; set; }
    }
}
