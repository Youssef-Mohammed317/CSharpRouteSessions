using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Q3
{
    internal class SmsNotificationService: INotificationService
    {
        public void SendNotification(Recipient recipient, string message)
        {
            Console.WriteLine($"SMS To: {recipient.Name}\n {message}");
        }
    }
}
