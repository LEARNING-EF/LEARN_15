using System.Linq;
using System.Data.Entity;

namespace LEARNING_EF_CODE_FIRST
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				var countries =
					databaseContext.Countries
					.ToList()
					;

				//var countries =
				//	from Country in databaseContext.Countries
				//	where (Country.Name.Contains("ايران"))
				//	orderby (Country.Name)
				//	select new Models.Country() { Name = Country.Name }
				//	;

				//int countryCount = countries.Count();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void Solution1Button_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// Without [virtual] for [States] Property

				Models.Country country =
					databaseContext.Countries
					.FirstOrDefault();

				int stateCount =
					country.States.Count;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void Solution2Button_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// Without [virtual] for [States] Property

				Models.Country country =
					databaseContext.Countries
					.Include(current => current.States)
					.FirstOrDefault();

				int stateCount =
					country.States.Count;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void Solution3Button_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// With [virtual] for [States] Property

				Models.Country country =
					databaseContext.Countries
					.FirstOrDefault();

				int stateCount =
					country.States.Count;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void Solution4Button_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// With [virtual] for [States] Property

				Models.Country country =
					databaseContext.Countries
					.Include(current => current.States)
					.FirstOrDefault();

				int stateCount =
					country.States.Count;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
	}
}
