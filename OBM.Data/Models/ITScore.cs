namespace OBM.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITScore
    {
        public string ID { get; set; }

        public double? WindowInternet { get; set; }

        public double? Word { get; set; }

        public double? Excel { get; set; }

        public double? PowerPoint { get; set; }

        public virtual Score Score { get; set; }
    }
}
