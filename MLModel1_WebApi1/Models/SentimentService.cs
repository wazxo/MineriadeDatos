using Microsoft.ML;
using System.IO;
public class SentimentService
{
    private readonly PredictionEngine<SentimentData,
    SentimentPrediction> _predictionEngine;
    public SentimentService()
    {
        var context = new MLContext();
        ITransformer model =
        context.Model.Load("MLModel1.zip", out _);
        _predictionEngine =
        context.Model.CreatePredictionEngine<SentimentData,
        SentimentPrediction>(model);
    }
    public SentimentPrediction Predict(string text)
    {
        var input = new SentimentData { Text = text };
        return _predictionEngine.Predict(input);
    }
}
