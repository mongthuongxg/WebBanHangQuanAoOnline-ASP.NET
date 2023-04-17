namespace BanHangOnline.Models.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ward")]
    public partial class Ward
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ward()
        {
            Customers = new HashSet<Customer>();
        }

        public int WardId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int DistrictId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customers { get; set; }

        public virtual District District { get; set; }
    }
}
