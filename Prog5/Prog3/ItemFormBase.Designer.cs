namespace LibraryItems
{
    partial class ItemFormBase
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
            this.components = new System.ComponentModel.Container();
            this.itemTitleLbl = new System.Windows.Forms.Label();
            this.itemTitleTxt = new System.Windows.Forms.TextBox();
            this.itemPublisherLbl = new System.Windows.Forms.Label();
            this.itemPublisherTxt = new System.Windows.Forms.TextBox();
            this.itemCopyrightLbl = new System.Windows.Forms.Label();
            this.itemCopyrightTxt = new System.Windows.Forms.TextBox();
            this.itemLoanPeriodLbl = new System.Windows.Forms.Label();
            this.itemLoanPeriodTxt = new System.Windows.Forms.TextBox();
            this.itemCallNumberLbl = new System.Windows.Forms.Label();
            this.itemCallNumberTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // itemTitleLbl
            // 
            this.itemTitleLbl.AutoSize = true;
            this.itemTitleLbl.Location = new System.Drawing.Point(42, 11);
            this.itemTitleLbl.Name = "itemTitleLbl";
            this.itemTitleLbl.Size = new System.Drawing.Size(30, 13);
            this.itemTitleLbl.TabIndex = 1;
            this.itemTitleLbl.Text = "Title:";
            // 
            // itemTitleTxt
            // 
            this.itemTitleTxt.Location = new System.Drawing.Point(78, 8);
            this.itemTitleTxt.Name = "itemTitleTxt";
            this.itemTitleTxt.Size = new System.Drawing.Size(100, 20);
            this.itemTitleTxt.TabIndex = 2;
            this.itemTitleTxt.Validating += new System.ComponentModel.CancelEventHandler(this.itemTitleTxt_Validating);
            this.itemTitleTxt.Validated += new System.EventHandler(this.itemTitleTxt_Validated);
            // 
            // itemPublisherLbl
            // 
            this.itemPublisherLbl.AutoSize = true;
            this.itemPublisherLbl.Location = new System.Drawing.Point(19, 37);
            this.itemPublisherLbl.Name = "itemPublisherLbl";
            this.itemPublisherLbl.Size = new System.Drawing.Size(53, 13);
            this.itemPublisherLbl.TabIndex = 3;
            this.itemPublisherLbl.Text = "Publisher:";
            // 
            // itemPublisherTxt
            // 
            this.itemPublisherTxt.Location = new System.Drawing.Point(78, 34);
            this.itemPublisherTxt.Name = "itemPublisherTxt";
            this.itemPublisherTxt.Size = new System.Drawing.Size(100, 20);
            this.itemPublisherTxt.TabIndex = 4;
            // 
            // itemCopyrightLbl
            // 
            this.itemCopyrightLbl.AutoSize = true;
            this.itemCopyrightLbl.Location = new System.Drawing.Point(18, 63);
            this.itemCopyrightLbl.Name = "itemCopyrightLbl";
            this.itemCopyrightLbl.Size = new System.Drawing.Size(54, 13);
            this.itemCopyrightLbl.TabIndex = 5;
            this.itemCopyrightLbl.Text = "Copyright:";
            // 
            // itemCopyrightTxt
            // 
            this.itemCopyrightTxt.Location = new System.Drawing.Point(78, 60);
            this.itemCopyrightTxt.Name = "itemCopyrightTxt";
            this.itemCopyrightTxt.Size = new System.Drawing.Size(100, 20);
            this.itemCopyrightTxt.TabIndex = 6;
            this.itemCopyrightTxt.Validating += new System.ComponentModel.CancelEventHandler(this.itemCopyrightTxt_Validating);
            this.itemCopyrightTxt.Validated += new System.EventHandler(this.itemCopyrightTxt_Validated);
            // 
            // itemLoanPeriodLbl
            // 
            this.itemLoanPeriodLbl.AutoSize = true;
            this.itemLoanPeriodLbl.Location = new System.Drawing.Point(5, 89);
            this.itemLoanPeriodLbl.Name = "itemLoanPeriodLbl";
            this.itemLoanPeriodLbl.Size = new System.Drawing.Size(67, 13);
            this.itemLoanPeriodLbl.TabIndex = 7;
            this.itemLoanPeriodLbl.Text = "Loan Period:";
            // 
            // itemLoanPeriodTxt
            // 
            this.itemLoanPeriodTxt.Location = new System.Drawing.Point(78, 86);
            this.itemLoanPeriodTxt.Name = "itemLoanPeriodTxt";
            this.itemLoanPeriodTxt.Size = new System.Drawing.Size(100, 20);
            this.itemLoanPeriodTxt.TabIndex = 8;
            this.itemLoanPeriodTxt.Validating += new System.ComponentModel.CancelEventHandler(this.itemLoanPeriodTxt_Validating);
            this.itemLoanPeriodTxt.Validated += new System.EventHandler(this.itemLoanPeriodTxt_Validated);
            // 
            // itemCallNumberLbl
            // 
            this.itemCallNumberLbl.AutoSize = true;
            this.itemCallNumberLbl.Location = new System.Drawing.Point(5, 115);
            this.itemCallNumberLbl.Name = "itemCallNumberLbl";
            this.itemCallNumberLbl.Size = new System.Drawing.Size(67, 13);
            this.itemCallNumberLbl.TabIndex = 9;
            this.itemCallNumberLbl.Text = "Call Number:";
            // 
            // itemCallNumberTxt
            // 
            this.itemCallNumberTxt.Location = new System.Drawing.Point(78, 112);
            this.itemCallNumberTxt.Name = "itemCallNumberTxt";
            this.itemCallNumberTxt.Size = new System.Drawing.Size(100, 20);
            this.itemCallNumberTxt.TabIndex = 10;
            this.itemCallNumberTxt.Validating += new System.ComponentModel.CancelEventHandler(this.itemCallNumberTxt_Validating);
            this.itemCallNumberTxt.Validated += new System.EventHandler(this.itemCallNumberTxt_Validated);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(91, 186);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(9, 186);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 15;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ItemFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.itemCallNumberTxt);
            this.Controls.Add(this.itemCallNumberLbl);
            this.Controls.Add(this.itemLoanPeriodTxt);
            this.Controls.Add(this.itemLoanPeriodLbl);
            this.Controls.Add(this.itemCopyrightTxt);
            this.Controls.Add(this.itemCopyrightLbl);
            this.Controls.Add(this.itemPublisherTxt);
            this.Controls.Add(this.itemPublisherLbl);
            this.Controls.Add(this.itemTitleTxt);
            this.Controls.Add(this.itemTitleLbl);
            this.Name = "ItemFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label itemTitleLbl;
        protected System.Windows.Forms.TextBox itemTitleTxt;
        protected System.Windows.Forms.Label itemPublisherLbl;
        protected System.Windows.Forms.TextBox itemPublisherTxt;
        protected System.Windows.Forms.Label itemCopyrightLbl;
        protected System.Windows.Forms.TextBox itemCopyrightTxt;
        protected System.Windows.Forms.Label itemLoanPeriodLbl;
        protected System.Windows.Forms.TextBox itemLoanPeriodTxt;
        protected System.Windows.Forms.Label itemCallNumberLbl;
        protected System.Windows.Forms.TextBox itemCallNumberTxt;
        protected System.Windows.Forms.Button cancelBtn;
        protected System.Windows.Forms.Button okBtn;
        protected System.Windows.Forms.ErrorProvider errorProvider;

    }
}