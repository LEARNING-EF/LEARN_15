﻿namespace Models
{
	public class Country : BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Country>
		{
			public Configuration() : base()
			{
			}
		}
		#endregion /Configuration

		public Country() : base()
		{
			// هر چند حتی در بعضی از منابع مایکروسافت ممکن است این رویه را
			// شاهد باشیم، ولی من توصیه نمی‌کنم
			//States =
			//	new System.Collections.Generic.List<State>();
		}

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string Name { get; set; }
		// **********

		// Solution (1) & (2)
		// **********
		// Eager Loading
		//public System.Collections.Generic.IList<State> States { get; set; }
		// **********
		// /Solution (1) & (2)

		// Solution (3) & (4)
		// **********
		// Lazy Loading
		public virtual System.Collections.Generic.IList<State> States { get; set; }
		// **********
		// /Solution (3) & (4)
	}
}
