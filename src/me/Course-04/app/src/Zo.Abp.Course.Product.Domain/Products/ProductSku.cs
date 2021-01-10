using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Zo.Abp.Course.Product.Products
{
    public class ProductSku : Entity<long>
    {
        public string ModalNo { get; set; }

        //不要写这个属性，领域层不要关注数据库设计，
        //若是MogoDb可能不需要外键，
        //要设计外键，请在.EntityFrameworkCore设置
        // public Guid ProductId { get; set; } 
    }
}
