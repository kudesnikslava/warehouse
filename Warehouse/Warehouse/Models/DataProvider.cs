using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.Models
{
    public class DataProvider
    {
	    private static DataProvider _instance;

		private List<Customer> _customers;
	    private List<Entity> _entities;

		public DataProvider()
	    {
			_customers = new List<Customer>();
		    _entities = new List<Entity>();

			InitCustomers();
		    InitEntities();
	    }

	    public static DataProvider Instance
	    {
		    get
		    {
			    if (_instance == null)
			    {
				    _instance = new DataProvider();
			    }

			    return _instance;
		    }
	    }

		#region Customers

		public List<Customer> Customers
	    {
		    get { return _customers; }
	    }

	    public Customer GetCustomer(string customerId)
	    {
		    return Customers.FirstOrDefault(f => f.Id == customerId);
	    }



	    private void InitCustomers()
	    {
		    _customers.Add( new Customer()
		    {
			    Id = "C1",
			    FirstName = "Petrov",
			    LastName = "Petr",
			    Age = 20,
			    CreationDate = new DateTime(2010, 12, 03, 14, 16, 54)
		    });

		    _customers.Add(new Customer()
		    {
			    Id = "C2",
			    FirstName = "Sidorov",
			    LastName = "Sidr",
			    Age = 25,
			    CreationDate = new DateTime(2011, 11, 04, 11, 26, 34)
		    });
	    }

	    public void AddCustomer(Customer customer)
	    {
		    _customers.Add(customer);
	    }

	    public void AddOrUpdateCustomer(Customer customer)
	    {
		    var index = _customers.FindIndex(f => f.Id == customer.Id);
		    if (index < 0)
		    {
			    AddCustomer(customer);
		    }
		    else
		    {
			    _customers[index] = customer;
		    }
	    }

		#endregion Customers


	    #region Entities

	    public List<Entity> Entities
		{
		    get { return _entities; }
	    }

	    public Entity GetEntity(string entityId)
	    {
		    return Entities.FirstOrDefault(f => f.Id == entityId);
	    }



	    private void InitEntities()
	    {
		    _entities.Add(new Entity()
		    {
			    Id = "E1",
			    Name = "Book",
			    CreatedDate = new DateTime(2010, 12, 03, 14, 16, 54),
				AvailableQuantity = 10
		    });

		    _entities.Add(new Entity()
		    {
			    Id = "E2",
			    Name = "Table",
			    CreatedDate = new DateTime(2010, 12, 03, 14, 16, 54),
			    AvailableQuantity = 5
		    });

		}

	    public void AddEntity(Entity entity)
	    {
		    _entities.Add(entity);
	    }

	    public void AddOrUpdateEntity(Entity entity)
	    {
		    var index = _entities.FindIndex(f => f.Id == entity.Id);
		    if (index < 0)
		    {
			    AddEntity(entity);
		    }
		    else
		    {
			    _entities[index] = entity;
		    }
	    }

		#endregion Entities
	}
}
