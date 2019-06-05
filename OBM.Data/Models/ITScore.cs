namespace OBM.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ITScore")]
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