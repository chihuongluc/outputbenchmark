namespace OBM.App.ViewModels
{
    public class ITScoreVM
    {
        public string ID { get; set; }
        public double? WindowInternet { get; set; }
        public double? Word { get; set; }
        public double? Excel { get; set; }
        public double? PowerPoint { get; set; }
        public virtual ScoreVM Score { get; set; }
    }
}