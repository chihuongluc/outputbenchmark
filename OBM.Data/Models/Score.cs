namespace OBM.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Score")]
    public partial class Score
    {
        [StringLength(10)]
        public string ID { get; set; }

        public int Times { get; set; }

        public double? Value { get; set; }

        public virtual ChineseScore ChineseScore { get; set; }

        public virtual ITScore ITScore { get; set; }

        public virtual Register Register { get; set; }

        public virtual ToeicScore ToeicScore { get; set; }
    }
}