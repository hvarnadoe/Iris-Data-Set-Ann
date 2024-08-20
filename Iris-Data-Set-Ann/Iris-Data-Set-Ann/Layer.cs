namespace IrisDataSetAnn
{
    internal class Layer
    {
        public int numNodesIn, numNodesOut;
        public double[,] weights;
        public double[] biases;
        public double[,] weightCostGradient;
        public double[] biasCostGradient;
        public Layer(int numNodesIn, int numNodesOut)
        {
            this.numNodesIn = numNodesIn;
            this.numNodesOut = numNodesOut;

            weights = new double[numNodesIn, numNodesOut];
            biases = new double[numNodesOut];
            weightCostGradient = new double[numNodesIn, numNodesOut];
            biasCostGradient = new double[numNodesOut];
            //initialized weights and biases randomly
            Random rand = new Random();
            for (int i = 0; i < numNodesIn; i++)
            {
                for (int j = 0; j < numNodesOut; j++)
                {
                    weights[i, j] = (rand.NextDouble()) * 2 - 1;
                }
            }
            for (int i = 0; i < numNodesOut; i++)
            {
                biases[i] = (rand.NextDouble()) * 2 - 1;
            }

        }

        public double[] CalculateOutputs(double[] inputs)
        {
            //takes dot product of inputs and weights
            double[] outputs = new double[numNodesOut];

            for (int nodeOut = 0; nodeOut < numNodesOut; nodeOut++)
            {
                double output = biases[nodeOut];
                for (int nodeIn = 0; nodeIn < numNodesIn; nodeIn++)
                {
                    output += inputs[nodeIn] * weights[nodeIn, nodeOut];
                }
                outputs[nodeOut] = ActivationFunction(output);
            }
            return outputs;
        }
        public double ActivationFunction(double weightedInput)
        {
            //sigmoid function
            return 1 / (1 + Math.Exp(-weightedInput));
        }

        public double NodeCost(double[] output, double[] expectedOutput)
        {
            //finds cost of current layer
            double cost = 0;
            for (int i = 0; i < output.Length; i++)
            {
                double error = output[i] - expectedOutput[i];
                error *= error;
                cost += error / 2;
            }
            return cost;
        }
        public void PrintWeights()
        {
            //used for saving data for GUI program
            Console.WriteLine("Weights: ");
            for (int nodeOut = 0; nodeOut < numNodesOut; nodeOut++)
            {
                for (int nodeIn = 0; nodeIn < numNodesIn; nodeIn++)
                {
                    Console.Write(weights[nodeIn, nodeOut] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Biases: ");
            for (int i = 0; i < numNodesOut; i++)
            {
                Console.Write(biases[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
