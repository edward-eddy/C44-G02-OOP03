namespace Assignment.Question03
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Message For {recipient} Via SMS: ");
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
