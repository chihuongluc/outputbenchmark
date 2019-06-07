namespace OBM.App.ViewModels
{
    public class ScoreVM
    {
        public string ID { get; set; }
        public int Times { get; set; }
        public double? Value { get; set; }
        public virtual ChineseScoreVM ChineseScore { get; set; }
        public virtual ITScoreVM ITScore { get; set; }
        public virtual RegisterVM Register { get; set; }
        public virtual ToeicScoreVM ToeicScore { get; set; }
    }
}