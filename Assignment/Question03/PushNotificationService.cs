namespace Assignment.Question03
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Message For {recipient} Via Push Notification Service: ");
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
