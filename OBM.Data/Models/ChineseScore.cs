namespace OBM.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChineseScore
    {
        public string ID { get; set; }

        public virtual Score Score { get; set; }
    }
}
