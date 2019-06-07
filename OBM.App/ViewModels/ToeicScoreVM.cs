namespace OBM.App.ViewModels
{
    public class ToeicScoreVM
    {
        public string ID { get; set; }
        public int? Listening { get; set; }
        public int? Reading { get; set; }
        public virtual ScoreVM Score { get; set; }
    }
}