using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.Data.Interfaces
{
    public interface IAllArticles
    {
        IEnumerable<Article> Articles { get; }
        IEnumerable<Article> GetFavorites { get;}
        Article GetObjArticle(int id); 
    }
}
