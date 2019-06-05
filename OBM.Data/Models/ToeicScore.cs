namespace OBM.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ToeicScore")]
    public partial class ToeicScore
    {
        public string ID { get; set; }

        public int? Listening { get; set; }

        public int? Reading { get; set; }

        public virtual Score Score { get; set; }
    }
}