namespace ToTheSpa.Web.Controllers {
	using System.Collections.Generic;
	using System.Linq;
	using System.Web.Mvc;
	using ToTheSpa.Entity;
	using ToTheSpa.Repository;

	public class HomeController : Controller {
		private readonly IOrderRepository orderRepository;
		private readonly IOrderLineRepository orderLineRepository;

		public HomeController() {
			// FRAGILE: This sample is not about DI, it's about SPAs
			this.orderRepository = new OrderRepository();
			this.orderLineRepository = new OrderLineRepository();
		}

		public ActionResult Index(int? id) {
			List<Order> orders = this.orderRepository.GetAll();
			if (id > 0) {
				Order order = (from o in orders where o.OrderId == id select o).FirstOrDefault();
				if (order != null) {
					order.Lines = this.orderLineRepository.GetAllForOrder(id ?? 0);
				}
			}
			return this.View(orders);
		}
	}
}
