using DOGOB2B.ENTITY.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.ENTITY.Concrete
{
    public class Product:IEntity
    {

        public int Id { get; set; }

        public string ItemName { get; set; }
        public string ItemCode { get; set; }

        public int ItemDim1Code { get; set; }

        public string Gender { get; set; }

        public string MainProductGroup  { get; set; }

        public string BottomProductGroup { get; set; }

        public string ProductModel { get; set; }

        public string Barcode { get; set; }

        public string PicturePath { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }


    }
}
