using OnlineShop.Service;
using OnlineShop.Web.Infrastructure.Core;
using System.Collections.Generic;
using System.Web.Http;

namespace OnlineShop.Web.Api
{
    public class PostCategoryController : ApiControllerBase
    {

        public PostCategoryController(IErrorService errorService) : base(errorService)
        {

        }

    }
}
