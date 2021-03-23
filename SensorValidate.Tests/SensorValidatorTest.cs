using System;
using System.Collections.Generic;

using Xunit;

namespace SensorValidate.Tests
{
    public class SensorValidatorTest
    {
        [Fact]
        public void ReportsErrorWhenSOCJumps() {
            Assert.False(SensorValidator.ValidateSOCreadings(
                new List<double>{0.0, 0.01, 0.5, 0.51}
            ));
        }
        
        [Fact]
        public void ReportsErrorWhenCurrentJumps() {
            Assert.False(SensorValidator.ValidateCurrentReadings(
                new List<double>{0.03, 0.03, 0.03, 0.33}
            ));
        }
        
        [Fact]
        public void ReportsErrorWhenSOCEmpty()
        {
           Assert.False(SensorValidator.ValidateSOCreadings(
            new List<double> { }
            ));
        }

        [Fact]
        public void ReportsErrorWhenCurrentEmpty()
        {
            Assert.False(SensorValidator.ValidateCurrentReadings(
            new List<double> { }
            ));
        }
    }
}
