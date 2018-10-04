namespace Models
{
	internal class DatabaseContextInitializer :
		System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
	{
		public DatabaseContextInitializer() : base()
		{
		}

		protected override void Seed(DatabaseContext databaseContext)
		{
			Country country = null;

			country = new Country() { Name = "Country (1)" };

			// بسیار بسیار مهم
			// تحت هر شرايطی
			country.States =
				new System.Collections.Generic.List<State>();

			State state = null;

			state = new State() { Name = "State (1)" };
			country.States.Add(state);

			state = new State() { Name = "State (2)" };
			country.States.Add(state);

			state = new State() { Name = "State (3)" };
			country.States.Add(state);

			databaseContext.Countries.Add(country);

			// Optional
			databaseContext.SaveChanges();
		}
	}
}
