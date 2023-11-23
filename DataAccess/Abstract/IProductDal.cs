using Core.DataAccess;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Buraya ürüne ait özel operasyonlar yazılacak.(ex:join)
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code Refactoring
