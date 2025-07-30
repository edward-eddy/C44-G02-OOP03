namespace Demo.Interfaces
{
    internal class MyType : IMyType
    {
        public double Salary { get; set; }

        public void MyFun()
        {
            Console.WriteLine("Hello From Interface Implemented Class");
        }
    }
}
