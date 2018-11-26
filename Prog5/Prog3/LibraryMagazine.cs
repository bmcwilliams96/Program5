// Program 3
// CIS 200-01
// Due: 4/3/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: LibraryMagazine.cs
// This file creates a concrete LibraryMagazine class that adds
// no new data.
// LibraryMagazine IS-A LibraryPeriodical
// Now Serializable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    [Serializable]
    public class LibraryMagazine : LibraryPeriodical
    {
        public const decimal DAILYLATEFEE = 0.25m; // Magazine's daily late fee
        public const decimal MAXFEE = 20.00m;      // Max late fee

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theVolume >= 1,
        //                theNumber >= 1
        //                theTitle and theCallNumber must not be null or empty
        // Postcondition: The magazine has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, volume, and number. The item is not checked out.
        public LibraryMagazine(string theTitle, string thePublisher, int theCopyrightYear,
            int theLoanPeriod, string theCallNumber, int theVolume, int theNumber) :
            base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theVolume, theNumber)
        {
            // No new data to initialize
        }

        // Precondition:  daysLate >= 0
        // Postcondition: The fee for returning the item the specified days late
        //                has been returned
        public override decimal CalcLateFee(int daysLate)
        {
            decimal lateFee = 0.0M; // Late magazine fee

            ValidateDaysLate(daysLate);

            lateFee = daysLate * DAILYLATEFEE;

            // Make sure to cap the late fee
            return Math.Min(lateFee, MAXFEE);
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"LibraryMagazine{NL}{base.ToString()}";
        }
    }
}
