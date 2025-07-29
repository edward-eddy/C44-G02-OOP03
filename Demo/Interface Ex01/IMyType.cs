namespace Demo.Interfaces
{
    internal interface IMyType
    {
        // What Can Write Inside The Interface
        // 1. Signature Of Property
        // 2. Signature Of Methods [Name, Parameter, Return Type]
        // 3. Default Implemented Methods [Fully Emplementse Methods]


        // 1. Signature Of Property
        double Salary { get; set; }

        // 2. Signature Of Methods [Name, Parameter, Return Type]
        void MyFun();

        // 3. Default Implemented Methods [Fully Emplementse Methods]
        void Print()
        {
            Console.WriteLine("Fully Emplementse Methods");
        }
    }
}
