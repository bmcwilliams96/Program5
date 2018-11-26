namespace LibraryItems
{
    partial class CheckoutForm
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
            this.itemLbl = new System.Windows.Forms.Label();
            this.itemCbo = new System.Windows.Forms.ComboBox();
            this.patronCbo = new System.Windows.Forms.ComboBox();
            this.patronLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(12, 9);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(63, 13);
            this.itemLbl.TabIndex = 0;
            this.itemLbl.Text = "Select Item:";
            // 
            // itemCbo
            // 
            this.itemCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCbo.FormattingEnabled = true;
            this.itemCbo.Location = new System.Drawing.Point(15, 25);
            this.itemCbo.Name = "itemCbo";
            this.itemCbo.Size = new System.Drawing.Size(230, 21);
            this.itemCbo.TabIndex = 1;
            this.itemCbo.Validating += new System.ComponentModel.CancelEventHandler(this.itemCbo_Validating);
            this.itemCbo.Validated += new System.EventHandler(this.itemCbo_Validated);
            // 
            // patronCbo
            // 
            this.patronCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patronCbo.FormattingEnabled = true;
            this.patronCbo.Location = new System.Drawing.Point(15, 83);
            this.patronCbo.Name = "patronCbo";
            this.patronCbo.Size = new System.Drawing.Size(121, 21);
            this.patronCbo.TabIndex = 3;
            this.patronCbo.Validating += new System.ComponentModel.CancelEventHandler(this.patronCbo_Validating);
            this.patronCbo.Validated += new System.EventHandler(this.patronCbo_Validated);
            // 
            // patronLbl
            // 
            this.patronLbl.AutoSize = true;
            this.patronLbl.Location = new System.Drawing.Point(12, 67);
            this.patronLbl.Name = "patronLbl";
            this.patronLbl.Size = new System.Drawing.Size(74, 13);
            this.patronLbl.TabIndex = 2;
            this.patronLbl.Text = "Select Patron:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(146, 126);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(64, 126);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 15;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.patronCbo);
            this.Controls.Add(this.patronLbl);
            this.Controls.Add(this.itemCbo);
            this.Controls.Add(this.itemLbl);
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.ComboBox itemCbo;
        private System.Windows.Forms.ComboBox patronCbo;
        private System.Windows.Forms.Label patronLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}