namespace OBM.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Score")]
    public partial class Score
    {
        public string ID { get; set; }

        [StringLength(128)]
        public string JoinFinalTestID { get; set; }

        public double? Value { get; set; }

        public virtual ChineseScore ChineseScore { get; set; }

        public virtual ITScore ITScore { get; set; }

        public virtual JoinFinalTest JoinFinalTest { get; set; }

        public virtual ToeicScore ToeicScore { get; set; }
    }
}