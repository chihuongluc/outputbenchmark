namespace OBM.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account
    {
        [Key]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int RoleID { get; set; }

        public virtual Role Role { get; set; }
    }
}
