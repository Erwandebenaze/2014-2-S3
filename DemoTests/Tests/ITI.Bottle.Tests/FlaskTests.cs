using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ITI.Bottle.Tests
{
    [TestFixture]
    public class FlaskTests
    {
        [Test]
        public void constructor_works_well()
        {
            int volume = 0;
            int maxCapacity = 1000;

            Flask flask = new Flask( maxCapacity, volume );

            Assert.AreEqual( 1000, flask.MaxCapacity );
            Assert.AreEqual( 0, flask.Volume );
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void constructor_with_negative_maxCapacity_should_throw_ArgumentException()
        {
            new Flask( -1, 0 );
        }

        [Test]
        public void constructor_with_max_capacity_less_than_volume_should_throw_ArgumentException()
        {
            Assert.Throws<ArgumentException>( () => new Flask( 100, 101 ) );
            Assert.Throws<ArgumentException>( delegate() { new Flask( 100, -1 ); } );
        }

        [Test]
        public void flask_can_be_empty_or_full()
        {
            int maxCapacity = 100;
            Flask flask = new Flask( maxCapacity, 0 );

            Assert.That( flask.IsEmpty );
            Assert.That( flask.IsFull, Is.False );

            flask.Fill();
            Assert.That( flask.IsFull );
            Assert.That( flask.IsEmpty, Is.False );

            flask.Empty();
            Assert.That( flask.IsEmpty );
            Assert.That( flask.IsFull, Is.False );
        }
    }
}
