namespace DVCP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
<<<<<<< HEAD
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Tbl_POST = new HashSet<Post>();
        }

        [Key]
        public int userid { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        [Required]
        [StringLength(30)]
        public string fullname { get; set; }

        [StringLength(20)]
        public string userrole { get; set; }

        public bool status { get; set; }

=======
        
>>>>>>> f431144958461c9c94d2ace9bfd8744807f6008a
    }
}
