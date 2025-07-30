namespace Assignment.Question03
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Message For {recipient} Via Email: ");
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
