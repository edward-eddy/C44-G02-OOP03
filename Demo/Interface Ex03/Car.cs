namespace Demo.Interface_Ex03
{
    internal class Car : IMoveable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Move Backward");
        }

        public void Forward()
        {
            Console.WriteLine("Move Forward");
        }

        public void Left()
        {
            Console.WriteLine("Move Left");
        }

        public void Right()
        {
            Console.WriteLine("Move Right");
        }
    }
}
