using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Zo.Abp.Course.Product.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public Product()
        {
            Skus = new List<ProductSku>();
        }

        public string Name { get; set; }
        public string BarCode { get; set; }
        public Guid Provider { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ProductSku> Skus { get; set; }

    }


}
