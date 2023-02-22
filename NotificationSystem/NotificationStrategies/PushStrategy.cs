namespace NotificationSystem.NotificationStrategies
{
    public class PushStrategy : INotificationStrategy
    {
        public void Send()
        {
            Console.WriteLine("Sending notification push");
        }
    }
}
