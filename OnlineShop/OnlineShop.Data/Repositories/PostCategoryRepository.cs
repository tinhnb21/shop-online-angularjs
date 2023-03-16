using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;

namespace OnlineShop.Data.Repositories
{
    public interface IPostCategoryRepository
    {
        
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPageRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
