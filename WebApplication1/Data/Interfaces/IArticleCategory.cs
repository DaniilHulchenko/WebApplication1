using WebApplication1.Models;

namespace WebApplication1.Data.Interfaces
{
    public interface IArticleCategory
    {
        //IEnumerable<Category> GetCategories();
        IEnumerable<Category> AllCategories { get; }
    }
}
