using System;
using Shouldly;
using Xunit;

namespace TravisRadiator.Tests
{
    public class StandInTestClass
    {
        [Fact]
        public void GarbageTest()
        {
            var testValue = true;
            
            testValue.ShouldBeTrue();
        }
    }
}