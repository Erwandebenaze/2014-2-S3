using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DemoTests.SUT;


namespace DemoTests.SUT.Tests
{
    [TestFixture]
    public class SegmentTests
    {

        [Test]
        public void IntersectTests()
        {
            Segment s1 = new Segment( 10, 5 );
            Segment s2 = new Segment( 0, 50 );

            Assert.That( s1.Intersect( s2 ) );
            Assert.That( s2.Intersect( s1 ) );
        }


    }
}
