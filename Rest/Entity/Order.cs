namespace ToTheSpa.Entity {
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Order : IEntity {
		[Key]
		public int OrderId { 
			get { return this.Id; }
			set { this.Id = value; } 
		}
		public int OrderNumber { get; set; }
		public string CustomerName { get; set; }
		public float TotalCost { get; set; }

		public List<OrderLine> Lines { get; set; } 
	}
}