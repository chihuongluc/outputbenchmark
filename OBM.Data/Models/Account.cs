namespace OBM.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string DisplayName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int RoleID { get; set; }

        public virtual Role Role { get; set; }
    }
}