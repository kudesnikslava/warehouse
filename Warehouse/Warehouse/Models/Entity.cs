using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Models
{
	/// <summary>
	/// 
	/// </summary>
    public class Entity
    {
	    public string Id { get; set; }

	    public string Name { get; set; }

	    public DateTime CreatedDate { get; set; }

	    public int AvailableQuantity { get; set; }
	}
}
