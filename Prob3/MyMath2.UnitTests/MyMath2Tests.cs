using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Not sure why NUnit.Framework wont work.....
using NUnit.Framework;
using MyMathConsoleApp;

namespace MyMath2.UnitTests
{
    public class MyMath2Tests
    {
        Assert.That(MyMathConsoleApp.MyMath2.Add(101, 99), Is.EqualTo(200));

        [Test]
        public void Add_SumOutsideByteRange_ThrowsException()
        {
            Assert.That(() => MyMathConsoleApp.MyMath2.Add(101, 201), Add_SumOutsideByteRange_ThrowsException.Exception);
        }
    }
}
