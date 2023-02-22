// Two dispatchers with different strategies

using NotificationSystem;
using NotificationSystem.NotificationStrategies;

var notificationDispatcher = new NotificationDispatcher(new EmailStrategy());
notificationDispatcher.Send();

notificationDispatcher = new NotificationDispatcher(new PushStrategy());
notificationDispatcher.Send();

notificationDispatcher = new NotificationDispatcher(new SmsStrategy());
notificationDispatcher.Send();

// Wait for user

Console.ReadKey();