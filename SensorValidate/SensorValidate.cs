using System;
using System.Collections.Generic;

namespace SensorValidate
{
    public class SensorValidator
    {
        public static bool IsHigherThanMaxDelta(double value, double nextValue, double maxDelta) {
            if(nextValue - value > maxDelta) {
                return false;
            }
            return true;
        }
        
        public static bool ValidateSOCreadings(List<Double> values) {
            return ValidateReadings(values, 0.05);
        }
        
        public static bool ValidateCurrentReadings(List<Double> values) {
            return ValidateReadings(values, 0.1);
        }

        static bool ValidateReadings(List<Double> values, double maxDelta)
        {
            int lastButOneIndex = values.Count - 1;
            for (int i = 0; i < lastButOneIndex; i++)
            {
                if (!IsHigherThanMaxDelta(values[i], values[i + 1], maxDelta))
                {
                    return false;
                }
            }
            return true;
        } 
    }
}
