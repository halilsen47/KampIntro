using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //Entitiy Varlık Product
    internal class Product
    {
        
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }
    
        public int UnitPrice { get; set; }

        public int UnitInStock{ get; set; } 
        
        //CRUD OPARATİON - CREATE - READ - UPDATE - DELETE
    
    }
}
