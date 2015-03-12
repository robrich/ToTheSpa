namespace ToTheSpa.Entity {
	/// <summary>
	/// It's an interface, but created here as an abstract class to avoid &quot;where IEntity, new()&quot;
	/// </summary>
	public abstract class IEntity {
		public IEntity() {
			this.IsActive = true;
		}
		public int Id { get; set; }
		public bool IsActive { get; set; }
	}
}
