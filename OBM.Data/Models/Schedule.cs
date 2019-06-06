namespace OBM.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Schedule")]
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            Registers = new HashSet<Register>();
        }

        public string ID { get; set; }

        [Required]
        [StringLength(128)]
        public string FinalTestID { get; set; }

        public int SubjectID { get; set; }

        public int RoomID { get; set; }

        [Required]
        [StringLength(10)]
        public string TestDate { get; set; }

        [Required]
        [StringLength(10)]
        public string TestTime { get; set; }

        public virtual FinalTest FinalTest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Register> Registers { get; set; }

        public virtual Room Room { get; set; }

        public virtual Subject Subject { get; set; }
    }
}