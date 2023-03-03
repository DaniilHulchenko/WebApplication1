namespace WebApplication1.Data.Repository
{
    public class CategoryRepository
    {
        public readonly FMDBContext db;
        public CategoryRepository(FMDBContext db)
        {
            this.db = db;
        }

    }
}
