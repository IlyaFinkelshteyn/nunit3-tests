using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nunit2Tests
{
    [TestFixture]
    public class MyTests
    {
        [Test]
        [Category("A")]
        public void TEST1()
        {
            Assert.AreEqual("a", "a");
        }

        [Test]
        [Category("A")]
        public void TEST2()
        {
            Assert.AreEqual("a", "a");
        }

        [Test]
        [Category("B")]
        public void TEST3()
        {
            Assert.AreEqual("a", "a");
        }
        
        [Test]
        [Category("B")]
        public void TEST4()
        {
            Assert.AreEqual("a", "a");
        }        
    }
}
