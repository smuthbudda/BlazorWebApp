﻿
//// This file was auto-generated by ML.NET Model Builder. 

using ConsoleApp;

//// Create single instance of sample data from first line of dataset for model input
//MLData.ModelInput sampleData = new MLData.ModelInput()
//{
//    Col0 = @"This restaurant was wonderful.",
//};



//Console.WriteLine("Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...\n\n");


//Console.WriteLine($"Col0: {@"Crust is not good."}");
//Console.WriteLine($"Col1: {0F}");


//var sortedScoresWithLabel = MLData.PredictAllLabels(sampleData);
//Console.WriteLine($"{"Class",-40}{"Score",-20}");
//Console.WriteLine($"{"-----",-40}{"-----",-20}");

//foreach (var score in sortedScoresWithLabel)
//{
//    Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
//}

//Console.WriteLine("=============== End of process, hit any key to finish ===============");
//Console.ReadKey();

var sampleData = new MLData.ModelInput()
{
    Col0 = "My ass hurts"
};

// Load model and predict output of sample data
var result = MLData.Predict(sampleData);


// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");