// Program 3
// CIS 200-01
// Due: 4/3/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: LibraryMovie.cs
// This file creates a concrete LibraryMovie class that adds
// director and rating.
// LibraryMovie IS-A LibraryMediaItem
// Now Serializable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    [Serializable]
    public class LibraryMovie : LibraryMediaItem
    {
        public const decimal DAILYLATEFEEDVD = 1.00m; // DVD/VHS's daily late fee
        public const decimal DAILYLATEFEEBLU = 1.50m; // BluRay's daily late fee
        public const decimal MAXFEE = 25.00m;         // Max late fee

        public enum MPAARatings { G, PG, PG13, R, NC17, U }; // Possible movie ratings

        private string _director;       // The movie's director
        private MediaType _movieMedium; // The movie's medium

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theDuration >= 0
        //                theTitle,theCallNumber, and theDirector must not be null or empty
        // Postcondition: The movie has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, duration, director, medium, and rating. The
        //                item is not checked out.
        public LibraryMovie(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, double theDuration, String theDirector,
            MediaType theMedium, MPAARatings theRating) :
            base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
        {
            Director = theDirector;
            Medium = theMedium;
            Rating = theRating;
        }

        public string Director
        {
            // Precondition:  None
            // Postcondition: The director has been returned
            get
            {
                return _director;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The director has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _director = value.Trim();
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Director)}", value,
                        $"{nameof(Director)} must not be null or empty");
            }
        }

        public MPAARatings Rating
        {
            // Precondition:  None
            // Postcondition: The rating has been returned
            get;

            // Precondition:  None
            // Postcondition: The rating has been set to the specified value
            set;
        }

        public override MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The medium has been returned
            get
            {
                return _movieMedium;
            }

            // Precondition:  value from { DVD, BLURAY, VHS }
            // Postcondition: The medium has been set to the specified value
            set
            {
                // if (value >= MediaType.DVD && value <= MediaType.VHS)
                // OR
                if (value == MediaType.BLURAY || value == MediaType.DVD ||
                    value == MediaType.VHS)
                    _movieMedium = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}",
                        value, $"{nameof(Medium)} must be from {{DVD, BLURAY, VHS}}");
            }
        }

        // Precondition:  daysLate >= 0
        // Postcondition: The fee for returning the item the specified days late
        //                has been returned
        public override decimal CalcLateFee(int daysLate)
        {
            decimal lateFee = 0.0M; // Late movie fee

            ValidateDaysLate(daysLate);

            if (Medium == MediaType.BLURAY)
                lateFee = daysLate * DAILYLATEFEEBLU;
            else
                lateFee = daysLate * DAILYLATEFEEDVD;

            // Make sure to cap the late fee
            return Math.Min(lateFee, MAXFEE);
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"LibraryMovie{NL}Director: {Director}{NL}Rating: {Rating}{NL}" + 
                $"{base.ToString()}";
        }
    }
}
