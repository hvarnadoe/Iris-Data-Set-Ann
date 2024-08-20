namespace IrisDataSetAnn
{
    internal class NeuralNetwork
    {
        //holds the layers of the nural network
        Layer[] layers;
        //learning rate
        double lr = .26;

        public NeuralNetwork(int[] layerNumbers)
        {
            //creates layers based on input int array
            layers = new Layer[layerNumbers.Length - 1];
            for (int i = 0; i < layers.Length; i++)
            {
                layers[i] = new Layer(layerNumbers[i], layerNumbers[i + 1]);
            }
        }
        public double[] CalculateOutputs(double[] inputs)
        {
            //forward feeds data through layers to get output
            foreach (Layer layer in layers)
            {
                inputs = layer.CalculateOutputs(inputs);
            }
            return inputs;
        }
        int Classify(double[] inputs)
        {
            double[] outputs = CalculateOutputs(inputs);
            return IndexOfMaxValue(outputs);
        }
        public int IndexOfMaxValue(double[] inputs)
        {
            double max = inputs[0];
            int index = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] > max)
                {
                    max = inputs[i];
                    index = i;
                }
            }
            return index;
        }
        public void PrintOut()
        {
            foreach (Layer layer in layers)
            {
                layer.PrintWeights();
            }
        }

        public double Cost(List<Iris> dataSet)
        {
            //calculates the cost of the entire data set by finding the cost of each layer
            double cost = 0;
            foreach (Iris iris in dataSet)
            {
                double[] outputs = CalculateOutputs(iris.data);
                double[] expectedOutput = new double[] { 0, 0, 0 };
                int expected = iris.name switch
                {
                    "setosa" => 0,
                    "versicolor" => 1,
                    "virginica" => 2,
                    _ => throw new ArgumentException("Invalid iris name"),
                };
                expectedOutput[expected] = 1;
                Layer outputLayer = layers[layers.Length - 1];

                cost += outputLayer.NodeCost(outputs, expectedOutput);
            }
            return cost;
        }
        public void Train(List<Iris> dataSet)
        {
            //traings model using a gradient function
            const double epsilon = 0.0001;

            double originalCost = Cost(dataSet);

            for (int l = 0; l < layers.Length; l++)
            {
                Layer layer = layers[l];

                for (int nodeIn = 0; nodeIn < layer.numNodesIn; nodeIn++)
                {
                    for (int nodeOut = 0; nodeOut < layer.numNodesOut; nodeOut++)
                    {
                        //calculates how much a certain weight effects the cost
                        layer.weights[nodeIn, nodeOut] += epsilon;
                        double perturbedCost = Cost(dataSet);
                        layer.weights[nodeIn, nodeOut] -= epsilon;
                        //saves that number as the cost gradient
                        layer.weightCostGradient[nodeIn, nodeOut] = (perturbedCost - originalCost) / epsilon;
                    }
                }

                for (int i = 0; i < layer.biases.Length; i++)
                {
                    //does the same as for weights but with biases
                    layer.biases[i] += epsilon;
                    double perturbedCost = Cost(dataSet);
                    layer.biases[i] -= epsilon;
                    layer.biasCostGradient[i] = (perturbedCost - originalCost) / epsilon;
                }
            }

            ApplyGradients();
        }

        public void ApplyGradients()
        {
            //adjusts weights and biases by calculates gradients
            foreach (Layer layer in layers)
            {
                for (int nodeOut = 0; nodeOut < layer.numNodesOut; nodeOut++)
                {
                    layer.biases[nodeOut] -= layer.biasCostGradient[nodeOut] * lr;
                    for (int nodeIn = 0; nodeIn < layer.numNodesIn; nodeIn++)
                    {
                        layer.weights[nodeIn, nodeOut] -= layer.weightCostGradient[nodeIn, nodeOut] * lr;
                    }
                }
            }
        }
    }
}
