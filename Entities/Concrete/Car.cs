﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {

        public int CarId { get; set; }
        public string CarName { get; set; }
        public string Year { get; set; }



        public List<Photo> Photos { get; set; }
    }
}
