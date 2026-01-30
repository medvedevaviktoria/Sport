namespace Sport.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int ProductId { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductArticleNumber { get; set; }

        public int ProductNameId { get; set; }

        public int UnitTypeID { get; set; }

        public double ProductCost { get; set; }

        public double ProductMaxDiscountAmount { get; set; }

        public int ProductManufacturerID { get; set; }

        public int ProductSupplierID { get; set; }

        public int ProductCategoryID { get; set; }

        public double ProductDiscountAmount { get; set; }

        public int ProductQuantityInStock { get; set; }

        [StringLength(1000)]
        public string ProductDescription { get; set; }

        [StringLength(50)]
        public string ProductPhoto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual ProductManufacturer ProductManufacturer { get; set; }

        public virtual ProductName ProductName { get; set; }

        public virtual ProductSupplier ProductSupplier { get; set; }

        public virtual UnitType UnitType { get; set; }

        public bool IsNew()
        {
            return (ProductId == 0);
        }
    }
}
