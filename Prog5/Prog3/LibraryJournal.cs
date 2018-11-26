// Program 3
// CIS 200-01
// Due: 4/3/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: LibraryJournal.cs
// This file creates a concrete LibraryJournal class that adds
// discipline and editor.
// LibraryJournal IS-A LibraryPeriodical
// Now Serializable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    [Serializable]
    public class LibraryJournal : LibraryPeriodical
    {
        public const decimal DAILYLATEFEE = 0.75m; // Journal's daily late fee

        private string _discipline; // The journal's discipline
        private string _editor;     // The journal's editor

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theVolume >= 1,
        //                theNumber >= 1
        //                theTitle, theCallNumber, theDiscipline, and theEditor must not be null or empty
        // Postcondition: The journal has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, volume, number, discipline, and editor. The
        //                item is not checked out.
        public LibraryJournal(string theTitle, string thePublisher, int theCopyrightYear,
            int theLoanPeriod, string theCallNumber, int theVolume, int theNumber,
            string theDiscipline, string theEditor) :
            base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theVolume, theNumber)
        {
            Discipline = theDiscipline;
            Editor = theEditor;
        }

        public string Discipline
        {
            // Precondition:  None
            // Postcondition: The discipline has been returned
            get
            {
                return _discipline;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The discipline has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _discipline = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Discipline)}", value,
                        $"{nameof(Discipline)} must not be null or empty");
            }
        }

        public string Editor
        {
            // Precondition:  None
            // Postcondition: The editor has been returned
            get
            {
                return _editor;
            }

            // Precondition:  value must not be null or empty
            // Postcondition: The editor has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _editor = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Editor)}", value,
                        $"{nameof(Editor)} must not be null or empty");
            }
        }

        // Precondition:  daysLate >= 0
        // Postcondition: The fee for returning the item the specified days late
        //                has been returned
        public override decimal CalcLateFee(int daysLate)
        {
            ValidateDaysLate(daysLate);

            return daysLate * DAILYLATEFEE;
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary item's data on
        //                separate lines
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut

            return $"LibraryJournal{NL}Discipline: {Discipline}{NL}Editor: {Editor}{NL}" +
                $"{base.ToString()}";
        }
    }
}
