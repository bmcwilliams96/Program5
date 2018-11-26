// Program 2
// CIS 200-01
// Due: 3/9/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: PatronForm.cs
// This class creates the Patron dialog box form GUI. It performs validation
// and provides String properties for each field.

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
    public partial class PatronForm : Form
    {
        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display.
        public PatronForm()
        {
            InitializeComponent();
        }

        internal String PatronName
        {
            // Precondition:  None
            // Postcondition: The text of form's name field has been returned
            get
            {
                return patronNameTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's name field has been set to the specified value
            set
            {
                patronNameTxt.Text = value;
            }
        }

        internal String PatronID
        {
            // Precondition:  None
            // Postcondition: The text of form's ID field has been returned
            get
            {
                return patronIdTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's ID field has been set to the specified value
            set
            {
                patronIdTxt.Text = value;
            }
        }

        // Precondition:  Focus is shifting from patronNameTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void patronNameTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(patronNameTxt.Text)) // Empty/whitespace field
            {
                e.Cancel = true;
                patronNameTxt.SelectAll();
                errorProvider.SetError(patronNameTxt, "Must provide Name");
            }
        }

        // Precondition:  Validating of patronNameTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void patronNameTxt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(patronNameTxt, "");
        }

        // Precondition:  Focus is shifting from patronIdTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void patronIdTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(patronIdTxt.Text)) // Empty/whitespace field
            {
                e.Cancel = true;
                patronIdTxt.SelectAll();
                errorProvider.SetError(patronIdTxt, "Must provide ID");
            }
        }

        // Precondition:  Validating of patronIdTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void patronIdTxt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(patronIdTxt, "");
        }

        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes and sends Cancel result
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  User clicked on okBtn
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // If all controls validate
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result
        }
    }
}
