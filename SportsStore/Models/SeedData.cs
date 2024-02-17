using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
	public static class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			StoreDbContext context = app.ApplicationServices
				.CreateScope().ServiceProvider.GetService<StoreDbContext>();

			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();
			}

			if (!context.Products.Any())
			{
				context.AddRange(
					new Product
					{
						Name = "Kayak",
						Description = "A boat for an person",
						Category = "Watersports",
						Price = 275
					},

					new Product
					{
						Name = "Lifejacket",
						Description = "Protective and fashionable",
						Category = "Watersports",
						Price = 48.95M
					}

				);

				context.SaveChanges();
			}
		}
	}
}
