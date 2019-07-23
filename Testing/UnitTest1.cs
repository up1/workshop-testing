using System;
using Xunit;
using WorkshopNTL.Controllers;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var p = new ValuesController();
            Assert.True(p.check());
        }
    }
}
