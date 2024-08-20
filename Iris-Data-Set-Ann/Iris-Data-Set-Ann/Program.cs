using IrisDataSetAnn;

internal class Program
{
    private static void Main(string[] args)
    {
        //Creates the testing and trainging sets
        List<Iris> train = new List<Iris>();
        List<Iris> test = new List<Iris>();

        train.Add(new Iris("setosa", new double[] { 4.8, 3.1, 1.6, 0.2 }));
        train.Add(new Iris("setosa", new double[] { 5, 3.4, 1.6, 0.4 }));
        train.Add(new Iris("virginica", new double[] { 6.7, 3.1, 5.6, 2.4 }));
        train.Add(new Iris("setosa", new double[] { 4.8, 3.4, 1.9, 0.2 }));
        train.Add(new Iris("versicolor", new double[] { 5.8, 2.6, 4, 1.2 }));
        train.Add(new Iris("versicolor", new double[] { 5.8, 2.7, 3.9, 1.2 }));
        train.Add(new Iris("setosa", new double[] { 5.4, 3.4, 1.7, 0.2 }));
        train.Add(new Iris("versicolor", new double[] { 5.5, 2.6, 4.4, 1.2 }));
        train.Add(new Iris("setosa", new double[] { 5.1, 3.8, 1.6, 0.2 }));
        train.Add(new Iris("versicolor", new double[] { 6, 2.2, 4, 1 }));
        train.Add(new Iris("virginica", new double[] { 6.7, 3.3, 5.7, 2.1 }));
        train.Add(new Iris("virginica", new double[] { 6.4, 2.8, 5.6, 2.2 }));
        train.Add(new Iris("setosa", new double[] { 4.8, 3, 1.4, 0.1 }));
        train.Add(new Iris("setosa", new double[] { 5.4, 3.9, 1.3, 0.4 }));
        train.Add(new Iris("virginica", new double[] { 6.2, 2.8, 4.8, 1.8 }));
        train.Add(new Iris("setosa", new double[] { 5, 3.5, 1.3, 0.3 }));
        train.Add(new Iris("setosa", new double[] { 5.4, 3.7, 1.5, 0.2 }));
        train.Add(new Iris("setosa", new double[] { 5.2, 3.4, 1.4, 0.2 }));
        train.Add(new Iris("versicolor", new double[] { 6.3, 3.3, 4.7, 1.6 }));
        train.Add(new Iris("setosa", new double[] { 5.7, 3.8, 1.7, 0.3 }));
        train.Add(new Iris("virginica", new double[] { 6.5, 3, 5.8, 2.2 }));
        train.Add(new Iris("virginica", new double[] { 6.7, 3.3, 5.7, 2.5 }));
        train.Add(new Iris("versicolor", new double[] { 6.4, 2.9, 4.3, 1.3 }));
        train.Add(new Iris("virginica", new double[] { 5.8, 2.7, 5.1, 1.9 }));
        train.Add(new Iris("versicolor", new double[] { 6, 2.9, 4.5, 1.5 }));
        train.Add(new Iris("versicolor", new double[] { 6.9, 3.1, 4.9, 1.5 }));
        train.Add(new Iris("versicolor", new double[] { 7, 3.2, 4.7, 1.4 }));
        train.Add(new Iris("virginica", new double[] { 7.1, 3, 5.9, 2.1 }));
        train.Add(new Iris("setosa", new double[] { 5.5, 3.5, 1.3, 0.2 }));
        train.Add(new Iris("versicolor", new double[] { 5.6, 2.9, 3.6, 1.3 }));
        train.Add(new Iris("versicolor", new double[] { 5.6, 2.7, 4.2, 1.3 }));
        train.Add(new Iris("versicolor", new double[] { 6.3, 2.5, 4.9, 1.5 }));
        train.Add(new Iris("versicolor", new double[] { 5.5, 2.4, 3.8, 1.1 }));
        train.Add(new Iris("setosa", new double[] { 4.9, 3.1, 1.5, 0.1 }));
        train.Add(new Iris("virginica", new double[] { 7.7, 2.6, 6.9, 2.3 }));
        train.Add(new Iris("virginica", new double[] { 6.4, 2.8, 5.6, 2.1 }));
        train.Add(new Iris("setosa", new double[] { 5.1, 3.8, 1.9, 0.4 }));
        train.Add(new Iris("virginica", new double[] { 6, 3, 4.8, 1.8 }));
        train.Add(new Iris("virginica", new double[] { 6.8, 3, 5.5, 2.1 }));
        train.Add(new Iris("versicolor", new double[] { 5.6, 3, 4.1, 1.3 }));
        train.Add(new Iris("versicolor", new double[] { 6.7, 3.1, 4.7, 1.5 }));
        train.Add(new Iris("versicolor", new double[] { 5.6, 3, 4.5, 1.5 }));
        train.Add(new Iris("setosa", new double[] { 4.7, 3.2, 1.3, 0.2 }));
        train.Add(new Iris("setosa", new double[] { 4.4, 3.2, 1.3, 0.2 }));
        train.Add(new Iris("virginica", new double[] { 4.9, 2.5, 4.5, 1.7 }));
        train.Add(new Iris("versicolor", new double[] { 6.8, 2.8, 4.8, 1.4 }));
        train.Add(new Iris("virginica", new double[] { 7.4, 2.8, 6.1, 1.9 }));
        train.Add(new Iris("setosa", new double[] { 5.2, 4.1, 1.5, 0.1 }));
        train.Add(new Iris("virginica", new double[] { 6.2, 3.4, 5.4, 2.3 }));
        train.Add(new Iris("setosa", new double[] { 4.4, 2.9, 1.4, 0.2 }));
        train.Add(new Iris("virginica", new double[] { 7.7, 2.8, 6.7, 2 }));
        train.Add(new Iris("setosa", new double[] { 5.3, 3.7, 1.5, 0.2 }));
        train.Add(new Iris("setosa", new double[] { 5, 3.6, 1.4, 0.2 }));
        train.Add(new Iris("virginica", new double[] { 6.5, 3, 5.5, 1.8 }));
        train.Add(new Iris("versicolor", new double[] { 5.1, 2.5, 3, 1.1 }));
        train.Add(new Iris("virginica", new double[] { 6.1, 2.6, 5.6, 1.4 }));
        train.Add(new Iris("setosa", new double[] { 5.8, 4, 1.2, 0.2 }));
        train.Add(new Iris("versicolor", new double[] { 5, 2, 3.5, 1 }));
        train.Add(new Iris("virginica", new double[] { 6.3, 3.3, 6, 2.5 }));
        train.Add(new Iris("virginica", new double[] { 6.5, 3.2, 5.1, 2 }));
        train.Add(new Iris("versicolor", new double[] { 5.9, 3.2, 4.8, 1.8 }));
        train.Add(new Iris("versicolor", new double[] { 6.2, 2.2, 4.5, 1.5 }));
        train.Add(new Iris("virginica", new double[] { 6.3, 2.5, 5, 1.9 }));
        train.Add(new Iris("setosa", new double[] { 4.4, 3, 1.3, 0.2 }));
        train.Add(new Iris("virginica", new double[] { 6.9, 3.2, 5.7, 2.3 }));
        train.Add(new Iris("virginica", new double[] { 6.3, 3.4, 5.6, 2.4 }));
        train.Add(new Iris("versicolor", new double[] { 5.7, 2.9, 4.2, 1.3 }));
        train.Add(new Iris("setosa", new double[] { 5.1, 3.5, 1.4, 0.2 }));
        train.Add(new Iris("setosa", new double[] { 4.6, 3.4, 1.4, 0.3 }));
        train.Add(new Iris("versicolor", new double[] { 5.4, 3, 4.5, 1.5 }));
        train.Add(new Iris("setosa", new double[] { 4.6, 3.6, 1, 0.2 }));
        train.Add(new Iris("versicolor", new double[] { 6.5, 2.8, 4.6, 1.5 }));
        train.Add(new Iris("virginica", new double[] { 6.7, 2.5, 5.8, 1.8 }));
        train.Add(new Iris("virginica", new double[] { 5.8, 2.8, 5.1, 2.4 }));
        train.Add(new Iris("versicolor", new double[] { 6.6, 2.9, 4.6, 1.3 }));

        test.Add(new Iris("versicolor", new double[] { 5.7, 2.6, 3.5, 1 }));
        test.Add(new Iris("setosa", new double[] { 5.7, 4.4, 1.5, 0.4 }));
        test.Add(new Iris("virginica", new double[] { 7.2, 3.6, 6.1, 2.5 }));
        test.Add(new Iris("virginica", new double[] { 6.9, 3.1, 5.1, 2.3 }));
        test.Add(new Iris("virginica", new double[] { 6.5, 3, 5.2, 2 }));
        test.Add(new Iris("versicolor", new double[] { 5.7, 3, 4.2, 1.2 }));
        test.Add(new Iris("versicolor", new double[] { 6.3, 2.3, 4.4, 1.3 }));
        test.Add(new Iris("virginica", new double[] { 5.6, 2.8, 4.9, 2 }));
        test.Add(new Iris("setosa", new double[] { 5.1, 3.3, 1.7, 0.5 }));
        test.Add(new Iris("setosa", new double[] { 4.6, 3.2, 1.4, 0.2 }));
        test.Add(new Iris("versicolor", new double[] { 5.6, 2.5, 3.9, 1.1 }));
        test.Add(new Iris("setosa", new double[] { 4.9, 3, 1.4, 0.2 }));
        test.Add(new Iris("setosa", new double[] { 5.5, 4.2, 1.4, 0.2 }));
        test.Add(new Iris("setosa", new double[] { 4.5, 2.3, 1.3, 0.3 }));
        test.Add(new Iris("versicolor", new double[] { 5.2, 2.7, 3.9, 1.4 }));
        test.Add(new Iris("virginica", new double[] { 5.7, 2.5, 5, 2 }));
        test.Add(new Iris("virginica", new double[] { 6.3, 2.8, 5.1, 1.5 }));
        test.Add(new Iris("virginica", new double[] { 6.1, 3, 4.9, 1.8 }));
        test.Add(new Iris("versicolor", new double[] { 5.8, 2.7, 4.1, 1 }));
        test.Add(new Iris("virginica", new double[] { 7.9, 3.8, 6.4, 2 }));
        test.Add(new Iris("virginica", new double[] { 7.7, 3.8, 6.7, 2.2 }));
        test.Add(new Iris("versicolor", new double[] { 6.1, 3, 4.6, 1.4 }));
        test.Add(new Iris("versicolor", new double[] { 5.5, 2.4, 3.7, 1 }));
        test.Add(new Iris("setosa", new double[] { 4.6, 3.1, 1.5, 0.2 }));
        test.Add(new Iris("setosa", new double[] { 5.4, 3.4, 1.5, 0.4 }));
        test.Add(new Iris("setosa", new double[] { 4.9, 3.1, 1.5, 0.1 }));
        test.Add(new Iris("virginica", new double[] { 5.8, 2.7, 5.1, 1.9 }));
        test.Add(new Iris("versicolor", new double[] { 6.6, 3, 4.4, 1.4 }));
        test.Add(new Iris("setosa", new double[] { 5, 3, 1.6, 0.2 }));
        test.Add(new Iris("versicolor", new double[] { 5.9, 3, 4.2, 1.5 }));
        test.Add(new Iris("setosa", new double[] { 4.8, 3, 1.4, 0.3 }));
        test.Add(new Iris("versicolor", new double[] { 5.5, 2.3, 4, 1.3 }));
        test.Add(new Iris("setosa", new double[] { 4.7, 3.2, 1.6, 0.2 }));
        test.Add(new Iris("versicolor", new double[] { 6.2, 2.9, 4.3, 1.3 }));
        test.Add(new Iris("versicolor", new double[] { 6.7, 3.1, 4.4, 1.4 }));
        test.Add(new Iris("virginica", new double[] { 6.9, 3.1, 5.4, 2.1 }));
        test.Add(new Iris("setosa", new double[] { 5, 3.2, 1.2, 0.2 }));
        test.Add(new Iris("virginica", new double[] { 7.7, 3, 6.1, 2.3 }));
        test.Add(new Iris("versicolor", new double[] { 5.7, 2.8, 4.1, 1.3 }));
        test.Add(new Iris("virginica", new double[] { 6.3, 2.9, 5.6, 1.8 }));
        test.Add(new Iris("virginica", new double[] { 6, 2.2, 5, 1.5 }));
        test.Add(new Iris("setosa", new double[] { 5.4, 3.9, 1.7, 0.4 }));
        test.Add(new Iris("versicolor", new double[] { 5, 2.3, 3.3, 1 }));
        test.Add(new Iris("virginica", new double[] { 6.3, 2.7, 4.9, 1.8 }));
        test.Add(new Iris("versicolor", new double[] { 6.1, 2.9, 4.7, 1.4 }));
        test.Add(new Iris("setosa", new double[] { 5.2, 3.5, 1.5, 0.2 }));
        test.Add(new Iris("virginica", new double[] { 7.6, 3, 6.6, 2.1 }));
        test.Add(new Iris("setosa", new double[] { 4.8, 3.4, 1.6, 0.2 }));
        test.Add(new Iris("versicolor", new double[] { 6, 3.4, 4.5, 1.6 }));
        test.Add(new Iris("versicolor", new double[] { 4.9, 2.4, 3.3, 1 }));
        test.Add(new Iris("virginica", new double[] { 5.9, 3, 5.1, 1.8 }));
        test.Add(new Iris("setosa", new double[] { 5.1, 3.7, 1.5, 0.4 }));
        test.Add(new Iris("virginica", new double[] { 7.3, 2.9, 6.3, 1.8 }));
        test.Add(new Iris("setosa", new double[] { 5.1, 3.4, 1.5, 0.2 }));
        test.Add(new Iris("versicolor", new double[] { 6.1, 2.8, 4.7, 1.2 }));
        test.Add(new Iris("virginica", new double[] { 7.2, 3.2, 6, 1.8 }));
        test.Add(new Iris("versicolor", new double[] { 5.5, 2.5, 4, 1.3 }));
        test.Add(new Iris("versicolor", new double[] { 6.7, 3, 5, 1.7 }));
        test.Add(new Iris("virginica", new double[] { 6.4, 2.7, 5.3, 1.9 }));
        test.Add(new Iris("setosa", new double[] { 5.1, 3.8, 1.5, 0.3 }));
        test.Add(new Iris("setosa", new double[] { 5, 3.3, 1.4, 0.2 }));
        test.Add(new Iris("setosa", new double[] { 5, 3.5, 1.6, 0.6 }));
        test.Add(new Iris("setosa", new double[] { 5.1, 3.5, 1.4, 0.3 }));
        test.Add(new Iris("versicolor", new double[] { 6.1, 2.8, 4, 1.3 }));
        test.Add(new Iris("virginica", new double[] { 6.4, 3.2, 5.3, 2.3 }));
        test.Add(new Iris("versicolor", new double[] { 6.4, 3.2, 4.5, 1.5 }));
        test.Add(new Iris("versicolor", new double[] { 5.7, 2.8, 4.5, 1.3 }));
        test.Add(new Iris("virginica", new double[] { 6.8, 3.2, 5.9, 2.3 }));
        test.Add(new Iris("setosa", new double[] { 5, 3.4, 1.5, 0.2 }));
        test.Add(new Iris("versicolor", new double[] { 6, 2.7, 5.1, 1.6 }));
        test.Add(new Iris("virginica", new double[] { 6.4, 3.1, 5.5, 1.8 }));
        test.Add(new Iris("virginica", new double[] { 6.7, 3, 5.2, 2.3 }));
        test.Add(new Iris("virginica", new double[] { 7.2, 3, 5.8, 1.6 }));
        test.Add(new Iris("setosa", new double[] { 4.3, 3, 1.1, 0.1 }));
        test.Add(new Iris("setosa", new double[] { 4.9, 3.1, 1.5, 0.1 }));

        //loops through printing out current highest accuracy
        double accuracy = 0;
        NeuralNetwork nn;
        bool done = false;
        double maxAccuracy = 0;
        while (!done)
        {
            nn = new NeuralNetwork(new int[] { 4, 6, 3 });
            for (int epoch = 0; epoch < 1000; epoch++)
            {
                nn.Train(train);
            }
            accuracy = 0;
            foreach (Iris iris in test)
            {
                int actual = nn.IndexOfMaxValue(nn.CalculateOutputs(iris.data));
                int expected = iris.name switch
                {
                    "setosa" => 0,
                    "versicolor" => 1,
                    "virginica" => 2,
                    _ => throw new ArgumentException("Invalid iris name"),
                };
                if (expected == actual) accuracy++;
            }
            accuracy /= test.Count;
            //prints and updates current highest when condition is met
            if (accuracy > maxAccuracy)
            {
                maxAccuracy = accuracy;
                Console.WriteLine($"Accuracy: {accuracy}");
                nn.PrintOut();
                Console.WriteLine("\n");
            }
        }
    }
}