namespace OBM.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Register")]
    public partial class Register
    {
        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        [StringLength(10)]
        public string StudentID { get; set; }

        public int SubjectID { get; set; }

        [StringLength(128)]
        public string ScheduleID { get; set; }

        public virtual Schedule Schedule { get; set; }

        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Score Score { get; set; }
    }
}