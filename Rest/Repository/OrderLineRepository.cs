namespace ToTheSpa.Repository {
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading;
	using ToTheSpa.Entity;

	public interface IOrderLineRepository : IRepository<OrderLine> {
		List<OrderLine> GetAllForOrder(int OrderId);
	}

	public class OrderLineRepository : Repository<OrderLine>, IOrderLineRepository {

		static OrderLineRepository() {
			db.Add(new OrderLine { OrderLineId = 1, OrderId = 1, Product = "Widget", Quantity = 3, UnitPrice = 1.23 });
			db.Add(new OrderLine { OrderLineId = 2, OrderId = 1, Product = "Gadget", Quantity = 2, UnitPrice = 12.3 });
			db.Add(new OrderLine { OrderLineId = 3, OrderId = 1, Product = "Spiff", Quantity = 5, UnitPrice = .99 });
			db.Add(new OrderLine { OrderLineId = 4, OrderId = 1, Product = "Thing", Quantity = 7, UnitPrice = 7.2 });
			db.Add(new OrderLine { OrderLineId = 5, OrderId = 2, Product = "Spiff", Quantity = 3, UnitPrice = 15 });
			db.Add(new OrderLine { OrderLineId = 6, OrderId = 2, Product = "Gadget", Quantity =13, UnitPrice = 1.45 });
			db.Add(new OrderLine { OrderLineId = 7, OrderId = 3, Product = "Food", Quantity = 30, UnitPrice = 7.2 });
			db.Add(new OrderLine { OrderLineId = 8, OrderId = 3, Product = "Hampster", Quantity = 6, UnitPrice = 1.25 });
			db.Add(new OrderLine { OrderLineId = 9, OrderId = 3, Product = "Widget", Quantity = 8, UnitPrice = 1.23 });
			db.Add(new OrderLine { OrderLineId = 10, OrderId = 3, Product = "Earring", Quantity = 4, UnitPrice = 1.23 });
			db.Add(new OrderLine { OrderLineId = 11, OrderId = 3, Product = "Food", Quantity = 7, UnitPrice = 8.89 });
			db.Add(new OrderLine { OrderLineId = 12, OrderId = 3, Product = "Hopper", Quantity = 2, UnitPrice = 5.32 });
			db.Add(new OrderLine { OrderLineId = 13, OrderId = 4, Product = "Gadget", Quantity = 6, UnitPrice = 4.40 });
			db.Add(new OrderLine { OrderLineId = 14, OrderId = 4, Product = "Widget", Quantity = 4, UnitPrice = 1.63 });
			db.Add(new OrderLine { OrderLineId = 15, OrderId = 4, Product = "Stuff", Quantity = 8, UnitPrice = 1.43 });
			db.Add(new OrderLine { OrderLineId = 16, OrderId = 5, Product = "Spiff", Quantity = 6, UnitPrice = 1.83 });
			db.Add(new OrderLine { OrderLineId = 17, OrderId = 5, Product = "Food", Quantity = 13, UnitPrice = 1.93 });
			db.Add(new OrderLine { OrderLineId = 18, OrderId = 6, Product = "Earring", Quantity = 25, UnitPrice = 4.23 });
			db.Add(new OrderLine { OrderLineId = 19, OrderId = 6, Product = "Widget", Quantity = 14, UnitPrice = 1.43 });
			db.Add(new OrderLine { OrderLineId = 20, OrderId = 6, Product = "Gadget", Quantity = 27, UnitPrice = 1.73 });
			db.Add(new OrderLine { OrderLineId = 21, OrderId = 6, Product = "Thing", Quantity = 31, UnitPrice = 2.93 });
			db.Add(new OrderLine { OrderLineId = 22, OrderId = 6, Product = "Spiff", Quantity = 9, UnitPrice = 1.03 });
			db.Add(new OrderLine { OrderLineId = 23, OrderId = 7, Product = "Hampster", Quantity = 6, UnitPrice = 1.33 });
			db.Add(new OrderLine { OrderLineId = 24, OrderId = 7, Product = "Stuff", Quantity = 5, UnitPrice = 5.53 });
			db.Add(new OrderLine { OrderLineId = 25, OrderId = 7, Product = "Thing", Quantity = 3, UnitPrice = 1.73 });
			db.Add(new OrderLine { OrderLineId = 26, OrderId = 7, Product = "Gadget", Quantity = 6, UnitPrice = 1.43 });
			db.Add(new OrderLine { OrderLineId = 27, OrderId = 7, Product = "Widget", Quantity = 30, UnitPrice = 1.23 });
			db.Add(new OrderLine { OrderLineId = 28, OrderId = 7, Product = "Food", Quantity = 12, UnitPrice = 9.93 });
		}

		public List<OrderLine> GetAllForOrder(int OrderId) {
			Thread.Sleep(1500); // Simulate that this query takes a long time
			return (
				from l in db
				where l.OrderId == OrderId
				select l
			).ToList();
		}

	}
}
