using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Costumer:IEntity
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
       
        public string City { get; set; }

    }
}
