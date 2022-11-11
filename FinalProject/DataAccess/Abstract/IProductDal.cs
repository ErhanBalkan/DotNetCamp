using System.Collections.Generic;
public interface IProductDal : IEntityRepository<Product>{
    List<ProductDetailDto> GetProductDetails();
}