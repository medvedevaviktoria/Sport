namespace Sport.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductManufacturer")]
    public partial class ProductManufacturer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductManufacturer()
        {
            Products = new HashSet<Product>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductManufacturerID { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductManufacturerName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
