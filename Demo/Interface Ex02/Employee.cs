namespace Demo.Interface_Ex02
{
    internal class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        // Copy Constructor
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Age = employee.Age;
            Salary = employee.Salary;
        }

        public Employee() { }

        public object Clone()
        {
            return new Employee(this); // Syntax sugar
            //return new Employee { Id = this.Id, Name = this.Name, Age = this.Age, Salary = this.Salary };
        }

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
