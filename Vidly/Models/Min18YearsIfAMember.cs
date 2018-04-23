using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if (customer.BirthDate == null)
            {
                return new ValidationResult("Birthdate is required.");
            }

            var age = CalculateCustomerAge(customer.BirthDate.Value);

            return (age >= 18
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to join membership."));
        }

        private int CalculateCustomerAge(DateTime birthday)
        {

            int age = DateTime.Today.Year - birthday.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;

            if (birthday.Month < currentMonth ||
                (currentMonth == birthday.Month && birthday.Day < currentDay))
            {
                return age--;
            }

            return age;
        }
    }
}