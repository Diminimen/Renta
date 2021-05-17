namespace RentShoppingCenter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShoppingCenter")]
    public partial class ShoppingCenter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        public int NumbersOfPavilions { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        public decimal Cost { get; set; }

        public decimal ValueAddedRatio { get; set; }

        public int NunberOfFloors { get; set; }

        [StringLength(10)]
        public string Image { get; set; }

        public virtual Pavilions Pavilions { get; set; }
    }
}
