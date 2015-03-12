namespace ToTheSpa.Entity {
	using System.ComponentModel.DataAnnotations;

	public class OrderLine : IEntity {
		[Key]
		public int OrderLineId {
			get { return this.Id; }
			set { this.Id = value; } 
		}
		public int OrderId { get; set; }
		public string Product { get; set; }
		public int Quantity { get; set; }
		public double UnitPrice { get; set; }
		public double LineTotal { get { return Quantity*UnitPrice; }}

		public Order Order { get; set; }
	}
}
