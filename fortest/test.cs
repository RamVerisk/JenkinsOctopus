using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jenkinsnunittestweb;
using NUnit.Framework;

namespace fortest
{
    [TestFixture]
    public class test
    {
        
            [TestCase]
            public void add()
            {
            sumkolaagi s = new sumkolaagi();
            Assert.AreEqual(15, s.summethod(5, 10));
            }
        }
    }

