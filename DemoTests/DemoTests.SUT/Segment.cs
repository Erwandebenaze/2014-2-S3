using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTests.SUT
{
    public class Segment
    {
        int _beg;
        int _end;

        public Segment( int beg, int end )
        {
            // Normalization
            if( end < beg )
            {
                _beg = end;
                _end = beg;
            }
            else
            {
                _beg = beg;
                _end = end;
            }
        }

        public int Beg
        {
            get { return _beg; }
        }

        public int End 
        {
            get { return _end; }
        }

        public bool Contains( int point )
        {
            return point <= _end && point >= _beg;
        }

        public bool Intersect( Segment other )
        {
            return Contains( other.Beg ) || Contains( other.End )
                    || other.Contains( _beg ) || other.Contains( _end );
        }

    }
}
