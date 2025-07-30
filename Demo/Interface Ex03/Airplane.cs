namespace Demo.Interface_Ex03
{
    internal class Airplane : IMoveable, IFlyable
    {
        int IMoveable.Speed { get; set; }
        int IFlyable.Speed { get; set; }

        void IMoveable.Backward()
        {
            Console.WriteLine("Move Backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("Fly Backward");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("Move Backward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Fly Backward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("Move Backward");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("Fly Backward");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("Move Backward");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("Fly Backward");
        }
    }
}
