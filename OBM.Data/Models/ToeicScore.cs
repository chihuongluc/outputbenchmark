namespace OBM.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ToeicScore
    {
        public string ID { get; set; }

        public int? Listening { get; set; }

        public int? Reading { get; set; }

        public virtual Score Score { get; set; }
    }
}
