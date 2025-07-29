namespace Demo.Interface_Ex02
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object? obj)
        {
            Employee employee = (Employee)obj;
            if (employee.Salary < this.Salary) return -1;
            if (employee.Salary > this.Salary) return 1;
            return 0;

        }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Age : {Age}, Salary : {Salary}";
        }
    }
}
