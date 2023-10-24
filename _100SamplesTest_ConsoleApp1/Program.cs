﻿
// This file was auto-generated by ML.NET Model Builder. 

using __100SamplesTest_ConsoleApp1;
using System.IO;

// Create single instance of sample data from first line of dataset for model input
var imageBytes = File.ReadAllBytes(@"D:\Skrivebord\Ny Data\Machinelerning hjemme data\Machinelearning data\Data Versuib 3\Abra\00c54790ddaebb6bdfd9d387c6a54559.jpg");
_100SamplesTest.ModelInput sampleData = new _100SamplesTest.ModelInput()
{
    ImageSource = imageBytes,
};

// Make a single prediction on the sample data and print results.
var sortedScoresWithLabel = _100SamplesTest.PredictAllLabels(sampleData);
Console.WriteLine($"{"Class",-40}{"Score",-20}");
Console.WriteLine($"{"-----",-40}{"-----",-20}");

foreach (var score in sortedScoresWithLabel)
{
    Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
}