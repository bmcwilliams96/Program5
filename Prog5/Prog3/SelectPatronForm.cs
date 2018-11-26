// Program 3
// CIS 200-01
// Spring 2017
// Due: 4/3/2017
// By: Andrew L. Wright

// File: SelectPatronForm.cs
// This class creates the Select Patron dialog box form GUI. It performs validation
// and provides an int get property associated with the index of the selected patron.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class SelectPatronForm : Form
    {
        private List<LibraryPatron> _patrons; // List of patrons

        // Precondition:  List patronList is populated with the available
        //                LibraryPatrons to choose from
        // Postcondition: The form's GUI is prepared for display.
        public SelectPatronForm(List<LibraryPatron> patronList)
        {
            InitializeComponent();

            _patrons = patronList;
        }

        // Precondition:  None
        // Postcondition: The list of patrons is used to populate the
        //                patron combo box
        private void SelectPatronForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in _patrons)
                patronCbo.Items.Add(patron.PatronName + ", " + patron.PatronID);
        }

        public int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected patron combo box has been returned
            get
            {
                return patronCbo.SelectedIndex;
            }
        }

        // Precondition:  Focus is shifting from patronCbo
        // Postcondition: If selection is invalid, focus remains and error provider
        //                highlights the field
        private void patronCbo_Validating(object sender, CancelEventArgs e)
        {
            if (patronCbo.SelectedIndex == -1) // Nothing selected
            {
                e.Cancel = true;
                errorProvider.SetError(patronCbo, "Must select Patron");
            }
        }

        // Precondition:  Validating of patronCbo not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void patronCbo_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(patronCbo, "");
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes and sends Cancel result
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            this.DialogResult = DialogResult.Cancel; // Causes form to close and return Cancel result
        }

        // Precondition:  User clicked on okBtn
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void okBtn_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result
        }
    }
}
