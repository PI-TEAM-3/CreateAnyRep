using System.ComponentModel.DataAnnotations;

namespace Finance.ViewModel
{
    public class TypeOperation
    {
        public int TypeOperationId { get; set; }
        [Required(ErrorMessage = "Enter the name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter the type")]
        public bool IsIncome { get; set; }
    }
}
