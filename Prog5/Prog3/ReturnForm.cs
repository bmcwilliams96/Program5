// Program 2
// CIS 200-01
// Due: 3/9/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: ReturnForm.cs
// This class creates the Return dialog box form GUI. It performs validation
// and provides an int get property associated with the index of the
// selected item.

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
    public partial class ReturnForm : Form
    {
        private List<LibraryItem> _items; // List of library items

        // Precondition:  List itemList is populated with the available LibraryItems
        //                to choose from
        // Postcondition: The form's GUI is prepared for display.
        public ReturnForm(List<LibraryItem> itemList)
        {
            InitializeComponent();

            _items = itemList;
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

        // Precondition:  None
        // Postcondition: The list of items is used to populate the
        //                item combo box
        private void ReturnForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem item in _items)
                itemCbo.Items.Add(item.Title + ", " + item.CallNumber);
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
