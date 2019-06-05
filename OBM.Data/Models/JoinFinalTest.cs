namespace OBM.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("JoinFinalTest")]
    public partial class JoinFinalTest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JoinFinalTest()
        {
            Scores = new HashSet<Score>();
        }

        public string ID { get; set; }

        [Required]
        [StringLength(10)]
        public string StudentID { get; set; }

        public int SubjectID { get; set; }

        [Required]
        [StringLength(128)]
        public string FinalTestID { get; set; }

        public int Times { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public string Note { get; set; }

        public virtual FinalTest FinalTest { get; set; }

        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Score> Scores { get; set; }
    }
}