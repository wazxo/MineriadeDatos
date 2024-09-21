﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
public partial class MLModel1
{
    /// <summary>
    /// model input class for MLModel1.
    /// </summary>
    #region model input class
    public class ModelInput
    {
        [ColumnName(@"Comentario")]
        public string Comentario { get; set; }

        [ColumnName(@"Sentimiento")]
        public string Sentimiento { get; set; }

    }

    #endregion

    /// <summary>
    /// model output class for MLModel1.
    /// </summary>
    #region model output class
    public class ModelOutput
    {
        [ColumnName(@"Comentario")]
        public float[] Comentario { get; set; }

        [ColumnName(@"Sentimiento")]
        public uint Sentimiento { get; set; }

        [ColumnName(@"Features")]
        public float[] Features { get; set; }

        [ColumnName(@"PredictedLabel")]
        public string PredictedLabel { get; set; }

        [ColumnName(@"Score")]
        public float[] Score { get; set; }

    }

    #endregion

    private static string MLNetModelPath = Path.GetFullPath("MLModel1.zip");

    public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

    /// <summary>
    /// Use this method to predict on <see cref="ModelInput"/>.
    /// </summary>
    /// <param name="input">model input.</param>
    /// <returns><seealso cref=" ModelOutput"/></returns>
    public static ModelOutput Predict(ModelInput input)
    {
        var predEngine = PredictEngine.Value;
        return predEngine.Predict(input);
    }

    private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
    {
        var mlContext = new MLContext();
        ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
        return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
    }
}
