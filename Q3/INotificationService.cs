using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Q3
{
    internal interface INotificationService
    {
        void SendNotification(Recipient recipient, string message);
    }
}
