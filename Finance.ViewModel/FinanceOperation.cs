using System;
using System.ComponentModel.DataAnnotations;

namespace Finance.ViewModel
{
    public class FinanceOperation
    {
        public int FinanceOperationId { get; set; }
        [Required(ErrorMessage = "Enter the value")]
        [Range(1, 1000000000, ErrorMessage = "The value can be from 1 to 1 billion")]
        public decimal Value { get; set; }
        [Required]
        [RegularExpression(@"^\d{4}-\d\d-\d\dT\d\d:\d\d:\d\d")]
        public string Data { get; set; }

        [Required]
        public int TypeOperationId { get; set; }
        public TypeOperation TypeOperation { get; set; }
    }
}
