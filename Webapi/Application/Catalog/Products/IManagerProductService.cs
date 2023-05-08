using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Webapi.Catalog.Products;
using Webapi.Entities;
using SellPhoneVIewModel.Catalog.Products;
using CommonViewModel;
using SellPhoneVIewModel.Catalog.ProductImages;

namespace Webapi.Catalog.Products
{
    public interface IManagerProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<bool> UpdatePrice(int productId, decimal newPrice); 
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);

        Task<PagedResult <ProductViewModel>> GetAllPaging(GetManagerProductPagingRequest request);

        Task<int> AddImages(int productId, ProductImageCreateRequest productImage);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImage(int productId);

        Task<ProductImageViewModel> GetImageById(int imageId);


    }
}
