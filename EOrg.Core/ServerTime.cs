using System;

namespace EOrg.Core
{
    public class ServerTime : IServerTime
    {
        private DateTime? _currentDateTime;
        public DateTime CurrentDateTime
        {
            get
            {
                if (_currentDateTime == null)
                    _currentDateTime = DateTime.UtcNow.AddHours(6);
                return _currentDateTime.Value;
            }
        }
    }
}
