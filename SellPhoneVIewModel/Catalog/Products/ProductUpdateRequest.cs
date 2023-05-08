﻿using Microsoft.AspNetCore.Http;

namespace Webapi.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }      

        public string LanguageId { set; get; }
        public IFormFile ThumbnailImage { get; set; }

    }
}
