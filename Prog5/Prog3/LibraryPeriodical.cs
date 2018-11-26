// Program 3
// CIS 200-01
// Due: 4/3/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: LibraryPeriodical.cs
// This file creates an abstract LibraryPeriodical class that adds
// volume and number.
// LibraryPeriodical IS-A LibraryItem
// Now Serializable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    [Serializable]
    public abstract class LibraryPeriodical : LibraryItem
    {
        private int _volume; // The periodical's volume
        private int _number; // The periodical's number

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theVolume >= 1,
        //                theNumber >= 1
        //                theTitle and theCallNumber must not be null or empty
        // Postcondition: The library periodical has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, volume, and number. The item is not checked out.
        public LibraryPeriodical(string theTitle, string thePublisher, int theCopyrightYear,
            int theLoanPeriod, string theCallNumber, int theVolume, int theNumber) :
            base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Volume = theVolume;
            Number = theNumber;
        }

        public int Volume
        {
            // Precondition:  None
            // Postcondition: The volume has been returned
            get
            {
                return _volume;
            }

            // Precondition:  value >= 1
            // Postcondition: The volume has been set to the specified value
            set
            {
                if (value >= 1)
                    _volume = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Volume)}", value,
                        $"{nameof(Volume)} must be >= 1");
            }
        }

        public int Number
        {
            // Precondition:  None
            // Postcondition: The number has been returned
            get
            {
                return _number;
            }

            // Precondition:  value >= 1
            // Postcondition: The number has been set to the specified value
            set
            {
                if (value >= 1)
                    _number = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Number)}", value,
                        $"{nameof(Number)} must be >= 1");
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Volume: {Volume}{NL}Number: {Number}{NL}{base.ToString()}";
        }
    }
}
