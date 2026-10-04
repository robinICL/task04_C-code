namespace task04
{
    partial class frmExpenseClaimEstimator
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.cboExpenseCategory = new System.Windows.Forms.ComboBox();
            this.txtKilometres = new System.Windows.Forms.TextBox();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCalculateEstimate = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.lblEstimatedAmount = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtClaimSummary = new System.Windows.Forms.TextBox();
            
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblExpenseDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblKilometres = new System.Windows.Forms.Label();
            this.lblExpenseAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEstimatedAmountTitle = new System.Windows.Forms.Label();
            
            this.SuspendLayout();
            
            // lblStaffName
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(30, 30);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(69, 15);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Staff Name:";
            
            // txtStaffName
            this.txtStaffName.Location = new System.Drawing.Point(150, 27);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(200, 23);
            this.txtStaffName.TabIndex = 1;
            
            // lblExpenseDate
            this.lblExpenseDate.AutoSize = true;
            this.lblExpenseDate.Location = new System.Drawing.Point(30, 70);
            this.lblExpenseDate.Name = "lblExpenseDate";
            this.lblExpenseDate.Size = new System.Drawing.Size(78, 15);
            this.lblExpenseDate.TabIndex = 2;
            this.lblExpenseDate.Text = "Expense Date:";
            
            // dtpExpenseDate
            this.dtpExpenseDate.Location = new System.Drawing.Point(150, 64);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.Size = new System.Drawing.Size(200, 23);
            this.dtpExpenseDate.TabIndex = 3;
            
            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 110);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            
            // cboExpenseCategory
            this.cboExpenseCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpenseCategory.FormattingEnabled = true;
            this.cboExpenseCategory.Items.AddRange(new object[] {
            "Mileage",
            "Meal",
            "Parking"});
            this.cboExpenseCategory.Location = new System.Drawing.Point(150, 107);
            this.cboExpenseCategory.Name = "cboExpenseCategory";
            this.cboExpenseCategory.Size = new System.Drawing.Size(200, 23);
            this.cboExpenseCategory.TabIndex = 5;
            this.cboExpenseCategory.SelectedIndexChanged += new System.EventHandler(this.cboExpenseCategory_SelectedIndexChanged);
            
            // lblKilometres
            this.lblKilometres.AutoSize = true;
            this.lblKilometres.Location = new System.Drawing.Point(30, 150);
            this.lblKilometres.Name = "lblKilometres";
            this.lblKilometres.Size = new System.Drawing.Size(66, 15);
            this.lblKilometres.TabIndex = 6;
            this.lblKilometres.Text = "Kilometres:";
            
            // txtKilometres
            this.txtKilometres.Location = new System.Drawing.Point(150, 147);
            this.txtKilometres.Name = "txtKilometres";
            this.txtKilometres.Size = new System.Drawing.Size(200, 23);
            this.txtKilometres.TabIndex = 7;
            
            // lblExpenseAmount
            this.lblExpenseAmount.AutoSize = true;
            this.lblExpenseAmount.Location = new System.Drawing.Point(30, 190);
            this.lblExpenseAmount.Name = "lblExpenseAmount";
            this.lblExpenseAmount.Size = new System.Drawing.Size(100, 15);
            this.lblExpenseAmount.TabIndex = 8;
            this.lblExpenseAmount.Text = "Expense Amount:";
            
            // txtExpenseAmount
            this.txtExpenseAmount.Location = new System.Drawing.Point(150, 187);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(200, 23);
            this.txtExpenseAmount.TabIndex = 9;
            
            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 230);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            
            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(150, 227);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            this.txtDescription.TabIndex = 11;
            
            // btnCalculateEstimate
            this.btnCalculateEstimate.Location = new System.Drawing.Point(30, 310);
            this.btnCalculateEstimate.Name = "btnCalculateEstimate";
            this.btnCalculateEstimate.Size = new System.Drawing.Size(120, 30);
            this.btnCalculateEstimate.TabIndex = 12;
            this.btnCalculateEstimate.Text = "Calculate Estimate";
            this.btnCalculateEstimate.UseVisualStyleBackColor = true;
            this.btnCalculateEstimate.Click += new System.EventHandler(this.btnCalculateEstimate_Click);
            
            // btnClearForm
            this.btnClearForm.Location = new System.Drawing.Point(170, 310);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(120, 30);
            this.btnClearForm.TabIndex = 13;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            
            // lblEstimatedAmountTitle
            this.lblEstimatedAmountTitle.AutoSize = true;
            this.lblEstimatedAmountTitle.Location = new System.Drawing.Point(400, 30);
            this.lblEstimatedAmountTitle.Name = "lblEstimatedAmountTitle";
            this.lblEstimatedAmountTitle.Size = new System.Drawing.Size(110, 15);
            this.lblEstimatedAmountTitle.TabIndex = 14;
            this.lblEstimatedAmountTitle.Text = "Estimated Amount:";
            
            // lblEstimatedAmount
            this.lblEstimatedAmount.AutoSize = true;
            this.lblEstimatedAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstimatedAmount.Location = new System.Drawing.Point(520, 25);
            this.lblEstimatedAmount.Name = "lblEstimatedAmount";
            this.lblEstimatedAmount.Size = new System.Drawing.Size(50, 21);
            this.lblEstimatedAmount.TabIndex = 15;
            this.lblEstimatedAmount.Text = "$0.00";
            
            // lblMessage
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(400, 70);
            this.lblMessage.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 15);
            this.lblMessage.TabIndex = 16;
            
            // txtClaimSummary
            this.txtClaimSummary.Location = new System.Drawing.Point(400, 107);
            this.txtClaimSummary.Multiline = true;
            this.txtClaimSummary.Name = "txtClaimSummary";
            this.txtClaimSummary.ReadOnly = true;
            this.txtClaimSummary.Size = new System.Drawing.Size(350, 180);
            this.txtClaimSummary.TabIndex = 17;
            
            // frmExpenseClaimEstimator
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            
            this.Controls.Add(this.txtClaimSummary);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblEstimatedAmount);
            this.Controls.Add(this.lblEstimatedAmountTitle);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnCalculateEstimate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.lblExpenseAmount);
            this.Controls.Add(this.txtKilometres);
            this.Controls.Add(this.lblKilometres);
            this.Controls.Add(this.cboExpenseCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dtpExpenseDate);
            this.Controls.Add(this.lblExpenseDate);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.lblStaffName);
            
            this.Name = "frmExpenseClaimEstimator";
            this.Text = "Staff Expense Claim Estimator";
            this.Load += new System.EventHandler(this.frmExpenseClaimEstimator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.ComboBox cboExpenseCategory;
        private System.Windows.Forms.TextBox txtKilometres;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCalculateEstimate;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Label lblEstimatedAmount;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtClaimSummary;
        
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblExpenseDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblKilometres;
        private System.Windows.Forms.Label lblExpenseAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEstimatedAmountTitle;
    }
}
