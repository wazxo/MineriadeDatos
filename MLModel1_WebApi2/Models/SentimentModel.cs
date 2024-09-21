using Microsoft.ML.Data;
public class SentimentData
{
    [LoadColumn(0)]
    public string Comentario { get; set; }
    [LoadColumn(1)]
    public string Sentimiento { get; set; }
}
public class SentimentPrediction : SentimentData
{
    public float Score { get; set; }
    public bool Prediction { get; set; }
}
