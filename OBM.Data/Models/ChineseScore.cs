namespace OBM.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ChineseScore")]
    public partial class ChineseScore
    {
        [StringLength(10)]
        public string ID { get; set; }

        public virtual Score Score { get; set; }
    }
}