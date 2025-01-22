using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.DIP_Violation
{
    public class NotificationService
    {
        private ConsoleLogger _logger = new ConsoleLogger();
        public void Notify(string message)
        {
            // ... some notification logic ...
            _logger.LogMessage(message);
        }
    }
}
