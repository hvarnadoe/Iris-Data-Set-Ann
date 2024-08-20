namespace IrisDataSetAnn
{
    internal class Iris
    {
        public double[] data { get; set; }
        public string name { get; set; }
        public Iris(string name, double[] data)
        {
            this.data = data;
            this.name = name;
        }
    }
}
