// Program 2
// CIS 200-01
// Due: 3/9/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: ItemFormBase.cs
// This class creates the base class for the Item dialog box form GUIs. It performs validation
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
    public partial class ItemFormBase : Form
    {
        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display.
        public ItemFormBase()
        {
            InitializeComponent();
        }

        internal String ItemTitle
        {
            // Precondition:  None
            // Postcondition: The text of form's title field has been returned
            get
            {
                return itemTitleTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's title field has been set to the specified value
            set
            {
                itemTitleTxt.Text = value;
            }
        }

        internal String ItemPublisher
        {
            // Precondition:  None
            // Postcondition: The text of form's publisher field has been returned
            get
            {
                return itemPublisherTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's publisher field has been set to the specified value
            set
            {
                itemPublisherTxt.Text = value;
            }
        }

        internal String ItemCopyrightYear
        {
            // Precondition:  None
            // Postcondition: The text of form's copyright field has been returned
            get
            {
                return itemCopyrightTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's copyright field has been set to the specified value
            set
            {
                itemCopyrightTxt.Text = value;
            }
        }

        internal String ItemLoanPeriod
        {
            // Precondition:  None
            // Postcondition: The text of form's loan period field has been returned
            get
            {
                return itemLoanPeriodTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's loan period field has been set to the specified value
            set
            {
                itemLoanPeriodTxt.Text = value;
            }
        }

        internal String ItemCallNumber
        {
            // Precondition:  None
            // Postcondition: The text of form's call number field has been returned
            get
            {
                return itemCallNumberTxt.Text;
            }

            // Precondition:  None
            // Postcondition: The text of form's call number field has been set to the specified value
            set
            {
                itemCallNumberTxt.Text = value;
            }
        }

        // Precondition:  Focus is shifting from itemTitleTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void itemTitleTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(itemTitleTxt.Text)) // Empty/whitespace field
            {
                e.Cancel = true;
                itemTitleTxt.SelectAll();
                errorProvider.SetError(itemTitleTxt, "Must provide Title");
            }
        }

        // Precondition:  Validating of itemTitleTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void itemTitleTxt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(itemTitleTxt, "");
        }

        // Precondition:  Focus is shifting from itemCopyrightTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void itemCopyrightTxt_Validating(object sender, CancelEventArgs e)
        {
            int copyright;     // Copyright year of item
            bool valid = true; // Is text valid?

            if (!int.TryParse(itemCopyrightTxt.Text, out copyright)) // Parse failed?
                valid = false;
            else if (copyright < 0)
                valid = false;

            if (!valid) // Invalid, so cancel and highlight field
            {
                e.Cancel = true;
                itemCopyrightTxt.SelectAll();
                errorProvider.SetError(itemCopyrightTxt, "Invalid Copyright Year!");
            }
        }

        // Precondition:  Validating of itemCopyrightTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void itemCopyrightTxt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(itemCopyrightTxt, "");
        }

        // Precondition:  Focus is shifting from itemLoanPeriodTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void itemLoanPeriodTxt_Validating(object sender, CancelEventArgs e)
        {
            int loanPeriod;     // Loan period of item
            bool valid = true; // Is text valid?

            if (!int.TryParse(itemLoanPeriodTxt.Text, out loanPeriod)) // Parse failed?
                valid = false;
            else if (loanPeriod < 0)
                valid = false;

            if (!valid) // Invalid, so cancel and highlight field
            {
                e.Cancel = true;
                itemLoanPeriodTxt.SelectAll();
                errorProvider.SetError(itemLoanPeriodTxt, "Invalid Loan Period!");
            }
        }

        // Precondition:  Validating of itemLoanPeriodTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void itemLoanPeriodTxt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(itemLoanPeriodTxt, "");
        }

        // Precondition:  Focus is shifting from itemCallNumberTxt
        // Postcondition: If text is invalid, focus remains and error provider
        //                highlights the field
        private void itemCallNumberTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(itemCallNumberTxt.Text)) // Empty/whitespace field
            {
                e.Cancel = true;
                itemCallNumberTxt.SelectAll();
                errorProvider.SetError(itemCallNumberTxt, "Must provide Call Number");
            }
        }

        // Precondition:  Validating of itemCallNumberTxt not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void itemCallNumberTxt_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(itemCallNumberTxt, "");
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
    }
}
