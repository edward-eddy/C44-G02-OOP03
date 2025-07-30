namespace Assignment.Question01
{
    internal class Rectangle : IRectangle
    {
        public decimal Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Rectangle Shape Info");
        }
    }
}
