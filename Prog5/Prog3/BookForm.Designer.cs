namespace LibraryItems
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookAuthorLbl = new System.Windows.Forms.Label();
            this.bookAuthorTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(92, 175);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(10, 175);
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // bookAuthorLbl
            // 
            this.bookAuthorLbl.AutoSize = true;
            this.bookAuthorLbl.Location = new System.Drawing.Point(31, 141);
            this.bookAuthorLbl.Name = "bookAuthorLbl";
            this.bookAuthorLbl.Size = new System.Drawing.Size(41, 13);
            this.bookAuthorLbl.TabIndex = 11;
            this.bookAuthorLbl.Text = "Author:";
            // 
            // bookAuthorTxt
            // 
            this.bookAuthorTxt.Location = new System.Drawing.Point(78, 138);
            this.bookAuthorTxt.Name = "bookAuthorTxt";
            this.bookAuthorTxt.Size = new System.Drawing.Size(100, 20);
            this.bookAuthorTxt.TabIndex = 12;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 217);
            this.Controls.Add(this.bookAuthorTxt);
            this.Controls.Add(this.bookAuthorLbl);
            this.Name = "BookForm";
            this.Text = "Book";
            this.Controls.SetChildIndex(this.itemTitleLbl, 0);
            this.Controls.SetChildIndex(this.itemTitleTxt, 0);
            this.Controls.SetChildIndex(this.itemPublisherLbl, 0);
            this.Controls.SetChildIndex(this.itemPublisherTxt, 0);
            this.Controls.SetChildIndex(this.itemCopyrightLbl, 0);
            this.Controls.SetChildIndex(this.itemCopyrightTxt, 0);
            this.Controls.SetChildIndex(this.itemLoanPeriodLbl, 0);
            this.Controls.SetChildIndex(this.itemLoanPeriodTxt, 0);
            this.Controls.SetChildIndex(this.itemCallNumberLbl, 0);
            this.Controls.SetChildIndex(this.itemCallNumberTxt, 0);
            this.Controls.SetChildIndex(this.okBtn, 0);
            this.Controls.SetChildIndex(this.cancelBtn, 0);
            this.Controls.SetChildIndex(this.bookAuthorLbl, 0);
            this.Controls.SetChildIndex(this.bookAuthorTxt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label bookAuthorLbl;
        protected System.Windows.Forms.TextBox bookAuthorTxt;
    }
}