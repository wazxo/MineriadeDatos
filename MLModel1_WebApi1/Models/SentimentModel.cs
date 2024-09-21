using Microsoft.ML.Data;
public class SentimentData
{
    [LoadColumn(0)]
    public string Text { get; set; }
    [LoadColumn(1)]
    public bool Label { get; set; }
}
public class SentimentPrediction : SentimentData
{
    public float Score { get; set; }
    public bool Prediction { get; set; }
}
