using System;

namespace task04
{
    // Feature 1: Validation Results
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public decimal ValidValue { get; set; }
        public string Message { get; set; }
    }

    // Feature 2: Calculation Results
    public class CalculationResult
    {
        public decimal EstimatedAmount { get; set; }
        public string Message { get; set; }
    }

    // Data Model for the Claim
    public class ExpenseClaim
    {
        public string StaffName { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Kilometres { get; set; }
        public decimal ExpenseAmount { get; set; }
    }

    // Input Validator Component (Task 3 Logic)
    public class InputValidator
    {
        public ValidationResult ValidateRequiredDetails(string staffName, string description, string category)
        {
            if (string.IsNullOrWhiteSpace(staffName))
                return new ValidationResult { IsValid = false, Message = "Please enter staff name." };

            if (string.IsNullOrWhiteSpace(description))
                return new ValidationResult { IsValid = false, Message = "Please enter description." };

            if (string.IsNullOrWhiteSpace(category))
                return new ValidationResult { IsValid = false, Message = "Please select an expense category." };

            return new ValidationResult { IsValid = true };
        }

        public ValidationResult ValidateKilometres(string kilometresText)
        {
            if (string.IsNullOrWhiteSpace(kilometresText))
                return new ValidationResult { IsValid = false, Message = "Please enter kilometres travelled." };

            if (!decimal.TryParse(kilometresText, out decimal kilometres))
                return new ValidationResult { IsValid = false, Message = "Kilometres must be a valid number." };

            if (kilometres <= 0)
                return new ValidationResult { IsValid = false, Message = "Kilometres must be greater than zero." };

            return new ValidationResult { IsValid = true, ValidValue = kilometres };
        }

        public ValidationResult ValidateExpenseAmount(string amountText)
        {
            if (string.IsNullOrWhiteSpace(amountText))
                return new ValidationResult { IsValid = false, Message = "Please enter expense amount." };

            if (!decimal.TryParse(amountText, out decimal amount))
                return new ValidationResult { IsValid = false, Message = "Expense amount must be a valid number." };

            if (amount <= 0)
                return new ValidationResult { IsValid = false, Message = "Expense amount must be greater than zero." };

            return new ValidationResult { IsValid = true, ValidValue = amount };
        }
    }

    // Expense Calculator Component (Task 3 Logic)
    public class ExpenseCalculator
    {
        private const decimal MileageRate = 0.85m;
        private const decimal MealMaximum = 35.00m;
        private const decimal ParkingMaximum = 40.00m;

        public CalculationResult CalculateEstimate(string category, decimal validValue)
        {
            CalculationResult result = new CalculationResult();

            if (category == "Mileage")
            {
                result.EstimatedAmount = validValue * MileageRate;
                result.Message = ""; // No adjustment for mileage
            }
            else if (category == "Meal")
            {
                result.EstimatedAmount = Math.Min(validValue, MealMaximum);
                if (validValue > MealMaximum)
                {
                    result.Message = $"Meal amount was adjusted to the maximum of {MealMaximum:C}.";
                }
            }
            else if (category == "Parking")
            {
                result.EstimatedAmount = Math.Min(validValue, ParkingMaximum);
                if (validValue > ParkingMaximum)
                {
                    result.Message = $"Parking amount was adjusted to the maximum of {ParkingMaximum:C}.";
                }
            }

            return result;
        }
    }
}
