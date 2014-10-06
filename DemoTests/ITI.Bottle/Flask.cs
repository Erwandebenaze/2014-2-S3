using System;

namespace ITI.Bottle
{
    public class Flask
    {
        static int _totalFlaskCount;
        readonly int _maxCapacity;
        int _volume;

        /// <summary>
        /// Initializes a new instance of the <see cref="Flask"/> class.
        /// </summary>
        /// <param name="maxCapacity">In milliliter. Must be greater than 0.</param>
        /// <param name="volume">In milliliter. Must be greater or equal to 0.</param>
        public Flask( int maxCapacity, int volume )
        {
            if( volume > maxCapacity ) throw new ArgumentException( "Volume must be lower or equal to maximum capacity." );
            if( maxCapacity <= 0 ) throw new ArgumentException( "Maximum capacity must be greater than 0", "maxCapacity" );
            if( volume < 0 ) throw new ArgumentException( "Volume must be greater or equal to 0", "volume" );
            _maxCapacity = maxCapacity;
            _volume = volume;
            _totalFlaskCount++;
        }

        /// <summary>
        /// Initializes a new empty instance of the <see cref="Flask"/> class.
        /// </summary>
        /// <param name="maxCapacity">In milliliter. Must be greater than 0.</param>
        public Flask( int maxCapacity )
            : this( maxCapacity, 0 )
        {
        }

        public Flask()
            : this( 1000 )
        {
        }

        public static int TotalFlaskCount
        {
            get { return _totalFlaskCount; }
        }

        #region Volume Management

        /// <summary>
        /// Gets the current volume of this flask (in milliliter).
        /// </summary>
        public int Volume
        {
            get { return _volume; }
        }

        /// <summary>
        /// Gets the maximal capacity of this flask (in millililter).
        /// </summary>
        public int MaxCapacity
        {
            get { return _maxCapacity; }
        }

        /// <summary>
        /// Totally fills this flask.
        /// </summary>
        public void Fill()
        {
            _volume = _maxCapacity;
        }

        /// <summary>
        /// Totally empties this flask.
        /// </summary>
        public void Empty()
        {
            _volume = 0;
        }

        /// <summary>
        /// Changes the current <see cref="Volume"/>.
        /// </summary>
        /// <param name="deltaMilliliter">Number of milliliter to add or remove.</param>
        public void ChangeVolume( int deltaMilliliter )
        {
            _volume += deltaMilliliter;
            if( _volume < 0 ) _volume = 0;
            if( _volume > _maxCapacity ) _volume = _maxCapacity;
        }

        /// <summary>
        /// Gets whether this flask is empty.
        /// </summary>
        public bool IsEmpty
        {
            get { return _volume == 0; }
        }

        /// <summary>
        /// Gets whether this flask is full.
        /// </summary>
        public bool IsFull
        {
            get { return _volume == _maxCapacity; }
        }

        #endregion

        #region External aspects management
        #endregion
    }
}
