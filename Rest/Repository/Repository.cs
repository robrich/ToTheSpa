namespace ToTheSpa.Repository {
	using System.Collections.Generic;
	using System.Linq;
	using ToTheSpa.Entity;

	public interface IRepository<TEntity> where TEntity : IEntity {
		List<TEntity> GetAll();
		TEntity GetById(int CustomerId);
		void Save(TEntity Entity);
	}

	public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity {
		protected static readonly List<TEntity> db = new List<TEntity>();

		public virtual List<TEntity> GetAll() {
			return db.ToList(); // new array pointing to the same objects
		}

		public virtual TEntity GetById(int Id) {
			return (
				from c in db
				where c.Id == Id
				select c
			).FirstOrDefault();
		}

		// FRAGILE: this doesn't care for foreign key references
		public virtual void Save(TEntity Entity) {
			if (Entity.Id < 1) {
				// Invent an auto-incrementing id
				if (db.Count == 0) {
					Entity.Id = 1;
				} else {
					Entity.Id = (
						from c in db
						orderby c.Id descending
						select c.Id
					).First() + 1;
				}
			} else {
				// Remove the one we're about to replace if any
				TEntity dbCustomer = this.GetById(Entity.Id);
				if (dbCustomer != null) {
					db.Remove(dbCustomer);
				}
			}
			db.Add(Entity);
		}

	}
}
