// Program 3
// CIS 200-01
// Due: 4/3/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: LibraryMediaItem.cs
// This file creates an abstract LibraryMediaItem class that adds
// media type and duration.
// LibraryMediaItem IS-A LibraryItem
// Now Serializable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    [Serializable]
    public abstract class LibraryMediaItem : LibraryItem
    {
        public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL }; // Possible media types

        private double _duration; // The item's duration (in minutes)

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theDuration >= 0
        //                theTitle and theCallNumber must not be null or empty
        // Postcondition: The library media item has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, and duration. The item is not checked out.
        public LibraryMediaItem(string theTitle, string thePublisher, int theCopyrightYear,
            int theLoanPeriod, string theCallNumber, double theDuration) :
            base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Duration = theDuration;
        }

        // Abstract property header
        public abstract MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The medium has been returned
            get;

            // Precondition:  Varies - See concrete implementation
            // Postcondition: The medium has been set to the specified value
            set;
        }

        public double Duration
        {
            // Precondition:  None
            // Postcondition: The duration has been returned
            get
            {
                return _duration;
            }

            // Precondition:  value >= 0
            // Postcondition: The duration has been set to the specified value
            set
            {
                if (value >= 0)
                    _duration = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Duration)}", value,
                        $"{nameof(Duration)} must be >= 0");
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"Duration: {Duration}{NL}Medium: {Medium}{NL}{base.ToString()}";
        }
    }
}
