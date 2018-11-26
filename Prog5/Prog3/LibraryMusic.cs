// Program 3
// CIS 200-01
// Due: 4/3/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: LibraryMusic.cs
// This file creates a concrete LibraryMusic class that adds
// artist and number of tracks.
// LibraryMusic IS-A LibraryMediaItem
// Now Serializable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    [Serializable]
    public class LibraryMusic : LibraryMediaItem
    {
        public const decimal DAILYLATEFEE = 0.50m; // Music's daily late fee
        public const decimal MAXFEE = 20.00m;      // Max late fee

        private string _artist;         // Music's artist
        private int _numTracks;         // Music's number of tracks
        private MediaType _musicMedium; // The music's medium

        // Precondition:  theCopyrightYear >= 0, theLoanPeriod >= 0, theDuration >= 0,
        //                theNumTracks >= 1
        //                theTitle and theCallNumber must not be null or empty
        // Postcondition: The movie has been initialized with the specified
        //                values for title, publisher, copyright year, loan period, 
        //                call number, duration, director, medium, and rating. The
        //                item is not checked out.
        public LibraryMusic(string theTitle, string thePublisher, int theCopyrightYear,
            int theLoanPeriod, string theCallNumber, double theDuration, string theArtist,
            MediaType theMedium, int theNumTracks) :
            base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber, theDuration)
        {
            Artist = theArtist;
            Medium = theMedium;
            NumTracks = theNumTracks;
        }

        public string Artist
        {
            // Precondition:  None
            // Postcondition: The artist has been returned
            get
            {
                return _artist;
            }

            // Precondition:  None
            // Postcondition: The artist has been set to the specified value
            set
            {
                // Since empty artist is OK, just change null to empty string
                _artist = (value == null ? string.Empty : value.Trim());
            }
        }

        public int NumTracks
        {
            // Precondition:  None
            // Postcondition: The number of tracks has been returned
            get
            {
                return _numTracks;
            }

            // Precondition:  value >= 1
            // Postcondition: The number of tracks has been set to the specified value
            set
            {
                if (value >= 1)
                    _numTracks = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(NumTracks)}", value,
                        $"{nameof(NumTracks)} must be >= 1");
            }
        }

        public override MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The medium has been returned
            get
            {
                return _musicMedium;
            }

            // Precondition:  value from { CD, SACD, VINYL }
            // Postcondition: The medium has been set to the specified value
            set
            {
                if (value == MediaType.CD || value == MediaType.SACD ||
                    value == MediaType.VINYL)
                    _musicMedium = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}",
                        value, $"{nameof(Medium)} must be from {{CD, SACD, VINYL}}");
            }
        }

        // Precondition:  daysLate >= 0
        // Postcondition: The fee for returning the item the specified days late
        //                has been returned
        public override decimal CalcLateFee(int daysLate)
        {
            decimal lateFee = 0.0M; // Late music fee

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

            return $"LibraryMusic{NL}Artist: {Artist}{NL}Num Tracks: {NumTracks}{NL}" +
                $"{base.ToString()}";
        }
    }
}
