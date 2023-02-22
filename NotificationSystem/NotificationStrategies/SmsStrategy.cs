namespace NotificationSystem.NotificationStrategies
{
    public class SmsStrategy : INotificationStrategy
    {
        public void Send()
        {
            Console.WriteLine("Sending notification sms");
        }
    }
}
