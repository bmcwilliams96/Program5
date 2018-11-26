// Program 2
// CIS 200-01
// Due: 3/9/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: CheckoutForm.cs
// This class creates the Check Out dialog box form GUI. It performs validation
// and provides int get properties for each field that are associated with the
// index of the selected item and patron.

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
    public partial class CheckoutForm : Form
    {
        private List<LibraryItem> _items;     // List of library items
        private List<LibraryPatron> _patrons; // List of patrons

        // Precondition:  Lists itemList and patronList are populated with the available
        //                LibraryItems and LibraryPatrons, respectively, to choose from
        // Postcondition: The form's GUI is prepared for display.
        public CheckoutForm(List<LibraryItem> itemList, List<LibraryPatron> patronList)
        {
            InitializeComponent();

            _items = itemList;
            _patrons = patronList;
        }

        // Precondition:  None
        // Postcondition: The lists of items and patrons are used to populate the
        //                item and patron combo boxes, respectively
        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem item in _items)
                itemCbo.Items.Add(item.Title + ", " + item.CallNumber);

            foreach (LibraryPatron patron in _patrons)
                patronCbo.Items.Add(patron.PatronName + ", " + patron.PatronID);
        }

        internal int ItemIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item combo box has been returned
            get
            {
                return itemCbo.SelectedIndex;
            }
        }

        internal int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected patron combo box has been returned
            get
            {
                return patronCbo.SelectedIndex;
            }
        }

        // Precondition:  Focus is shifting from itemCbo
        // Postcondition: If selection is invalid, focus remains and error provider
        //                highlights the field
        private void itemCbo_Validating(object sender, CancelEventArgs e)
        {
            if (itemCbo.SelectedIndex == -1) // Nothing selected
            {
                e.Cancel = true;
                errorProvider.SetError(itemCbo, "Must select Item");
            }
        }

        // Precondition:  Validating of itemCbo not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void itemCbo_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(itemCbo, "");
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
