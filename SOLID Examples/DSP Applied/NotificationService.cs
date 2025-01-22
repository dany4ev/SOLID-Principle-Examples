using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.DSP_Applied
{
    public class NotificationService
    {
        private ILogger _logger;
        public NotificationService(ILogger logger)
        {
            _logger = logger;
        }
        public void Notify(string message)
        {
            // ... some notification logic ...
            _logger.LogMessage(message);
        }
    }
}
