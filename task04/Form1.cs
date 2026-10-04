using System;
using System.Drawing;
using System.Windows.Forms;

namespace task04
{
    public partial class frmExpenseClaimEstimator : Form
    {
        public frmExpenseClaimEstimator()
        {
            InitializeComponent();
        }

        private void frmExpenseClaimEstimator_Load(object sender, EventArgs e)
        {
            // Initial UI state
            lblMessage.Text = "";
            lblEstimatedAmount.Text = "$0.00";
            txtKilometres.Enabled = false;
            txtExpenseAmount.Enabled = false;
            cboExpenseCategory.SelectedIndex = -1;
        }

        private void cboExpenseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cboExpenseCategory.Text;

            if (category == "Mileage")
            {
                txtKilometres.Enabled = true;
                txtExpenseAmount.Enabled = false;
                txtExpenseAmount.Text = "";
            }
            else if (category == "Meal" || category == "Parking")
            {
                txtKilometres.Enabled = false;
                txtExpenseAmount.Enabled = true;
                txtKilometres.Text = "";
            }
        }

        private void btnCalculateEstimate_Click(object sender, EventArgs e)
        {
            // Clear previous results
            lblMessage.Text = "";
            lblEstimatedAmount.Text = "$0.00";
            txtClaimSummary.Text = "";
            lblMessage.ForeColor = Color.Black;

            InputValidator validator = new InputValidator();

            // 1. Validate basic details
            string category = cboExpenseCategory.Text;
            var basicValidation = validator.ValidateRequiredDetails(txtStaffName.Text, txtDescription.Text, category);

            if (!basicValidation.IsValid)
            {
                DisplayValidationError(basicValidation.Message);
                return;
            }

            // 2. Category-specific validation
            ValidationResult valueValidation = new ValidationResult();

            if (category == "Mileage")
            {
                valueValidation = validator.ValidateKilometres(txtKilometres.Text);
            }
            else if (category == "Meal" || category == "Parking")
            {
                valueValidation = validator.ValidateExpenseAmount(txtExpenseAmount.Text);
            }

            if (!valueValidation.IsValid)
            {
                DisplayValidationError(valueValidation.Message);
                return;
            }

            // 3. Calculation
            ExpenseCalculator calculator = new ExpenseCalculator();
            CalculationResult calcResult = calculator.CalculateEstimate(category, valueValidation.ValidValue);

            // 4. Populate ExpenseClaim object for summary
            ExpenseClaim claim = new ExpenseClaim
            {
                StaffName = txtStaffName.Text,
                ExpenseDate = dtpExpenseDate.Value,
                Category = category,
                Description = txtDescription.Text,
                Kilometres = category == "Mileage" ? valueValidation.ValidValue : 0,
                ExpenseAmount = (category == "Meal" || category == "Parking") ? valueValidation.ValidValue : 0
            };

            // 5. Display Result
            DisplayResult(claim, calcResult);
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtStaffName.Text = "";
            txtDescription.Text = "";
            dtpExpenseDate.Value = DateTime.Now;
            cboExpenseCategory.SelectedIndex = -1;
            
            txtKilometres.Text = "";
            txtKilometres.Enabled = false;
            
            txtExpenseAmount.Text = "";
            txtExpenseAmount.Enabled = false;

            lblMessage.Text = "";
            lblEstimatedAmount.Text = "$0.00";
            txtClaimSummary.Text = "";
        }

        private void DisplayValidationError(string message)
        {
            lblMessage.Text = message;
            lblMessage.ForeColor = Color.Red;
        }

        private void DisplayResult(ExpenseClaim claim, CalculationResult calcResult)
        {
            lblEstimatedAmount.Text = calcResult.EstimatedAmount.ToString("C");

            if (!string.IsNullOrEmpty(calcResult.Message))
            {
                lblMessage.Text = calcResult.Message;
                lblMessage.ForeColor = Color.Blue;
            }
            else
            {
                lblMessage.Text = "Calculation successful.";
                lblMessage.ForeColor = Color.Green;
            }

            txtClaimSummary.Text = $"Staff Name: {claim.StaffName}\r\n" +
                                   $"Date: {claim.ExpenseDate.ToShortDateString()}\r\n" +
                                   $"Category: {claim.Category}\r\n" +
                                   $"Description: {claim.Description}\r\n" +
                                   $"Estimated Reimbursement: {calcResult.EstimatedAmount:C}";
        }
    }
}
