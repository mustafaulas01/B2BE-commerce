using Autofac;
using DOGOB2B.BUSINESS.Abstract;
using DOGOB2B.BUSINESS.Concrete;
using DOGOB2B.DATAACCESS.Abstract;
using DOGOB2B.DATAACCESS.Concrete.Entity_Framework.Dals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.BUSINESS.Dependcy_Resolver
{
 public  class MyAutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();

            builder.RegisterType<EFProductDalcs>().As<IProductDal>();
            builder.RegisterType<EFCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<ShoopingCardManager>().As<IShoppingCardService>();
            builder.RegisterType<EFShoppingCardItemDal>().As<IShoppingCardItemDal> ();
        }
    }
}
