using System;
using System.Collections.Generic;

namespace InterviewCake
{
    public class TempTracker
    {
        private int? _max;

        private int? _min;

        private double _mean;

        private int? _mode;

        private int _total;

        private int _numberOfReadings;
        private int[] _occurrences = new int[111];  // Array of 0s at indices 0..110
        private int _maxOccurrences;

        public void addTemperature(int temperature)
        {
            _occurrences[temperature]++;
            if (_occurrences[temperature] > _maxOccurrences)
            {
                _mode = temperature;
                _maxOccurrences = _occurrences[temperature];
            }

            // For mean
            _numberOfReadings++;
            _total += temperature;
            _mean = (double)_total / _numberOfReadings;

            if (_max == null || temperature > _max)
            {
                _max = temperature;
            }

            if (_min == null || temperature < _min)
            {
                _min = temperature;
            }
        }

        public int? GetMax()
        {
            return _max;
        }

        public int? GetMin()
        {
            return _min;
        }

        public double? GetMean()
        {
            return _mean;
        }

        public int? GetMode()
        {
            return _mode;
        }
    }
}
