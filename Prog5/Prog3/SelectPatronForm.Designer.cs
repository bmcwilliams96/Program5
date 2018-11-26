namespace LibraryItems
{
    partial class SelectPatronForm
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.patronCbo = new System.Windows.Forms.ComboBox();
            this.patronLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(96, 65);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(14, 65);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 19;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // patronCbo
            // 
            this.patronCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patronCbo.FormattingEnabled = true;
            this.patronCbo.Location = new System.Drawing.Point(33, 25);
            this.patronCbo.Name = "patronCbo";
            this.patronCbo.Size = new System.Drawing.Size(121, 21);
            this.patronCbo.TabIndex = 18;
            this.patronCbo.Validating += new System.ComponentModel.CancelEventHandler(this.patronCbo_Validating);
            this.patronCbo.Validated += new System.EventHandler(this.patronCbo_Validated);
            // 
            // patronLbl
            // 
            this.patronLbl.AutoSize = true;
            this.patronLbl.Location = new System.Drawing.Point(30, 9);
            this.patronLbl.Name = "patronLbl";
            this.patronLbl.Size = new System.Drawing.Size(74, 13);
            this.patronLbl.TabIndex = 17;
            this.patronLbl.Text = "Select Patron:";
            // 
            // SelectPatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 103);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.patronCbo);
            this.Controls.Add(this.patronLbl);
            this.Name = "SelectPatronForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Patron to Edit";
            this.Load += new System.EventHandler(this.SelectPatronForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ComboBox patronCbo;
        private System.Windows.Forms.Label patronLbl;
    }
}