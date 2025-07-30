using Demo.Interface_Ex02;

namespace Demo
{
    // 1. Class
    // 2. struct
    // 3. enum
    // 4. interface
    internal class Program
    {
        #region Interface Ex02
        //static void Print10Number(SeriesByTwo series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    series.Reset();
        //}
        //static void Print10Number(SeriesByThree series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    series.Reset();
        //}
        //static void Print10Number(SeriesByFour series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();
        //    }
        //    series.Reset();
        //}


        static void Print10Number(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current} ");
                series.Next();
            }
            series.Reset();
        }
        #endregion

        static void Main(string[] args)
        {
            #region Interface Ex01
            // Interfaces : Reference Type
            // Code Contract Between The Developer Wrote it And The Developer Uses It [Implementation]


            //IMyType myType = new IMyType;
            // Note : Can't Create Object From Any Interface

            //MyType myType = new MyType();
            //myType.Salary = 12000;
            //Console.WriteLine(myType.Salary);
            //myType.MyFun();
            //myType.Print();

            //IMyType Ref;
            // Ref --> Can Refer To Object From Any Class Which Implemented The Interface 'IMyType'
            //Ref = myType;

            //Console.WriteLine(Ref.Salary);
            //Ref.MyFun();
            //Ref.Print(); 
            #endregion

            #region Interface Ex02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();
            //SeriesByFour seriesByFour = new SeriesByFour();

            //Print10Number(seriesByTwo);
            //Print10Number(seriesByThree);
            //Print10Number(seriesByFour);

            //int[] Numbers = { 7, 6, 5, 4, 3, 2, 1, 8, 9 };

            //Array.Sort(Numbers);

            //foreach (int i in Numbers)
            //{
            //    Console.Write($"{i} ");
            //}

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){Id = 1, Name = "Edward", Age= 30, Salary = 12000},
            //    new Employee(){Id = 2, Name = "Ahmed",  Age= 27, Salary = 11000},
            //    new Employee(){Id = 3, Name = "Omar",   Age= 28, Salary = 13000}
            //};

            //Array.Sort(employees);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

            #region Interface Ex03
            //Car car = new Car();

            //car.Speed = 120;
            //car.Forward();

            //Airplane airplane = new Airplane();

            //IMoveable moveable = airplane;
            //IFlyable flyable = airplane;

            //moveable.Forward();
            //moveable.Backward();

            //flyable.Forward();
            //flyable.Backward(); 
            #endregion

            #region Shallow Copy Vs. Deep Copy
            // Shallow Copy Vs. Deep Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //string[] Arr01 = { "Ahmed", "Ali", "Omar" };
            //string[] Arr02 = { "Yassmin", "Mona", "Hend" };

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr02 = Arr01; // Shallow Copy
            //// Copy Identity
            //// { 1, 2, 3 } --> Has Two References Arr01, Arr02
            //// { 3, 4, 5 } --> Unreachable Object

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //// Any Reference Type ---> Identity (Address) + Object State [Data]

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]); // The Same

            //Arr02[0] = "Ahmed Amin";
            //Console.WriteLine(Arr01[0]); // The Same

            // Deep Copy : 

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr02 = (int[]) Arr01.Clone(); // Deep Copy
            //// Clone Method Will Copy The Object State Of The Caller
            //// Assign The New Object To Arr02, Will Generate New Identity

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");


            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]); // Will be Different


            //// string Copping : 

            //string[] Arr01 = { "Ahmed", "Ali", "Omar" };
            //string[] Arr02 = { "Yassmin", "Mona", "Hend" };

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //// Shallow Copy
            //Arr02 = Arr01;

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr02[0] = "Ahmed Amin";
            //Console.WriteLine(Arr01[0]); // The Same


            //// Deep Copy
            //Arr02 = (string[])Arr01.Clone();

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr02[1] = "Ahmed Amin";
            //Console.WriteLine(Arr01[1]); // Different

            // ---------------------------->

            // Deep Copy For StringBuilder

            //StringBuilder[] Arr01 = new StringBuilder[]
            //{
            //    new StringBuilder("Ahmed"),
            //    new StringBuilder("Ali"),
            //    new StringBuilder("Omar")
            //};
            //StringBuilder[] Arr02 = new StringBuilder[]
            //{
            //    new StringBuilder("Yassmin"),
            //    new StringBuilder("Mona"),
            //    new StringBuilder("Hend")
            //};

            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");


            //// Deep Copy
            //Arr02 = (StringBuilder[])Arr01.Clone();

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 : {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 : {Arr02.GetHashCode()}");

            //Arr02[0].Append("Ahmed Amin");
            //Console.WriteLine(Arr01[0]); // Different 
            #endregion

            #region ICloneable
            //Employee E01 = new Employee() { Id = 1, Name = "Edward", Age = 28, Salary = 12000 };
            //Employee E02 = new Employee() { Id = 2, Name = "Ahmed", Age = 28, Salary = 11000 };

            //E02 = E01; // Shallow Copy
            //E02 = (Employee)E01.Clone(); // Deep Copy
            //E02 = new Employee(E01); // Deep Copy With Copy Constructor

            //Console.WriteLine(E01.GetHashCode());
            //Console.WriteLine(E02.GetHashCode());
            //Console.WriteLine(E01);
            //Console.WriteLine(E02); 
            #endregion

            #region ICompareable
            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){Id = 1, Name = "Edward", Age= 30, Salary = 12000},
            //    new Employee(){Id = 2, Name = "Ahmed",  Age= 27, Salary = 11000},
            //    new Employee(){Id = 3, Name = "Omar",   Age= 28, Salary = 13000}
            //};

            //Array.Sort(employees);

            //int X = employees[0].CompareTo(employees[1]);
            // +ve  : Caller Greater Than Parameter
            // -ve  : Caller Less Than Parameter
            // 0    : Caller Equal Parameter

            //Console.WriteLine(X);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //} 
            #endregion

            #region IComparer
            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){Id = 1, Name = "Edward", Age= 30, Salary = 12000},
            //    new Employee(){Id = 2, Name = "Ahmed",  Age= 27, Salary = 11000},
            //    new Employee(){Id = 3, Name = "Omar",   Age= 28, Salary = 13000}
            //};


            //Array.Sort(employees, new EmployeeComparerSalary());
            //Array.Sort(employees, new EmployeeComparerNameLength());

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion

        }
    }
}
