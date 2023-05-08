using System.Collections.Generic;
using System.Threading.Tasks;
using CommonViewModel;

namespace Webapi.Catalog.Products
{
    public interface IPublicProductService
    {
        Task <PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId,GetPublicProductPagingRequest request);
    }
}
