using MyMLApp;

var sampleData = new SentimentModel.ModelInput()
{
    Col0 = "This restaurant was wonderful"
    
};

var result = SentimentModel.Predict(sampleData);

var sentiment = result.Prediction == 1 ? "Positive" : "Negative";

Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");