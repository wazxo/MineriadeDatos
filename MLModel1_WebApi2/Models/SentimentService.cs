using Microsoft.ML;
using Microsoft.ML.Data;
using System.IO;
using System.Numerics;

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
    public class SentimentPrediction
    {
        public VBuffer<float> Score { get; set; }
    }

    public SentimentPrediction Predict(string text)
    {
        var input = new SentimentData { Comentario = text };
        var prediction = _predictionEngine.Predict(input);
        return new SentimentPrediction { Score = prediction.Score };
    }
}
