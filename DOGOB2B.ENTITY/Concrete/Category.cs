﻿using DOGOB2B.ENTITY.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.ENTITY.Concrete
{
public  class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
