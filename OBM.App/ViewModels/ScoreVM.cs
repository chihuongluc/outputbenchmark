﻿namespace OBM.App.ViewModels
{
    public class ScoreVM
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public int Times { get; set; }
        public double? Value { get; set; }
        public bool? Passed { get; set; }
        public string Note { get; set; }
        public virtual ChineseScoreVM ChineseScore { get; set; }
        public virtual ITScoreVM ITScore { get; set; }
        public virtual RegisterVM Register { get; set; }
        public virtual ToeicScoreVM ToeicScore { get; set; }
    }
}