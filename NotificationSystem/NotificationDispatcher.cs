namespace NotificationSystem
{
    public class NotificationDispatcher
    {
        INotificationStrategy _strategy;

        public NotificationDispatcher(INotificationStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Send()
        {
            _strategy.Send();
        }
    }
}
