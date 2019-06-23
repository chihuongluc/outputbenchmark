namespace OBM.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Score
    {
        public string ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        public int? Times { get; set; }

        public double? Value { get; set; }

        public bool? Passed { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        public virtual ChineseScore ChineseScore { get; set; }

        public virtual ITScore ITScore { get; set; }

        public virtual Register Register { get; set; }

        public virtual ToeicScore ToeicScore { get; set; }
    }
}
