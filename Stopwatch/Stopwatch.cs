using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        public double Interval { get; private set; }

        public DateTime StartTime
        {
            get { return _startTime; }
        }
        public DateTime EndTime
        {
            get { return _endTime; }
        }

        public void StartWatch()
        {
            if (_startTime != new DateTime(0))
                throw new InvalidOperationException("Watch is already running!");
            else
                _startTime = DateTime.UtcNow;
        }

        public void StopWatch()
        {
            _endTime = DateTime.UtcNow;
        }

        public void ProvidePeriod()
        {
            Interval = (EndTime - StartTime).TotalSeconds;
            _startTime = new DateTime(0);
            _endTime = new DateTime(0);
        }
    }
}
