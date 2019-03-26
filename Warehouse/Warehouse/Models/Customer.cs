using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Models
{
	/// <summary>
	/// Customer entity
	/// </summary>
    public class Customer
    {
	    public string Id { get; set; }
	    
	    public string FirstName { get; set; }

	    public string LastName { get; set; }
	    public byte Age { get; set; }

		public DateTime CreationDate { get; set; }
	}
}
