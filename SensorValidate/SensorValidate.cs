using System;
using System.Collections.Generic;

namespace SensorValidate
{
    public class SensorValidator
    {
        public static bool IsValueDifferenceLowerThanMaxDelta(double value, double nextValue, double maxDelta) {
            if(IsReadingsNaN(value, nextValue) || nextValue - value > maxDelta) {
                return false;
            }
            return true;
        }
        
        public static bool ValidateSOCreadings(List<Double> values) {
            if(IsReadingsEmpty(values))
                return ValidateReadings(values, 0.05);
            return false;
        }
        
        public static bool ValidateCurrentReadings(List<Double> values) {
            if (IsReadingsEmpty(values))
                return ValidateReadings(values, 0.1);
            return false;
        }

        static bool ValidateReadings(List<Double> values, double maxDelta)
        {
            int lastButOneIndex = values.Count - 1;
            for (int i = 0; i < lastButOneIndex; i++)
            {
                if (!IsValueDifferenceLowerThanMaxDelta(values[i], values[i + 1], maxDelta))
                {
                    return false;
                }
            }
            return true;
        }
        
        static bool IsReadingsEmpty(List<Double> values)
        {
            if (values.Count > 0)
                return true;
            return false;
        }
        
        static bool IsReadingsNaN(double value, double nextValue)
        {
            if(Double.IsNaN(value) || Double.IsNaN(nextValue))
               return true;
             return false;
        }
    }
}
