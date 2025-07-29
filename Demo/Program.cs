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





        }
    }
}
