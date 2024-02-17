namespace SportsStore.Models
{
	public class EFStoreRepository : IStoreRepository
	{
		private StoreDbContext _dbContext;

		public EFStoreRepository(StoreDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		IQueryable<Product> IStoreRepository.Products => _dbContext.Products;

	}
}
