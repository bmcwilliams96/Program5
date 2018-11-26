// Program 3
// CIS 200-01
// Spring 2017
// By: Andrew L. Wright

// File: Library.cs
// This file creates a basic Library class that stores a list
// of LibraryItems and a list of LibraryPatrons. It allows items
// to be checked out by patrons. The lists are accessible to other
// classes in the same namespace (LibraryItems).
// Now Serializable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    [Serializable]
    public class Library
    {
        // Namespace Accessible Data - Use with care
        internal Dictionary<string, LibraryItem> _items;     // List of items stored in Library
        internal Dictionary<string, LibraryPatron> _patrons; // List of patrons of Library
        internal Dictionary<string, DateTime> _checkouttransactions = new Dictionary<string, DateTime>(); //Dictionary to keep track of transactions.
        // Precondition:  None
        // Postcondition: The library has been created and is empty (no books, no patrons)
        public Library()
        {
            _items = new Dictionary<string, LibraryItem>();
            _patrons = new Dictionary<string, LibraryPatron>();
        }

        // Precondition:  None
        // Postcondition: A patron has been created with the specified values for name and ID.
        //                The patron has been added to the Library.
        public void AddPatron(String name, String id)
        {
            _patrons.Add(id,new LibraryPatron(name, id)) ;
        }

        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0
        // Postcondition: A library book has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, and author. The item is not checked out.
        //                The book has been added to the Library.
        public void AddLibraryBook(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, String theAuthor)
        {
            _items.Add(theCallNumber, new LibraryBook(theTitle, thePublisher, theCopyrightYear, theLoanPeriod,
                theCallNumber, theAuthor));
        }

        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0 and 
        //                theMedium from { DVD, BLURAY, VHS } and theDuration >= 0
        // Postcondition: A library movie has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, duration, director, medium, and rating. The
        //                item is not checked out.
        //                The movie has been added to the Library.
        public void AddLibraryMovie(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, double theDuration, String theDirector,
            LibraryMediaItem.MediaType theMedium, LibraryMovie.MPAARatings theRating)
        {
            _items.Add(theCallNumber ,new LibraryMovie(theTitle, thePublisher, theCopyrightYear, theLoanPeriod,
                theCallNumber, theDuration, theDirector, theMedium, theRating));
        }

        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0 and 
        //                theMedium from { CD, SACD, VINYL } and theDuration >= 0 and
        //                theNumTracks >= 0
        // Postcondition: A library music item has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, duration, director, medium, and rating. The
        //                item is not checked out.
        //                The music item has been added to the Library.
        public void AddLibraryMusic(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, double theDuration, String theArtist,
            LibraryMediaItem.MediaType theMedium, int theNumTracks)
        {
            _items.Add(theCallNumber ,new LibraryMusic(theTitle, thePublisher, theCopyrightYear,
            theLoanPeriod, theCallNumber, theDuration, theArtist,
            theMedium, theNumTracks));
        }

        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0 and
        //                theVolume >= 0 and theNumber >= 0
        // Postcondition: A library journal has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, volume, number, discipline, and editor. The
        //                item is not checked out.
        //                The journal has been added to the Library.
        public void AddLibraryJournal(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, int theVolume, int theNumber,
            String theDiscipline, String theEditor)
        {
            _items.Add(theCallNumber ,new LibraryJournal(theTitle, thePublisher, theCopyrightYear,
            theLoanPeriod, theCallNumber, theVolume, theNumber,
            theDiscipline, theEditor));
        }

        // Precondition:  theCopyrightYear >= 0 and theLoanPeriod >= 0 and
        //                theVolume >= 0 and theNumber >= 0
        // Postcondition: A library magazine has been created with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, volume, and number. The item is not checked out.
        //                The magazine has been added to the Library.
        public void AddLibraryMagazine(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, int theVolume, int theNumber)
        {
            _items.Add(theCallNumber ,new LibraryMagazine(theTitle, thePublisher, theCopyrightYear,
            theLoanPeriod, theCallNumber, theVolume, theNumber));
        }

        // Precondition:  None
        // Postcondition: The number of patrons in the library is returned
        public int GetPatronCount()
        {
            return _patrons.Count;
        }

        // Precondition:  None
        // Postcondition: The number of items in the library is returned
        public int GetItemCount()
        {
            return _items.Count;
        }

        // Precondition:  0 <= itemIndex < GetItemCount()
        //                0 <= patronIndex < GetPatronCount()
        // Postcondition: The specified item will be checked out by
        //                the specifed patron
        public void CheckOut(string itemCallNumber, string patronID)
        {
            DateTime CheckoutTimeStamp = DateTime.Now.AddDays(-21); //Variable to hold the time stamp of the transaction.
            

            _items[itemCallNumber].CheckOut(_patrons[patronID]);
            _checkouttransactions.Add(itemCallNumber, CheckoutTimeStamp);

        }

        // Precondition:  0 <= bookIndex < GetItemCount()
        // Postcondition: The specified book will be returned to shelf
        public decimal ReturnToShelf(string itemCallNumber)
        {
            DateTime Now = DateTime.Now; //Now
            decimal LateFee = 0; //Variable to hold the late fee.
            int TimeDifference = Now.Day - _checkouttransactions[itemCallNumber].Day;
            _items[itemCallNumber].ReturnToShelf();

            if (TimeDifference <= 0)
            {
                _checkouttransactions.Remove(itemCallNumber);
                return 0;
            }
            else
            {
                LateFee = _items[itemCallNumber].CalcLateFee(TimeDifference);
                _checkouttransactions.Remove(itemCallNumber);
                return LateFee;
            }

            
        }

        // Precondition:  None
        // Postcondition: The number of items checked out from the library is returned
        public int GetCheckedOutCount()
        {
            return _checkouttransactions.Count; 
        }

        //Precondition: None
        //Postcondition: The dictionary of transactions is returned.
        internal Dictionary<string, DateTime> GetCheckedOutTransactions()
        {
            return _checkouttransactions;
        }

        // Namespace Helper Method - Use with care
        // Precondition:  None
        // Postcondition: The list of items stored in the library is returned
        internal List<LibraryItem> GetItemsList()
        {
            return _items.Values.ToList();
        }

        // Namespace Helper Method - Use with care
        // Precondition:  None
        // Postcondition: The list of patrons stored in the library is returned
        internal List<LibraryPatron> GetPatronsList()
        {
            return _patrons.Values.ToList();
        }
        
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary in a formatted report
        public override string ToString()
        {
            // Using StringBuilder to show use of a more efficient way than String concatenation
            StringBuilder report = new StringBuilder(); // Will hold report as being built
            string NL = Environment.NewLine; // NewLine shortcut

            report.Append("Library Report\n");
            report.Append($"Number of items stored:      {GetItemCount(),4:d}{NL}");
            report.Append($"Number of items checked out: {GetCheckedOutCount(),4:d}{NL}");
            report.Append($"Number of patrons stored:    {GetPatronCount(),4:d}");

            return report.ToString();
        }
    }
}
