using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Data.Repository
{
    public class ArticleRepository : IAllArticles
    {
        private readonly FMDBContext db;

        public ArticleRepository(FMDBContext db)
            {
                this.db = db;
            }

        public IEnumerable<Article> Articles => FMDBContext.Articles.Include(c => c.Category);


        public Article GetObjArticle(int id)
        {
            return FMDBContext.Articles.FirstOrDefault(p => p.Id == id);
        }
    }
}
