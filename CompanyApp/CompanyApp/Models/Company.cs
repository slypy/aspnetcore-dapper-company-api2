using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyApp.Models
{
    [Table("Companies")]
	public class Company
	{
        // Id should not be set by the user explicitly in most cases
        // Id should be auto-incremented by the database
		public int Id { get; }
		public string? Name { get; set; }
		public string? Address { get; set; }
		public string? Country { get; set; }

		public List<Employee> Employees { get; set; } = new List<Employee>();
	}
}
