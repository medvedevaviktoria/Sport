namespace Sport.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }

        public int OrderID { get; set; }

        public int OrderStatusID { get; set; }

        public int PickupPointID { get; set; }

        public DateTime OrderCreateDate { get; set; }

        public DateTime OrderDeliveryDate { get; set; }

        public int UserID { get; set; }

        public int OrderGetCode { get; set; }

        public virtual OrderStatu OrderStatu { get; set; }

        public virtual PickupPoint PickupPoint { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }

        internal bool IsNew()
        {
            return (OrderID == 0);
        }
    }
}
