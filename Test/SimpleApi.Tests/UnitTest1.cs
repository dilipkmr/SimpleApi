using System;
using Xunit;

using SimpleApi;

namespace SimpleApi.Tests
{
    public class UnitTest1
    {
        ValuesController objValueController=new ValuesController();
        [Fact]
        public void Test1()
        {
            var ctr=objValueController.Get(1);
            Assert.Equal("Dilip",ctr);
        }
    }
}
