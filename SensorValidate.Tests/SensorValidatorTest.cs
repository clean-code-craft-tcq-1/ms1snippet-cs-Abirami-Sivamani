using System;
using System.Collections.Generic;

using Xunit;

namespace SensorValidate.Tests
{
    public class SensorValidatorTest
    {
        [Fact]
        public void reportsErrorWhenSOCjumps() {
            Assert.False(SensorValidator.ValidateSOCreadings(
                new List<double>{0.0, 0.01, 0.5, 0.51}
            ));
        }
        
        [Fact]
        public void reportsErrorWhenCurrentjumps() {
            Assert.False(SensorValidator.ValidateCurrentReadings(
                new List<double>{0.03, 0.03, 0.03, 0.33}
            ));
        }
    }
}
