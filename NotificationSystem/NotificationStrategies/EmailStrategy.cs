namespace NotificationSystem.NotificationStrategies
{
    public class EmailStrategy : INotificationStrategy
    {
        public void Send()
        {
            Console.WriteLine("Sending email notification");
        }
    }
}
