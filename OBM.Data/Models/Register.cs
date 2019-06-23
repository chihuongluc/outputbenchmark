namespace OBM.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Register
    {
        public string ID { get; set; }

        [Required]
        [StringLength(10)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(4)]
        public string SubjectID { get; set; }

        [StringLength(128)]
        public string ScheduleID { get; set; }

        public virtual Schedule Schedule { get; set; }

        public virtual Student Student { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Score Score { get; set; }
    }
}
