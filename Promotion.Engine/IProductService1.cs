using System.Collections.Generic;

public interface IProductService1
{
    void GetPriceByType(Product product);
    int GetTotalPrice(List<Product> products);
}