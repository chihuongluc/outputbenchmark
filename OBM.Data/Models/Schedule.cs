namespace OBM.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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

        [Required]
        [StringLength(4)]
        public string SubjectID { get; set; }

        public int? GroupOf { get; set; }

        public int? MaxSize { get; set; }

        public int? RoomID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TestDate { get; set; }

        [StringLength(10)]
        public string TestTime { get; set; }

        public virtual FinalTest FinalTest { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Register> Registers { get; set; }

        public virtual Room Room { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
