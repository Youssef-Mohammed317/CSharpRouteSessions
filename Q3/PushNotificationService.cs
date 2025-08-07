using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Q3
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(Recipient recipient, string message)
        {
            Console.WriteLine($"PushNotification To: {recipient.Name}\n {message}");
        }
    }
}
