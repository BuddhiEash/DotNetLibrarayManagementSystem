using System.ComponentModel.DataAnnotations;

namespace LibrarayManagementSystem.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
        public String Name { get; set; }
    }
}

