using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeeManagerRazor.Models
{
	public class Employee
	{

		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(30)]
		[DisplayName("Employee Name")]
		public string Name { get; set; }

		[DisplayName("Phone Number")]
		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
		public long Mobile { get; set; }

		[Required]
		[DataType(DataType.EmailAddress)]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime BirthDate { get; set; }
	}
}
