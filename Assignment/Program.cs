namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            // Part 01 

            // Q01 : What is the primary purpose of an interface in C#?
            // Answer : b) To define a blueprint for a class

            // Q02 : Which of the following is NOT a valid access modifier for interface members in C#?
            // Answer :  a) private, b) protected, c) internal

            // Q03 : Can an interface contain fields in C#?
            // Answer : b) No

            // Q04 : In C#, can an interface inherit from another interface?
            // Answer : b) Yes, interfaces can inherit from multiple interfaces

            // Q05 : Which keyword is used to implement an interface in a class in C#?
            // Answer : a) inherit " : "

            // Q06 : Can an interface contain static methods in C#?
            // Answer : a) Yes

            // Q07 : In C#, can an interface have explicit access modifiers for its members?
            // Answer : b) No, all members are implicitly public.

            // Q08 : What is the purpose of an explicit interface implementation in C#?
            // Answer : b) To provide a clear separation between interface and class members

            // Q09 : In C#, can an interface have a constructor?
            // Answer : b) No, interfaces cannot have constructors

            // Q10 : How can a C# class implement multiple interfaces?
            // Answer : c) By separating interface names with commas 
            #endregion

            // Part 02

            #region Q01
            /*
                 Question 01:
                    Define an interface named IShape with a property Area and a method DisplayShapeInfo. 
                Create two interfaces, ICircle and IRectangle, that inherit from IShape. 
                Implement these interfaces in classes Circle and Rectangle. 
                Test your implementation by creating instances of both classes and displaying their shape information.
                 */

            //Circle circle = new Circle();
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle();
            //rectangle.DisplayShapeInfo(); 
            #endregion

            #region Q02
            /*
                 Question 02:
                    In this example, we start by defining the IAuthenticationService interface with two methods: 
                AuthenticateUser and AuthorizeUser. The BasicAuthenticationService class implements this interface 
                and provides the specific implementation for these methods.

                In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password
                with the stored credentials. It returns true if the user is authenticated and false otherwise. 
                The AuthorizeUser method checks if the user with the given username has the specified role. It returns true 
                if the user is authorized and false otherwise.

                In the Main method, we create an instance of the BasicAuthenticationService class and assign it to 
                the authService variable of type IAuthenticationService. We then call the AuthenticateUser and AuthorizeUser 
                methods using this interface reference.

                This implementation allows you to switch the authentication service implementation easily by creating a new class
                that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.
                 */



            //BasicAuthenticationService service = new BasicAuthenticationService();

            //IAuthenticationService authService = service;

            //authService.AuthenticateUser("Edward", "1234");
            //authService.AuthorizeUser("Ahmed", "1234"); 
            #endregion

        }
    }
}
