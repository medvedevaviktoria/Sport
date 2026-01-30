namespace Sport.AppModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UserID { get; set; }

        [Required]
        public string UserLogin { get; set; }

        [Required]
        public string UserPassword { get; set; }

        [Required]
        [StringLength(100)]
        public string UserSurname { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string UserPatronymic { get; set; }

        public int RoleID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        public virtual Role Role { get; set; }


        internal bool IsAdmin()
        {
            return this.RoleID == 2;
        }

        internal bool IsManager()
        {
            return this.RoleID == 3;
        }
    }
}
