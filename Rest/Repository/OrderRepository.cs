namespace ToTheSpa.Repository {
	using System.Collections.Generic;
	using System.Linq;
	using ToTheSpa.Entity;

	public interface IOrderRepository : IRepository<Order> {
	}

	public class OrderRepository : Repository<Order>, IOrderRepository {

		static OrderRepository() {
			db.Add(new Order {OrderId = 1,CustomerName = "John", OrderNumber = 1, TotalCost = 1234});
			db.Add(new Order {OrderId = 2,CustomerName = "Jack", OrderNumber = 2, TotalCost = 2345});
			db.Add(new Order {OrderId = 3,CustomerName = "Jennifer", OrderNumber = 3, TotalCost = 3456});
			db.Add(new Order {OrderId = 4,CustomerName = "Joanna", OrderNumber = 4, TotalCost = 4567});
			db.Add(new Order {OrderId = 5,CustomerName = "James", OrderNumber = 5, TotalCost = 5678});
			db.Add(new Order {OrderId = 6,CustomerName = "Jeorge", OrderNumber = 6, TotalCost = 6789});
			db.Add(new Order {OrderId = 7,CustomerName = "Jonny", OrderNumber = 7, TotalCost = 7890});
		}

		public override List<Order> GetAll() {
			foreach (Order order in db) {
				order.Lines = null;
			}
			return db.ToList(); // new array pointing to the same objects
		}

	}
}
